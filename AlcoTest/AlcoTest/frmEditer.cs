using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlcoTest
{
    public partial class frmEditer : Form
    {
        
        ModeleAlcoTest model;
        public frmEditer()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            
            Dictionary<string, int> dic = new Dictionary<string, int>();
            model.SauverData(Convert.ToInt32(tbxMasse.Text), Convert.ToChar(cbxSexe.Text));
            foreach (var items in lsbEditer.Items)
            {
                string alc = items.ToString().Substring(0, items.ToString().IndexOf(","));
                string pourcent = items.ToString().Substring(items.ToString().IndexOf(",")+1);
                int pour = Convert.ToInt32(pourcent.Replace("%",""));
                dic.Add(alc, pour);
            }
            model.SauverAlcfav(dic, "..\\..\\Resources\\AlcoolFav.txt");
            this.Close();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            lsbEditer.Items.Add(cbxFav.Text);


        }

        private void frmEditer_Load(object sender, EventArgs e)
        {
            model = new ModeleAlcoTest();
            model.AfficherToutAlcool("..\\..\\Resources\\Alcoool.txt");
            foreach (var item in model.ToutAlc)
            {
                cbxFav.Items.Add(item.Key + "," + item.Value+"%");
            }
            cbxFav.SelectedIndex = 0;
            cbxSexe.SelectedIndex = 0;
        }
    }
}
