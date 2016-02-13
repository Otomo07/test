namespace WindowsFormsApplication1
{
    partial class AdminModifAccount
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
            this.Compte = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Valider = new System.Windows.Forms.Button();
            this.Retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Compte :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // Compte
            // 
            this.Compte.Location = new System.Drawing.Point(130, 28);
            this.Compte.Name = "Compte";
            this.Compte.Size = new System.Drawing.Size(100, 20);
            this.Compte.TabIndex = 2;
            this.Compte.TextChanged += new System.EventHandler(this.Compte_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(130, 78);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 3;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(32, 158);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 4;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.button1_Click);
            // 
            // Retour
            // 
            this.Retour.Location = new System.Drawing.Point(203, 158);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(75, 23);
            this.Retour.TabIndex = 5;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            // 
            // AdminModifAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 262);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Compte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminModifAccount";
            this.Text = "AdminModifAccount";
            this.Load += new System.EventHandler(this.AdminModifAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Compte;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.Button Retour;
    }
}