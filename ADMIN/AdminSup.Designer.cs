namespace WindowsFormsApplication1
{
    partial class AdminSup
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Rafraichir = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Retour = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Freeze = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(23, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(348, 147);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Rafraichir
            // 
            this.Rafraichir.Location = new System.Drawing.Point(23, 165);
            this.Rafraichir.Name = "Rafraichir";
            this.Rafraichir.Size = new System.Drawing.Size(75, 23);
            this.Rafraichir.TabIndex = 1;
            this.Rafraichir.Text = "Rafraichir";
            this.Rafraichir.UseVisualStyleBackColor = true;
            this.Rafraichir.Click += new System.EventHandler(this.Rafraichir_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(104, 165);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 2;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(185, 165);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 3;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Retour
            // 
            this.Retour.Location = new System.Drawing.Point(295, 227);
            this.Retour.Name = "Retour";
            this.Retour.Size = new System.Drawing.Size(75, 23);
            this.Retour.TabIndex = 4;
            this.Retour.Text = "Retour";
            this.Retour.UseVisualStyleBackColor = true;
            this.Retour.Click += new System.EventHandler(this.Retour_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(266, 165);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 5;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Freeze
            // 
            this.Freeze.Location = new System.Drawing.Point(23, 206);
            this.Freeze.Name = "Freeze";
            this.Freeze.Size = new System.Drawing.Size(75, 23);
            this.Freeze.TabIndex = 6;
            this.Freeze.Text = "Freeze";
            this.Freeze.UseVisualStyleBackColor = true;
            this.Freeze.Click += new System.EventHandler(this.Freeze_Click);
            // 
            // AdminSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 262);
            this.Controls.Add(this.Freeze);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Retour);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Rafraichir);
            this.Controls.Add(this.listBox1);
            this.Name = "AdminSup";
            this.Text = "AdminSup";
            this.Load += new System.EventHandler(this.AdminSup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Rafraichir;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Retour;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Freeze;
    }
}