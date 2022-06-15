using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesRes.Models
{
    class Plat
    {
        public int Code_Plat { get; set; }
        public string Libelle { get; set; }
        public string Type_Plat { get; set; }
        public int Prix { get; set; }

        public Plat()
        {

        }
        public Plat(int code_Plat, string libelle, string type_Plat, int prix)
        {
            this.Code_Plat = code_Plat;
            this.Libelle = libelle;
            this.Type_Plat = type_Plat;
            this.Prix = prix;
        }
        public Plat(string libelle, string type_Plat, int prix)
        {
            this.Libelle = libelle;
            this.Type_Plat = type_Plat;
            this.Prix = prix;
        }
    }
}
