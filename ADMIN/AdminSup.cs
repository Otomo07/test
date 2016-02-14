using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    
    public partial class AdminSup : Form
    {
        public static Compte compteAmodifier = new Compte(0, "", "");
        private static main monMain = new main();
        private List<Compte> compte = new List<Compte>();

        public AdminSup()
        {
            InitializeComponent();
            LoadPerso();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Rafraichir_Click(object sender, EventArgs e)
        {
            LoadPerso();
        }
        private void LoadPerso()
        {
            listBox1.Items.Clear();
            main m1 = new main();
            compte = m1.getCompte();
            foreach (Compte Uncompte in compte)
            {
                listBox1.Items.Add(Uncompte);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            supprimerLigne(@"C:\Users\Da\Desktop\Cours\Git\bin\Debug\Compte.txt", listBox1.SelectedItem.ToString());
            LoadPerso();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            compteAmodifier = (Compte)listBox1.SelectedItem;
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(AdminModif));
            monthread.Start();
            this.Close();

        }

        private void Retour_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(RetourMain));
            monthread.Start();
            this.Close();
        }

        private void AdminSup_Load(object sender, EventArgs e)
        {

        }
        private void RetourMain()
        {
            Application.Run(new main());
        }
        public Compte GetcompteAmodifier()
        {
            return compteAmodifier;
        }
        private void AdminModif()
        {
            Application.Run(new AdminModifAccount());
        }
        private void supprimerLigne(string path, string ligne)
        {
            string texte = null;
            string ligneActuelle = null;
            StreamReader sr = new StreamReader(path);
            // Ouverture du fichier
            while ((sr.Peek() != -1))
            {
                ligneActuelle = sr.ReadLine();
                if (!(ligneActuelle == ligne))
                {
                    texte = (texte
                                + (ligneActuelle + "\r\n"));
                }
            }
            sr.Close();
            StreamWriter sr2 = new StreamWriter(path);
            sr2.Write(texte);
            sr2.Close();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(Ajout));
            monthread.Start();
            this.Close();
            LoadPerso();
        }
        private void Ajout()
        {
            Application.Run(new CreatCompte());
        }
    }
}
