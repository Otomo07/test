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
    public partial class AdminModifAccount : Form
    {
        private static AdminSup admin = new AdminSup();
        public AdminModifAccount()
        {
            InitializeComponent();
            Compte compteaModif = admin.GetcompteAmodifier();
            Compte.Text = compteaModif.GetNom();
            Password.Text = compteaModif.GetPass();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Compte_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminModifAccount_Load(object sender, EventArgs e)
        {
            
        }
    }
}
