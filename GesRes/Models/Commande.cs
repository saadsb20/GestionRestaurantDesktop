using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesRes.Models
{
    class Commande
    {
        public int Num_Com { get; set; }
        public int Num_Table { get; set; }
        public DateTime Date_Com { get; set; }
        public int Nb_Pers { get; set; }
        public DateTime Heure_Pay { get; set; }
        public string Mode_Pay { get; set; }

        public Commande()
        {

        }
        public Commande(int num_Com, int num_Table, DateTime date_Com, int nb_Pers, DateTime heure_Pay, string mode_Pay)
        {
            this.Num_Com = num_Com;
            this.Num_Table = num_Table;
            this.Date_Com = date_Com;
            this.Nb_Pers = nb_Pers;
            this.Heure_Pay = heure_Pay;
            this.Mode_Pay = mode_Pay;
        }
        public Commande(int num_Table, DateTime date_Com, int nb_Pers, DateTime heure_Pay, string mode_Pay)
        {
            this.Num_Table = num_Table;
            this.Date_Com = date_Com;
            this.Nb_Pers = nb_Pers;
            this.Heure_Pay = heure_Pay;
            this.Mode_Pay = mode_Pay;
        }
    }
}
