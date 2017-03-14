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
            Ctrl.DeserializeModel();
            Dictionary<string, int> Alc = this.Ctrl.AfficherAlcDemande("..\\..\\Resources\\AlcoolFav.txt", "..\\..\\Resources\\Alcoool.txt");
            foreach (var item in Alc)
            {
                cbxAlcool.Items.Add(item.Key + " , " + item.Value + "%");
            }

            chart1.Series["Taux d'alcool"].Points.AddY(0);
            chart1.Series["Line"].Points.AddY(50);
            chart1.ChartAreas["Taux d'alcool"].AxisX.IntervalOffsetType = DateTimeIntervalType.Seconds;

        }
        private void tbrGramme_ValueChanged(object sender, EventArgs e)
        {
            lblProch.Text = tbrGramme.Value.ToString() + "CL";
        }

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditer editer = new frmEditer(this.Ctrl);
            editer.ShowDialog();
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

            chart1.Series["Taux d'alcool"].ChartType = SeriesChartType.FastLine;
            chart1.Series["Taux d'alcool"].Color = Color.Blue;
            chart1.Series["Line"].Color = Color.Red;
            chart1.Series["Taux d'alcool"].BorderWidth = 3;
            chart1.Series["Line"].BorderWidth = 5;
            chart1.ChartAreas["Taux d'alcool"].BorderDashStyle = ChartDashStyle.Solid;

            string pourcent = cbxAlcool.SelectedItem.ToString().Substring(cbxAlcool.SelectedItem.ToString().IndexOf(",") + 1);
            int pour = Convert.ToInt32(pourcent.Replace("%", ""));
            this.Ctrl.SetLitre(tbrGramme.Value);
            lblTaux.Text = this.Ctrl.boire(pour).ToString()+"mg/L de sang";
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
            this.Ctrl.Rafraichir();
            lblTaux.Text = this.Ctrl.GetTaux().ToString() + "mg/L de sang";
            chart1.Series["Taux d'alcool"].Points.AddY(this.Ctrl.GetTaux().ToString());
            chart1.Series["Line"].Points.AddY(50);
        }

        private void VueAcloTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Ctrl.SerializeModel();

        }




    }
}
