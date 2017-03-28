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
        private void VueAcloTest_Load(object sender, EventArgs e)
        {

            this.Ctrl = new ControleurAlcoTest(this);
            //Refresh at start to show level
            this.Ctrl.Rafraichir();
            lblTaux.Text = Ctrl.GetTaux().ToString();
            Dictionary<string, int> Alc = this.Ctrl.AfficherAlcDemande("..\\..\\Resources\\AlcoolFav.txt", "..\\..\\Resources\\Alcoool.txt");
            foreach (var item in Alc)
            {
                cbxAlcool.Items.Add(item.Key + " , " + item.Value + "%");
            }
            //If form was Serialized gets info from model 
            if (!this.Ctrl.Serializer)
            {
                AfficherGraphique();
                chart1.Series["Taux d'alcool"].Points.AddY(Ctrl.GetTaux());
                chart1.Series["Line"].Points.AddY(50);
                this.Ctrl.Rafraichir();
                chart1.Series["Taux d'alcool"].Points.AddY(Ctrl.GetTaux());
                chart1.Series["Line"].Points.AddY(50);
                timer1.Enabled = true;
            }
                //else create new chart
            else
            {
                chart1.Series["Taux d'alcool"].Points.AddY(0);
                chart1.Series["Line"].Points.AddY(50);
                chart1.ChartAreas["Taux d'alcool"].AxisX.IntervalOffsetType = DateTimeIntervalType.Seconds;
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
            AfficherGraphique();
            //Formats entry to calculate alcohol level
            string pourcent = cbxAlcool.SelectedItem.ToString().Substring(cbxAlcool.SelectedItem.ToString().IndexOf(",") + 1);
            int pour = Convert.ToInt32(pourcent.Replace("%", ""));
            this.Ctrl.SetLitre(Convert.ToInt32(cbxQteAlc.SelectedItem.ToString()));
            //updates level of alcohol and adds point in chart
            lblTaux.Text = this.Ctrl.boire(pour).ToString() + "mg/L de sang";
            chart1.Series["Taux d'alcool"].Points.AddY(this.Ctrl.GetTaux().ToString());
            chart1.Series["Line"].Points.AddY(50);
            timer1.Enabled = true;
        }

        private void cbxAlcool_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBoir.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //At each tick, updates level of alcohol and adds point in chart
            this.Ctrl.Rafraichir();
            lblTaux.Text = this.Ctrl.GetTaux().ToString() + "mg/L de sang";
            chart1.Series["Taux d'alcool"].Points.AddY(this.Ctrl.GetTaux().ToString());
            chart1.Series["Line"].Points.AddY(50);
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
            chart1.Series["Taux d'alcool"].ChartType = SeriesChartType.FastLine;
            chart1.Series["Taux d'alcool"].Color = Color.Blue;
            chart1.Series["Line"].Color = Color.Red;
            chart1.Series["Taux d'alcool"].BorderWidth = 3;
            chart1.Series["Line"].BorderWidth = 2;
            chart1.ChartAreas["Taux d'alcool"].BorderDashStyle = ChartDashStyle.Solid;
            chart1.Series["Taux d'alcool"].LegendText = "Taux d'alcool";
            chart1.Series["Line"].LegendText = "Limite Conduite";
        }



    }
}
