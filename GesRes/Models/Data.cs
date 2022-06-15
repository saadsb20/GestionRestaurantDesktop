using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using n = Npgsql;

namespace GesRes.Models
{
    class Data
    {
        static String cnxStr = "server=localhost;port=5432;user id=postgres; password=123456789; database=GesRestaurant";
        static n.NpgsqlConnection cnx = new n.NpgsqlConnection(cnxStr);
        static n.NpgsqlCommand cmd;
        static n.NpgsqlDataAdapter ada;
        List<Table> Tables = new List<Table>();
        List<Serveur> Serveurs = new List<Serveur>();
        List<Serveur> Serveurs1 = new List<Serveur>();
        List<Affecter> Affecters = new List<Affecter>();
        List<Commande> Commandes = new List<Commande>();
        List<Contient> Contients = new List<Contient>();
        List<Plat> Plats = new List<Plat>();
        List<Plat> Plats1 = new List<Plat>();
        
        public Data()
        {

        }

        //++++++++++++++++++++ Gestion des Tables +++++++++++++++++++++++++++ 
        public void AddTable(Table table)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO public.\"Table\" (\"Nb_Place\") VALUES(@Nb_Place)";
            cmd.Parameters.Add("@Nb_Place", NpgsqlTypes.NpgsqlDbType.Integer).Value = table.Nb_Place;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Added Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        } 
        public List<Table> SelectTables()
        {
            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.\"Table\"";
            ada = new n.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in dt.Columns)
                        Console.Write("\t{0}", row[column]);
                    Table table = new Table(Int32.Parse(row[0].ToString()), Int32.Parse(row[1].ToString()));
                    Tables.Add(table);


                    Console.WriteLine("++++++++++++++++++++++++++");
                    Console.WriteLine("Numero Table : " + Int32.Parse(row[0].ToString()));
                    Console.WriteLine("Nombre Place : " + Int32.Parse(row[1].ToString()));

                }

            }


            return Tables;
        }
        public void DeleteTable(int Num_Table)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "DELETE FROM public.\"Table\" WHERE \"Num_Table\" = " + Num_Table;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Deleted Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
        public void UpdateTable(int Num_Table,int NbPlace)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE public.\"Table\" SET \"Nb_Place\" = "+ NbPlace + " WHERE \"Num_Table\" = " + Num_Table;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Updated Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }

        //++++++++++++++++++++ Gestion des Serveurs +++++++++++++++++++++++++++ 
        public void AddServeur(Serveur serveur)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO public.\"Serveur\" (\"Nom\",\"Prenom\") VALUES(@Nom,@Prenom)";
            cmd.Parameters.Add("@Nom", NpgsqlTypes.NpgsqlDbType.Varchar).Value = serveur.Nom;
            cmd.Parameters.Add("@Prenom", NpgsqlTypes.NpgsqlDbType.Varchar).Value = serveur.Prenom;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Serveur Added Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
        public List<Serveur> SelectServeurs()
        {
            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.\"Serveur\"";
            ada = new n.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in dt.Columns)
                        Console.Write("\t{0}", row[column]);
                    Serveur serveur = new Serveur(Int32.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString());
                    Serveurs.Add(serveur);


                    Console.WriteLine("++++++++++++++++++++++++++");
                    Console.WriteLine("Numero Serveur : " + Int32.Parse(row[0].ToString()));
                    Console.WriteLine("Nom Serveur : " + row[1].ToString());
                    Console.WriteLine("Prenom Serveur : " + row[2].ToString());

                }
            }
                return Serveurs;
        }
        public void DeleteServeur(int Num_Serv)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "DELETE FROM public.\"Serveur\" WHERE \"Num_Serv\" = " + Num_Serv;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Serveur Deleted Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
        public void UpdateServeur(int Num_Serv, string nom,string prenom)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE public.\"Serveur\" SET \"Nom\" = \'" + nom + "\', \"Prenom\" = \'"+prenom+"\' WHERE \"Num_Serv\" = " + Num_Serv;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Serveur Updated Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
        public Serveur SelectOneServeur(int Num_Serveur)
        {
            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.\"Serveur\" WHERE \"Num_Serv\" = " + Num_Serveur;
            ada = new n.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in dt.Columns)
                        Console.Write("\t{0}", row[column]);
                    Serveur serveur = new Serveur(Int32.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString());
                    Serveurs1.Add(serveur);


                    Console.WriteLine("++++++++++++++++++++++++++");
                    Console.WriteLine("Numero Serveur : " + Int32.Parse(row[0].ToString()));
                    Console.WriteLine("Nom Serveur : " + row[1].ToString());
                    Console.WriteLine("Prenom Serveur : " + row[2].ToString());

                }
            }

            return Serveurs1.FirstOrDefault<Serveur>();
        }

        //++++++++++++++++++++ Gestion des Plats +++++++++++++++++++++++++++ 
        public void AddPlat(Plat plat)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO public.\"Plat\" (\"Libelle\",\"Type_Plat\",\"Prix\") VALUES(@Libelle,@Type_Plat,@Prix)";
            cmd.Parameters.Add("@Libelle", NpgsqlTypes.NpgsqlDbType.Varchar).Value = plat.Libelle;
            cmd.Parameters.Add("@Type_Plat", NpgsqlTypes.NpgsqlDbType.Varchar).Value = plat.Type_Plat;
            cmd.Parameters.Add("@Prix", NpgsqlTypes.NpgsqlDbType.Integer).Value = plat.Prix;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Plat Added Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
        public List<Plat> SelectPlats()
        {
            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.\"Plat\"";
            ada = new n.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in dt.Columns)
                        Console.Write("\t{0}", row[column]);
                    Plat plat = new Plat(Int32.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), Int32.Parse(row[3].ToString()));
                    Plats.Add(plat);

                    Console.WriteLine("++++++++++++++++++++++++++");
                    Console.WriteLine("Code Plat : " + Int32.Parse(row[0].ToString()));
                    Console.WriteLine("Libelle : " + row[1].ToString());
                    Console.WriteLine("Type Plat : " + row[2].ToString());
                    Console.WriteLine("Prix : " + Int32.Parse(row[3].ToString()));

                }
            }
            return Plats;
        }
        public void DeletePlat(int Code_Plat)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "DELETE FROM public.\"Plat\" WHERE \"Code_Plat\" = " + Code_Plat;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Plat Deleted Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
        public void UpdatePlat(int Code_Plat, string Libelle, string Type_Plat,int Prix)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE public.\"Plat\" SET \"Libelle\" = \'" + Libelle + "\', \"Type_Plat\" = \'" + Type_Plat + "\', \"Prix\" = \'" + Prix + "\' WHERE \"Code_Plat\" = " + Code_Plat;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Plat Updated Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
        public Plat SelectOnePlat(int Num_Plat)
        {
            Plats1.Clear();
            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.\"Plat\" WHERE \"Code_Plat\" = " + Num_Plat;
            ada = new n.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in dt.Columns)
                        Console.Write("\t{0}", row[column]);
                    Plat plat = new Plat(Int32.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString(), Int32.Parse(row[3].ToString()));
                    Plats1.Add(plat);

                    Console.WriteLine("++++++++++++++++++++++++++");
                    Console.WriteLine("Code Plat : " + Int32.Parse(row[0].ToString()));
                    Console.WriteLine("Libelle : " + row[1].ToString());
                    Console.WriteLine("Type Plat : " + row[2].ToString());
                    Console.WriteLine("Prix : " + Int32.Parse(row[3].ToString()));

                }
            }

            return Plats1.FirstOrDefault<Plat>();
        }

        //++++++++++++++++++++ Gestion des Affectation +++++++++++++++++++++++++++ 
        public void AddAffecter(Affecter affecter)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO public.\"Affecter\" (\"Num_Serv\",\"Date_Affect\",\"Num_Table\") VALUES(@Num_Serv,@Date_Affect,@Num_Table)";
            cmd.Parameters.Add("@Num_Serv", NpgsqlTypes.NpgsqlDbType.Integer).Value = affecter.Num_Serveur;
            cmd.Parameters.Add("@Date_Affect", NpgsqlTypes.NpgsqlDbType.Date).Value = affecter.Date_Affect;
            cmd.Parameters.Add("@Num_Table", NpgsqlTypes.NpgsqlDbType.Integer).Value = affecter.Num_Table;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Waiter Affected Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
        public List<Affecter> SelectAffecters()
        {
            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.\"Affecter\"";
            ada = new n.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in dt.Columns)
                        Console.Write("\t{0}", row[column]);
                    Affecter affecter = new Affecter(Int32.Parse(row[0].ToString()),Int32.Parse(row[2].ToString()), DateTime.Parse(row[1].ToString()));
                    Affecters.Add(affecter);

                    Console.WriteLine("++++++++++++++++++++++++++");
                    Console.WriteLine("Numero Serveur : " + Int32.Parse(row[0].ToString()));
                    Console.WriteLine("Date Affectation : " + row[1].ToString());
                    Console.WriteLine("Numero Table : " + row[2].ToString());

                }
            }
            return Affecters;
        }
        public void DeleteAffecter(int Code_Plat)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "DELETE FROM public.\"Plat\" WHERE \"Code_Plat\" = " + Code_Plat;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Plat Deleted Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
        public void UpdateAffecter(int Code_Plat, string Libelle, string Type_Plat,int Prix)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "UPDATE public.\"Plat\" SET \"Libelle\" = \'" + Libelle + "\', \"Type_Plat\" = \'" + Type_Plat + "\', \"Prix\" = \'" + Prix + "\' WHERE \"Code_Plat\" = " + Code_Plat;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Plat Updated Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }



        //++++++++++++++++++++ Gestion des Commandes +++++++++++++++++++++++++++ 
        public void AddCommande(Commande commande)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO public.\"Commande\" (\"Num_Table\",\"Date_Com\",\"Nb_Pers\",\"Heure_Pay\",\"Mode_Pay\") VALUES(@Num_Table,@Date_Com,@Nb_Pers,@Heure_Pay,@Mode_Pay)";
            cmd.Parameters.Add("@Num_Table", NpgsqlTypes.NpgsqlDbType.Integer).Value = commande.Num_Table;
            cmd.Parameters.Add("@Date_Com", NpgsqlTypes.NpgsqlDbType.Date).Value = commande.Date_Com;
            cmd.Parameters.Add("@Nb_Pers", NpgsqlTypes.NpgsqlDbType.Integer).Value = commande.Nb_Pers;
            cmd.Parameters.Add("@Heure_Pay", NpgsqlTypes.NpgsqlDbType.Time).Value = commande.Heure_Pay.TimeOfDay;
            cmd.Parameters.Add("@Mode_Pay", NpgsqlTypes.NpgsqlDbType.Varchar).Value = commande.Mode_Pay;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Cammande Added Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
        public List<Commande> SelectCommandes()
        {
            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.\"Commande\"";
            ada = new n.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in dt.Columns)
                        Console.Write("\t{0}", row[column]);
                    Commande commande = new Commande(Int32.Parse(row[0].ToString()), Int32.Parse(row[1].ToString()), DateTime.Parse(row[2].ToString()), Int32.Parse(row[3].ToString()), DateTime.Parse(row[4].ToString()), row[5].ToString());
                    Commandes.Add(commande);

                    Console.WriteLine("++++++++++++++++++++++++++");
                    Console.WriteLine("Numero Commande : " + commande.Num_Com);
                    Console.WriteLine("Numero Table : " + commande.Num_Table);
                    Console.WriteLine("Numero Date : " + commande.Date_Com);
                    Console.WriteLine("Numero Nombre Pers : " + commande.Nb_Pers);
                    Console.WriteLine("Numero Heure Pay : " + commande.Heure_Pay);
                    Console.WriteLine("Numero Mode Pay : " + commande.Mode_Pay);

                }
            }
            return Commandes;
        }


        //++++++++++++++++++++ Gestion des Commandes +++++++++++++++++++++++++++ 
        public void AddContient(Contient contient)
        {
            cmd = new n.NpgsqlCommand();
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "INSERT INTO public.\"Contient\" (\"Num_Com\",\"Code_Plat\",\"Qte\") VALUES(@Num_Com,@Code_Plat,@Qte)";
            cmd.Parameters.Add("@Num_Com", NpgsqlTypes.NpgsqlDbType.Integer).Value = contient.Num_Com;
            cmd.Parameters.Add("@Code_Plat", NpgsqlTypes.NpgsqlDbType.Integer).Value = contient.Code_Plat;
            cmd.Parameters.Add("@Qte", NpgsqlTypes.NpgsqlDbType.Integer).Value = contient.Qte;
            try
            {
                cmd.ExecuteNonQuery();
                Console.WriteLine("Contient Added Successfully");
                cnx.Close();

            }
            catch (n.NpgsqlException ex)
            {
                Console.WriteLine("Exception : " + ex);
                cnx.Close();
            }
        }
        public List<Contient> SelectContient(int Num_Com)
        {
            cmd = new n.NpgsqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = "SELECT * FROM public.\"Contient\" WHERE \"Num_Com\" = " + Num_Com;
            ada = new n.NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ada.Fill(dt);
            DataRow[] currentRows = dt.Select(null, null, DataViewRowState.CurrentRows);

            if (currentRows.Length < 1)
                Console.WriteLine("No Current Rows Found");
            else
            {
                foreach (DataColumn column in dt.Columns)
                    Console.Write("\t{0}", column.ColumnName);

                Console.WriteLine("\tRowState");

                foreach (DataRow row in currentRows)
                {
                    foreach (DataColumn column in dt.Columns)
                        Console.Write("\t{0}", row[column]);
                    Contient contient = new Contient(Int32.Parse(row[0].ToString()), Int32.Parse(row[1].ToString()), Int32.Parse(row[2].ToString()));
                    Contients.Add(contient);

                    Console.WriteLine("++++++++++++++++++++++++++");
                    Console.WriteLine("Numero Commande : " + contient.Num_Com);
                    Console.WriteLine("Code Plat : " + contient.Code_Plat);
                    Console.WriteLine("Quantité : " + contient.Qte);

                }
            }
            return Contients;
        }




    }
}
