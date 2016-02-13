using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class main : Form
    {
        public  string currentPseudo;
        public static int i = 0;
        public static List<Compte> compte = new List<Compte>();
        public main()
        {
            InitializeComponent();
        }
        public void Setcompte(string Login, string MDP)
        {
            Compte c1 = new Compte(i, Login, MDP);
            compte.Add(c1);
            System.IO.File.WriteAllText(@"C:\Users\Da\Desktop\Cours\1Sio\SIO4\a tier\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\Compte.txt", i+" "+ Login +" "+ MDP);
            i++;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirnouveauCreat));
            monthread.Start();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
                currentPseudo = "";
                string MDP = boxMDP.Text;
                string Login = boxLogin.Text;
                int connection = verifMDP(Login, MDP);
                if (connection == -1)
                {
                    MessageBox.Show("Compte incorrecte", "Erreur03", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                if (connection == 1)
                {
                    SetCurrent(Login);
                    System.Threading.Thread monthread2 = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirAccount));
                    monthread2.Start();
                    this.Close();
                }
                if (connection == 2)
                {
                    System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(Admin));
                    monthread.Start();
                    this.Close();
                } 
                

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxMDP_TextChanged(object sender, EventArgs e)
        {

        }
        private int  verifMDP(string login,string mdp)
        {
            foreach (Compte Uncompte in compte)
            {
                MessageBox.Show(Uncompte.GetNom());
                if (login == Uncompte.GetNom())
                {
                    if (mdp == Uncompte.GetPass())
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                if (login == "admin")
                {
                    if (mdp == "admin")
                    {
                        return 2;
                    }
                }

            }
            return -1;
        }
        private void ouvrirnouveauCreat()
        {
            Application.Run(new CreatCompte());
        }
        public int AccountChecker(string Pseudo)
        {
            foreach(Compte Uncompte in compte)
            {
                MessageBox.Show(Uncompte.GetNom());
                    if (Pseudo == Uncompte.GetNom())
                    {
                        return -1;
                    }
            }
            return 1;
        }
        public string GetPseudo ()
        {
            return currentPseudo;
        }
        public void SetCurrent(string pseudo)
        {
            currentPseudo = pseudo;
        }
        public void ouvrirAccount()
        {
            Application.Run(new Account());
        }
        public void Admin()
        {
            Application.Run(new Admin());
        }
        public List<Compte> getCompte()
        {
                return compte;
        }
        

    }
}
