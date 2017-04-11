namespace AlcoTest
{
    partial class frmEditer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMasse = new System.Windows.Forms.TextBox();
            this.cbxSexe = new System.Windows.Forms.ComboBox();
            this.lsbTout = new System.Windows.Forms.ListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.cbxFav = new System.Windows.Forms.ComboBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lsbAlcoolFav = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masse :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sexe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alcool favori :";
            // 
            // tbxMasse
            // 
            this.tbxMasse.Location = new System.Drawing.Point(127, 45);
            this.tbxMasse.Name = "tbxMasse";
            this.tbxMasse.Size = new System.Drawing.Size(124, 20);
            this.tbxMasse.TabIndex = 3;
            // 
            // cbxSexe
            // 
            this.cbxSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSexe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxSexe.FormattingEnabled = true;
            this.cbxSexe.Items.AddRange(new object[] {
            "F",
            "H"});
            this.cbxSexe.Location = new System.Drawing.Point(127, 69);
            this.cbxSexe.Name = "cbxSexe";
            this.cbxSexe.Size = new System.Drawing.Size(124, 21);
            this.cbxSexe.TabIndex = 6;
            // 
            // lsbTout
            // 
            this.lsbTout.FormattingEnabled = true;
            this.lsbTout.Location = new System.Drawing.Point(46, 168);
            this.lsbTout.Name = "lsbTout";
            this.lsbTout.Size = new System.Drawing.Size(131, 225);
            this.lsbTout.TabIndex = 7;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(338, 409);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(192, 216);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(75, 26);
            this.btnAddList.TabIndex = 9;
            this.btnAddList.Text = "ajouter";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // cbxFav
            // 
            this.cbxFav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFav.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxFav.FormattingEnabled = true;
            this.cbxFav.Location = new System.Drawing.Point(127, 96);
            this.cbxFav.Name = "cbxFav";
            this.cbxFav.Size = new System.Drawing.Size(124, 21);
            this.cbxFav.TabIndex = 10;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(192, 292);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lsbAlcoolFav
            // 
            this.lsbAlcoolFav.FormattingEnabled = true;
            this.lsbAlcoolFav.Location = new System.Drawing.Point(282, 168);
            this.lsbAlcoolFav.Name = "lsbAlcoolFav";
            this.lsbAlcoolFav.Size = new System.Drawing.Size(131, 225);
            this.lsbAlcoolFav.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Liste de tous les alcools";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Vos alcools préférés";
            // 
            // frmEditer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 452);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lsbAlcoolFav);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.cbxFav);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lsbTout);
            this.Controls.Add(this.cbxSexe);
            this.Controls.Add(this.tbxMasse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditer";
            this.Text = "frmEditer";
            this.Load += new System.EventHandler(this.frmEditer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMasse;
        private System.Windows.Forms.ComboBox cbxSexe;
        private System.Windows.Forms.ListBox lsbTout;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.ComboBox cbxFav;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ListBox lsbAlcoolFav;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}