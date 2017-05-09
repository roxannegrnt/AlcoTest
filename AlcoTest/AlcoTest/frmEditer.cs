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

namespace AlcoTest
{
    public partial class frmEditer : Form
    {
        private ControleurAlcoTest OtherCtrl;
        public frmEditer(ControleurAlcoTest ctrl)
        {
            InitializeComponent();
            OtherCtrl = ctrl;
        }
        private void frmEditer_Load(object sender, EventArgs e)
        {
            Dictionary<string, int> ToutAlc = OtherCtrl.AfficherToutAlcool("..\\..\\Resources\\Alcoool.txt");
            foreach (var item in ToutAlc)
            {
                lsbTout.Items.Add(item.Key + "," + item.Value + "%");
            }
            AjouterInfo();
        }
        private void btnValider_Click(object sender, EventArgs e)
        {
            //Validates new parameters
            Dictionary<string, int> dic = new Dictionary<string, int>();
            OtherCtrl.SauverData(Convert.ToDouble(tbxMasse.Text), Convert.ToChar(cbxSexe.Text));
            foreach (var items in lsbAlcoolFav.Items)
            {
                string alc = items.ToString().Substring(0, items.ToString().IndexOf(","));
                string pourcent = items.ToString().Substring(items.ToString().IndexOf(",") + 1);
                int pour = Convert.ToInt32(pourcent.Replace("%", ""));
                dic.Add(alc, pour);
            }
            OtherCtrl.SauverAlcfav(dic, "..\\..\\Resources\\AlcoolFav.txt");
            this.Close();
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            //Adds alcohol to list box and list of favorite alcohols
            int cpt = 0;
            if (lsbTout.SelectedIndex>=0)
            {
                foreach (var item in lsbAlcoolFav.Items)
                {
                    if (item.ToString() == lsbTout.SelectedItem.ToString())
                    {
                        cpt++;
                    }
                }
                if (cpt == 0)
                {
                    lsbAlcoolFav.Items.Add(lsbTout.SelectedItem.ToString());
                    Dictionary<string, int> dic = new Dictionary<string, int>();
                    foreach (var items in lsbAlcoolFav.Items)
                    {
                        string alc = items.ToString().Substring(0, items.ToString().IndexOf(","));
                        string pourcent = items.ToString().Substring(items.ToString().IndexOf(",") + 1);
                        int pour = Convert.ToInt32(pourcent.Replace("%", ""));
                        dic.Add(alc, pour);
                    }
                    OtherCtrl.SauverAlcfav(dic, "..\\..\\Resources\\AlcoolFav.txt");
                }
                else
                {
                    MessageBox.Show("L'alcool que vous voulez ajouter existe déjà dans la liste des favoris", "Erreur");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élément de la liste de tous les alcools à ajouter", "Erreur");
            }


        }
        private void AjouterInfo()
        {
            //Gets info after deserialization
            double masse = OtherCtrl.Getmasse();
            char sexe = OtherCtrl.GetSexe();
            Dictionary<string, int> ListeFav = OtherCtrl.GetAlcFav();
            foreach (var item in ListeFav)
            {
                lsbAlcoolFav.Items.Add(item.Key + "," + item.Value + "%");
            }
            if (masse != 0)
            {
                tbxMasse.Text = masse.ToString();
            }
            if (sexe != 0)
            {
                cbxSexe.SelectedItem = sexe.ToString();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //When the Delete alcool button is pressed
            if (lsbAlcoolFav.SelectedIndex >= 0)
            {
                lsbAlcoolFav.Items.Remove(lsbAlcoolFav.SelectedIndex);
                OtherCtrl.SupprimerAlcFav(lsbAlcoolFav.SelectedItem.ToString(), "..\\..\\Resources\\AlcoolFav.txt");
                Dictionary<string, int> ListeFav = OtherCtrl.GetAlcFav();
                lsbAlcoolFav.Items.Clear();
                foreach (var item in ListeFav)
                {
                    lsbAlcoolFav.Items.Add(item.Key + ", " + item.Value + "%");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un élément de la liste des alcools favoris à supprimer", "Supression impossible");
            }


        }


    }
}
