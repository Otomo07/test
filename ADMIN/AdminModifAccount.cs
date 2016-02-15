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

        public void button1_Click(object sender, EventArgs e)
        {
            Compte compteaModif = admin.GetcompteAmodifier();
            string pseudo = Compte.Text;
            string mdp = Password.Text;
            Maliste.modifierLigne(@"C:\Users\Da\Desktop\Cours\Git\bin\Debug\Compte.txt",compteaModif.GetNum()+" "+compteaModif.GetNom()+" "+compteaModif.GetPass()+" "+compteaModif.Getstatus(),compteaModif.GetNum()+" "+pseudo+" "+mdp+" "+compteaModif.Getstatus());
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(AdminSupr));
            monthread.Start();
            this.Close();
            
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
