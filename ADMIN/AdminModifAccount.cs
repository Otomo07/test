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
        private main Maliste = new main();
        public AdminModifAccount()
        {
            InitializeComponent();
            Compte compteaModif = admin.GetcompteAmodifier();
            Compte.Text = compteaModif.GetNom();
            Password.Text = compteaModif.GetPass();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Compte compteaModif = admin.GetcompteAmodifier();
            string pseudo = Compte.Text;
            string mdp = Password.Text;
            int Ppseudo = Maliste.AccountChecker(pseudo);
            if (Ppseudo == -1)
            {
                MessageBox.Show("Votre Pseudo existe deja !", "Erreur02", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Maliste.ModifAcc(compteaModif.GetNum(),pseudo, mdp);
                System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(AdminSupr));
                monthread.Start();
                this.Close();
            }
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

        private void Retour_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(AdminSupr));
            monthread.Start();
            this.Close();
        }
        private void AdminSupr()
        {
            Application.Run(new AdminSup());
        }
    }
}
