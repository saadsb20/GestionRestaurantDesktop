using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesRes.Models
{
    class Table
    {
        public int Num_Table { get; set; }
        public int Nb_Place { get; set; }

        public Table()
        {

        }
        public Table(int Nb_place)
        {
            this.Nb_Place = Nb_place;
        }
        public Table(int Num_table,int Nb_place)
        {
            this.Nb_Place = Nb_place;
            this.Num_Table = Num_table;
        }
    }
}
