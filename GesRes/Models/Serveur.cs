using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesRes.Models
{
    class Serveur
    {
        public int Num_Serv { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Serveur()
        {

        }
        public Serveur(int num_serv,string nom,string prenom)
        {
            this.Num_Serv = num_serv;
            this.Nom = nom;
            this.Prenom = prenom;
        }
        public Serveur(string nom,string prenom)
        {
            this.Nom = nom;
            this.Prenom = prenom;
        }
    }
}
