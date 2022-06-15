using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesRes.Models
{
    class Contient
    {
        public int Num_Com { get; set; }
        public int Code_Plat { get; set; }
        public int Qte { get; set; }

        public Contient()
        {

        }
        public Contient(int num_Com, int code_Plat, int qte)
        {
            this.Num_Com = num_Com;
            this.Code_Plat = code_Plat;
            this.Qte = qte;
        }
    }
}
