using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesRes.Models
{
    class Affecter
    {
        public int Num_Serveur { get; set; }
        public int Num_Table { get; set; }
        public DateTime Date_Affect { get; set; }

        public Affecter()
        {

        }
        public Affecter(int num_Serveur, int num_Table, DateTime date_Affect)
        {
            this.Num_Serveur = num_Serveur;
            this.Num_Table = num_Table;
            this.Date_Affect = date_Affect;
        }

    }
}
