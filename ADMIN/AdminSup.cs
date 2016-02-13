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
    public partial class AdminSup : Form
    {
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
             int rang = listBox1.SelectedItems.Count;
             if (rang == -1)
            {
                MessageBox.Show("Aucun compte selectionné", "erreur 04", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             compte.RemoveAt(rang-1);
             listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            Compte compteAmodifier = (Compte)listBox1.SelectedItem;

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
    }
}
