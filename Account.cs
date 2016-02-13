using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Account : Form
    {
        main Pseudo = new main();
        public Account()
        {
            InitializeComponent();
            label1.Text = Pseudo.GetPseudo();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(RetourMain));
            monthread.Start();
            this.Close();
        }
        private void RetourMain()
        {
            Application.Run(new main());
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
