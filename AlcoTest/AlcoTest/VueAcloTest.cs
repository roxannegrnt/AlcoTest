﻿using System;
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

        private void tbrGramme_ValueChanged(object sender, EventArgs e)
        {
            lblProch.Text = tbrGramme.Value.ToString()+"%";
        }
    }
}
