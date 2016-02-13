using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Compte
    {
        private int numCompte;
        private string nom_compte;
        private string pass_compt;
        public Compte(int numero, string nom, string pass)
        {
            numCompte = numero;
            nom_compte = nom;
            pass_compt = pass;
        }
        public int GetNum()
        {
            return numCompte;
        }
        public string GetNom()
        {
            return nom_compte;
        }
        public string GetPass()
        {
            return pass_compt;
        }
        public void SetNum(int num)
        {
            numCompte = num;
        }
        public void SetNom(string nom)
        {
            nom_compte = nom;
        }
        public void SetPass(string pass)
        {
            pass_compt = pass;
        }
        public string AffCompt()
        {
            return (numCompte + " " + nom_compte + " " + pass_compt);
        }

    }
    
}
