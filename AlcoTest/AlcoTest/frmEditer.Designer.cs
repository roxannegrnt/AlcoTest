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
            this.lsbEditer = new System.Windows.Forms.ListBox();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAddList = new System.Windows.Forms.Button();
            this.cbxFav = new System.Windows.Forms.ComboBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
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
            // lsbEditer
            // 
            this.lsbEditer.FormattingEnabled = true;
            this.lsbEditer.Location = new System.Drawing.Point(46, 168);
            this.lsbEditer.Name = "lsbEditer";
            this.lsbEditer.Size = new System.Drawing.Size(345, 225);
            this.lsbEditer.TabIndex = 7;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(353, 409);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 8;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAddList
            // 
            this.btnAddList.Location = new System.Drawing.Point(282, 91);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(109, 23);
            this.btnAddList.TabIndex = 9;
            this.btnAddList.Text = "Ajouter à la liste";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.btnAddList_Click);
            // 
            // cbxFav
            // 
            this.cbxFav.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxFav.FormattingEnabled = true;
            this.cbxFav.Location = new System.Drawing.Point(127, 96);
            this.cbxFav.Name = "cbxFav";
            this.cbxFav.Size = new System.Drawing.Size(124, 21);
            this.cbxFav.TabIndex = 10;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(46, 409);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 11;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmEditer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 444);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.cbxFav);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lsbEditer);
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
        private System.Windows.Forms.ListBox lsbEditer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.ComboBox cbxFav;
        private System.Windows.Forms.Button btnSupprimer;
    }
}