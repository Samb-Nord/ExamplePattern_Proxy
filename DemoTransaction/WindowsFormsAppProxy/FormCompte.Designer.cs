namespace WindowsFormsAppProxy
{
    partial class FormCompte
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
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.textBoxCredit = new System.Windows.Forms.TextBox();
            this.buttonCrediter = new System.Windows.Forms.Button();
            this.textBoxDebit = new System.Windows.Forms.TextBox();
            this.buttonDebiter = new System.Windows.Forms.Button();
            this.labelSolde = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.BackColor = System.Drawing.Color.Black;
            this.buttonDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeconnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDeconnexion.Location = new System.Drawing.Point(257, 355);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(119, 27);
            this.buttonDeconnexion.TabIndex = 13;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = false;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // textBoxCredit
            // 
            this.textBoxCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBoxCredit.Location = new System.Drawing.Point(26, 209);
            this.textBoxCredit.Multiline = true;
            this.textBoxCredit.Name = "textBoxCredit";
            this.textBoxCredit.Size = new System.Drawing.Size(126, 30);
            this.textBoxCredit.TabIndex = 12;
            // 
            // buttonCrediter
            // 
            this.buttonCrediter.BackColor = System.Drawing.Color.Maroon;
            this.buttonCrediter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrediter.ForeColor = System.Drawing.Color.Lime;
            this.buttonCrediter.Location = new System.Drawing.Point(177, 209);
            this.buttonCrediter.Name = "buttonCrediter";
            this.buttonCrediter.Size = new System.Drawing.Size(105, 30);
            this.buttonCrediter.TabIndex = 11;
            this.buttonCrediter.Text = "Créditer";
            this.buttonCrediter.UseVisualStyleBackColor = false;
            this.buttonCrediter.Click += new System.EventHandler(this.buttonCrediter_Click);
            // 
            // textBoxDebit
            // 
            this.textBoxDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDebit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDebit.Location = new System.Drawing.Point(26, 143);
            this.textBoxDebit.Multiline = true;
            this.textBoxDebit.Name = "textBoxDebit";
            this.textBoxDebit.Size = new System.Drawing.Size(126, 30);
            this.textBoxDebit.TabIndex = 10;
            // 
            // buttonDebiter
            // 
            this.buttonDebiter.BackColor = System.Drawing.Color.Maroon;
            this.buttonDebiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDebiter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDebiter.Location = new System.Drawing.Point(177, 143);
            this.buttonDebiter.Name = "buttonDebiter";
            this.buttonDebiter.Size = new System.Drawing.Size(105, 30);
            this.buttonDebiter.TabIndex = 9;
            this.buttonDebiter.Text = "Débiter";
            this.buttonDebiter.UseVisualStyleBackColor = false;
            this.buttonDebiter.Click += new System.EventHandler(this.buttonDebiter_Click);
            // 
            // labelSolde
            // 
            this.labelSolde.BackColor = System.Drawing.SystemColors.Control;
            this.labelSolde.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSolde.ForeColor = System.Drawing.Color.Teal;
            this.labelSolde.Location = new System.Drawing.Point(223, 9);
            this.labelSolde.Name = "labelSolde";
            this.labelSolde.Size = new System.Drawing.Size(153, 22);
            this.labelSolde.TabIndex = 8;
            this.labelSolde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Votre solde";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(384, 394);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.textBoxCredit);
            this.Controls.Add(this.buttonCrediter);
            this.Controls.Add(this.textBoxDebit);
            this.Controls.Add(this.buttonDebiter);
            this.Controls.Add(this.labelSolde);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormCompte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCompte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.TextBox textBoxCredit;
        private System.Windows.Forms.Button buttonCrediter;
        private System.Windows.Forms.TextBox textBoxDebit;
        private System.Windows.Forms.Button buttonDebiter;
        private System.Windows.Forms.Label labelSolde;
        private System.Windows.Forms.Label label1;
    }
}