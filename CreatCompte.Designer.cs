namespace WindowsFormsApplication1
{
    partial class CreatCompte
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
            this.Pseudo = new System.Windows.Forms.TextBox();
            this.MDP = new System.Windows.Forms.TextBox();
            this.MDP2 = new System.Windows.Forms.TextBox();
            this.Confirm = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pseudo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repeat Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Pseudo
            // 
            this.Pseudo.Location = new System.Drawing.Point(117, 33);
            this.Pseudo.Name = "Pseudo";
            this.Pseudo.Size = new System.Drawing.Size(100, 20);
            this.Pseudo.TabIndex = 3;
            this.Pseudo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MDP
            // 
            this.MDP.Location = new System.Drawing.Point(117, 82);
            this.MDP.Name = "MDP";
            this.MDP.Size = new System.Drawing.Size(100, 20);
            this.MDP.TabIndex = 4;
            this.MDP.UseSystemPasswordChar = true;
            this.MDP.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // MDP2
            // 
            this.MDP2.Location = new System.Drawing.Point(117, 132);
            this.MDP2.Name = "MDP2";
            this.MDP2.Size = new System.Drawing.Size(100, 20);
            this.MDP2.TabIndex = 5;
            this.MDP2.UseSystemPasswordChar = true;
            this.MDP2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(45, 184);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 6;
            this.Confirm.Text = "Confirmer";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(141, 183);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Annuler";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreatCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 225);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.MDP2);
            this.Controls.Add(this.MDP);
            this.Controls.Add(this.Pseudo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreatCompte";
            this.Text = "CreatCompte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Pseudo;
        private System.Windows.Forms.TextBox MDP;
        private System.Windows.Forms.TextBox MDP2;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Reset;
    }
}