﻿using System;
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
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class main : Form
    {
        public static string currentPseudo;
        public static List<Compte> compte = new List<Compte>();
        public main()
        {
            InitializeComponent();
            LoadPerso();
        }
        public void Setcompte(string Login, string MDP)
        {
            int i = NumCompte() + 1;
            Compte c1 = new Compte(i, Login, MDP,"None");
            compte.Add(c1);
            File.AppendAllText(@"C:\Users\Da\Desktop\Cours\Git\bin\Debug\Compte.txt", i + " " + Login + " " + MDP+" "+"None"+ Environment.NewLine);
            
            
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
                    foreach(Compte Uncompte in compte)
                    {
                        if (Uncompte.GetNom()== Login)
                        {
                            if(Uncompte.Getstatus()== "Freeze")
                            {
                                MessageBox.Show("Compte Freeze", "Erreur03", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                                break;
                            }
                            if(Uncompte.Getstatus() == "None")
                            {
                                SetCurrent(Login);
                                System.Threading.Thread monthread2 = new System.Threading.Thread(new System.Threading.ThreadStart(ouvrirAccount));
                                monthread2.Start();
                                this.Close();
                                break;
                            }
                        }
                    }
                   
                }
                if (connection == 2)
                {
                    System.Threading.Thread monthread = new System.Threading.Thread(new System.Threading.ThreadStart(AdminSup));
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
                    if (Pseudo == Uncompte.GetNom())
                    {
                        return -1;
                    }
            }
            return 1;
        }
        public string GetPseudo()
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
        private void AdminSup()
        {
            Application.Run(new AdminSup());
        }
        public List<Compte> getCompte()
        {
                return compte;
        }
        public void ModifAcc(int num, string Login, string MDP)
        {
            
        }
        public void modifierLigne(string path, string ligneToModif, string ligneFinale)
        {
            string texteFinal = null;
            StreamReader sr = new StreamReader(path);
            string ligneEnCoursDeLecture = null; 
            while (sr.EndOfStream ==false)
            {
                ligneEnCoursDeLecture = sr.ReadLine();
                if (ligneEnCoursDeLecture.Length > 1)
                {
                   
                   if (ligneEnCoursDeLecture == ligneToModif)
                   {
                        if(compte.Last().AffichCompte() != ligneEnCoursDeLecture)
                            texteFinal = (texteFinal + ligneFinale + "\r\n");
                        else
                            texteFinal = (texteFinal + ligneFinale);
                    }
                   else
                   {
                        if (compte.Last().AffichCompte() != ligneEnCoursDeLecture)
                            texteFinal = (texteFinal + ligneEnCoursDeLecture + "\r\n");
                        else
                            texteFinal = (texteFinal + ligneEnCoursDeLecture );
                    }
                }
            }
            sr.Close();
            StreamWriter sr2 = new StreamWriter(path);
            sr2.Write(texteFinal);
            sr2.Close();
        }
        public void LoadPerso()
        {
            compte.Clear();
            char sep = ' ';
            try
            {
                foreach (string line in File.ReadAllLines(@"C:\Users\Da\Desktop\Cours\Git\bin\Debug\Compte.txt"))
                {
                    String[] champs = line.Split(sep);
                    Compte c1 = new Compte(int.Parse(champs[0]), champs[1], champs[2], champs[3]);
                    compte.Add(c1);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(" l'erreur suivante s'est  produite : " + e + "pour le chargement des comptes");
            }
        }
        private static int NumCompte()
        { 
            if (compte.Count() == 0)
            {
                return -1;
            }
            return compte.Last().GetNum();
        }
        
 }
}
