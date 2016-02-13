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
    public partial class CreatCompte : Form
    {
        private main Maliste = new main();
        public CreatCompte()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pseudo = Pseudo.Text;
            string mdp = MDP.Text;
            string mdp2 = MDP2.Text;
            int Ppseudo = Maliste.AccountChecker(pseudo);
            if (Ppseudo == -1)
            {
                MessageBox.Show("Votre Pseudo existe deja !", "Erreur02", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (mdp != mdp2)
                {
                    MessageBox.Show("Votre mot de passe n'est pas identique", "Erreur01", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Maliste.Setcompte(pseudo, mdp);
                    System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(RetourMain));
                    monthread.Start();
                    this.Close();
                }
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(RetourMain));
            monthread.Start();
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void RetourMain()
        {
            Application.Run(new main());
        }
    }
}
