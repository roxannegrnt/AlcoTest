/*
 * Authors: Roxanne Grant and Ardi Ramushi
 * Project: AlcoTest
 * Description: Gives you your level of alcohol according to what you drink
 * Version: 1.0
 * Date: April 2017
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace AlcoTest
{
    public partial class VueAcloTest : Form
    {
        public VueAcloTest()
        {
            InitializeComponent();
        }
        private ControleurAlcoTest Ctrl;
        int cpt;
        private void VueAcloTest_Load(object sender, EventArgs e)
        {

            this.Ctrl = new ControleurAlcoTest(this);
            //Refresh at start to show level
            this.Ctrl.Rafraichir();
            lblTaux.Text = Math.Round(Ctrl.GetTaux(), 2).ToString() + "g/L de sang";
            Dictionary<string, int> Alc = this.Ctrl.AfficherAlcDemande("..\\..\\Resources\\AlcoolFav.txt", "..\\..\\Resources\\Alcoool.txt");
            foreach (var item in Alc)
            {
                cbxAlcool.Items.Add(item.Key + " , " + item.Value + "%");
            }
            //If form was Serialized gets info from model 
            if (!this.Ctrl.Serializer)
            {
                cpt = 0;
                AfficherGraphique();
                
                chart1.Series["Taux d'alcool"].Points.AddY(cpt, Ctrl.GetTaux());
                this.Ctrl.Rafraichir();
                timer1.Enabled = true;
            }
            //else create new chart
            else
            {
                chart1.Series["Taux d'alcool"].Points.AddY(0);
                chart1.ChartAreas["Taux d'alcool"].AxisX.IntervalOffsetType = DateTimeIntervalType.Hours;
            }
            //stop timer when alcohol level is at 0
            if (this.Ctrl.GetTaux() <= 0)
            {
                timer1.Enabled = false;
            }
        }

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditer editer = new frmEditer(this.Ctrl);
            editer.Show();
            editer.FormClosed += new FormClosedEventHandler(editer_FormClosed);
        }
        void editer_FormClosed(object sender, FormClosedEventArgs e)
        {
            cbxAlcool.Items.Clear();
            Dictionary<string, int> Alc = this.Ctrl.AfficherAlcDemande("..\\..\\Resources\\AlcoolFav.txt", "..\\..\\Resources\\Alcoool.txt");
            foreach (var item in Alc)
            {
                cbxAlcool.Items.Add(item.Key + " , " + item.Value + "%");
            }
            cbxAlcool.SelectedIndex = 0;
        }
        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APropos propos = new APropos();
            propos.ShowDialog();
        }

        private void btnBoir_Click(object sender, EventArgs e)
        {
            if (cbxQteAlc.SelectedIndex >= 0)
            {

                AfficherGraphique();
                //Formats entry to calculate alcohol level
                string pourcent = cbxAlcool.SelectedItem.ToString().Substring(cbxAlcool.SelectedItem.ToString().IndexOf(",") + 1);
                int pour = Convert.ToInt32(pourcent.Replace("%", ""));
                this.Ctrl.SetLitre(Convert.ToInt32(cbxQteAlc.SelectedItem.ToString()));
                //updates level of alcohol and adds point in chart
                lblTaux.Text = Math.Round(this.Ctrl.boire(pour), 2).ToString() + "g/L de sang";

                chart1.Series["Taux d'alcool"].Points.AddXY(cpt, this.Ctrl.GetTaux().ToString());
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Veuillez choisir une quantitée d'alcool", "Erreur");
            }
        }

        private void cbxAlcool_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnBoir.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //At each tick, updates level of alcohol and adds point in chart
            cpt++;
            this.Ctrl.Rafraichir();
            lblTaux.Text = Math.Round(this.Ctrl.GetTaux(), 2).ToString() + "g/L de sang";
            chart1.Series["Taux d'alcool"].Points.AddXY(cpt, this.Ctrl.GetTaux().ToString());
            Ctrl.AfficherAlcDemande("..\\..\\Resources\\AlcoolFav.txt", "..\\..\\Resources\\Alcoool.txt");

        }
        //When form is closing call serialize method
        private void VueAcloTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ctrl.SerializeModel();

        }
        private void AfficherGraphique()
        {
            //Design of chart
            chart1.ChartAreas["Taux d'alcool"].AxisY.Maximum = 3;
            chart1.ChartAreas["Taux d'alcool"].AxisY.Interval = 0.5;
            chart1.Series["Taux d'alcool"].CustomProperties = "IsXAxisQuantitative=True";
            chart1.ChartAreas["Taux d'alcool"].AxisX.Interval = 2;
            chart1.ChartAreas["Taux d'alcool"].AxisX.Maximum = 20;
            chart1.ChartAreas["Taux d'alcool"].AxisX.Minimum = 0;
            chart1.Series["Taux d'alcool"].ChartType = SeriesChartType.FastLine;
            chart1.Series["Taux d'alcool"].Color = Color.Blue;
            chart1.Series["Line"].Color = Color.Red;
            chart1.Series["Taux d'alcool"].BorderWidth = 3;
            chart1.Series["Line"].BorderWidth = 2;
            chart1.ChartAreas["Taux d'alcool"].BorderDashStyle = ChartDashStyle.Solid;
            chart1.Series["Taux d'alcool"].LegendText = "Taux d'alcool";
            chart1.Series["Line"].LegendText = "Limite Conduite";
            chart1.Series["Line"].Points.AddXY(chart1.ChartAreas["Taux d'alcool"].AxisX.Minimum, 0.5);
            chart1.Series["Line"].Points.AddXY(chart1.ChartAreas["Taux d'alcool"].AxisX.Maximum, 0.5);
            chart1.Series["Taux d'alcool"].Points.AddXY(0, 0);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            this.Ctrl.setTaux(0);
            lblTaux.Text = this.Ctrl.GetTaux().ToString();
            this.Ctrl.ClearFav();
            this.Ctrl.SauverData(60, 'F');
            chart1.Series[0].Points.Clear();


        }



    }
}
