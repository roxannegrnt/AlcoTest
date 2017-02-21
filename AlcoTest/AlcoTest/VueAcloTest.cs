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
    public partial class VueAcloTest : Form
    {
        public VueAcloTest()
        {
            InitializeComponent();
        }
        private void VueAcloTest_Load(object sender, EventArgs e)
        {
            
        }
        private void tbrGramme_ValueChanged(object sender, EventArgs e)
        {
            lblProch.Text = tbrGramme.Value.ToString()+"%";
        }

        private void editerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditer editer = new frmEditer();
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

        }

        
    }
}
