using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace SamverkandeAPI.Models
{
    public class SamverkandeMetoder
    {
        /* ALLA GET-METODER. HÄMTAR DATA FRÅN DATABASERNA 
        * Beskrivning: Dessa metoder hämtar data från databaserna AnnonsDB och PrenumeranterDB. 
        */

        /* Metod: GetAllaAds
        * Beskrivning: Denna metod hämtar alla annonser som finns i databasen AnnonsDB
        * Returnerar: En lista med alla annonser   
        */
        public List<Ads> GetAllaAds(out string errormsg)
        {
            SqlConnection dbConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AnnonsDB;Integrated Security=True"
            };

            string sqlString = "SELECT * FROM Tbl_Ads";

            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(dbCommand);
            DataSet ds = new DataSet();

            List<Ads> annonserList = new List<Ads>(); 

            try
            {
                dbConnection.Open();
                adapter.Fill(ds, "AdsTbl");

                int count = 0;
                int i = 0;
                count = ds.Tables["AdsTbl"].Rows.Count;

                if (count > 0)
                {
                    while (i < count)
                    {
                        Ads annonser = new Ads();
                        annonser.Ad_Id = Convert.ToInt32(ds.Tables["AdsTbl"].Rows[i]["Ad_Id"]);
                        annonser.Ad_Annonsor = Convert.ToInt32(ds.Tables["AdsTbl"].Rows[i]["Ad_Annonsor"]);
                        annonser.Ad_Rubrik = ds.Tables["AdsTbl"].Rows[i]["Ad_Rubrik"].ToString();
                        annonser.Ad_Innehall = ds.Tables["AdsTbl"].Rows[i]["Ad_Innehall"].ToString();
                        annonser.Ad_VaransPris = Convert.ToInt32(ds.Tables["AdsTbl"].Rows[i]["Ad_VaransPris"]);
                        annonser.Ad_AnnonsPris = Convert.ToInt32(ds.Tables["AdsTbl"].Rows[i]["Ad_AnnonsPris"]);

                        i++;
                        annonserList.Add(annonser);

                    }
                    errormsg = "Alla annonser gick inte att hämta!";
                    return annonserList;
                }
                else
                {
                    errormsg = "Det hämtas ingen annons. Kontrollera id:et igen!";
                    return null;
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        /* Metod: GetAd
        * Beskrivning: Denna metod hämtar en annons som finns i databasen AnnonsDB
        * Returnerar: En specifik annons baserat på id 
        */
        public Ads GetAd(int id, out string errormsg)
        {
            SqlConnection dbConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AnnonsDB;Integrated Security=True"
            };

            string sqlString = "SELECT * FROM Tbl_Ads WHERE Ad_Id = @Ad_Id";

            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);

            dbCommand.Parameters.Add("Ad_Id", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(dbCommand);

            DataSet ds = new DataSet();

            try
            {
                dbConnection.Open();
                adapter.Fill(ds, "AdsTbl");

                int count = 0;
                int i = 0;
                count = ds.Tables["AdsTbl"].Rows.Count;

                if (count > 0)
                {
                    Ads annons = new Ads();
                    annons.Ad_Id = Convert.ToInt32(ds.Tables["AdsTbl"].Rows[i]["Ad_Id"]);
                    annons.Ad_Annonsor = Convert.ToInt32(ds.Tables["AdsTbl"].Rows[i]["Ad_Annonsor"]);
                    annons.Ad_Rubrik = ds.Tables["AdsTbl"].Rows[i]["Ad_Rubrik"].ToString();
                    annons.Ad_Innehall = ds.Tables["AdsTbl"].Rows[i]["Ad_Innehall"].ToString();
                    annons.Ad_VaransPris = Convert.ToInt32(ds.Tables["AdsTbl"].Rows[i]["Ad_VaransPris"]);
                    annons.Ad_AnnonsPris = Convert.ToInt32(ds.Tables["AdsTbl"].Rows[i]["Ad_AnnonsPris"]);

                    errormsg = "Annonsen med det angivna id:et hämtas inte!";
                    return annons;
                }
                else
                {
                    errormsg = "Det hämtas ingen annons. Kontrollera id:et igen!";
                    return null;
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return null;
            }
            finally
            {
                dbConnection.Close();
            }

        }

        /* Metod: GetAnnonsor
       * Beskrivning: Denna metod hämtar en annonsör som finns i databasen AnnonsDB
       * Returnerar: En specifik annonsör baserat på id 
       */
        public Annonsorer GetAnnonsor(int id, out string errormsg)
        {
            SqlConnection dbConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AnnonsDB;Integrated Security=True"
            };

            string sqlString = "SELECT * FROM Tbl_Annonsorer WHERE An_Id = @An_Id";

            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);

            dbCommand.Parameters.Add("An_Id", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(dbCommand);

            DataSet ds = new DataSet();

            try
            {
                dbConnection.Open();
                adapter.Fill(ds, "AnnonsorerTbl");

                int count = 0;
                int i = 0;
                count = ds.Tables["AnnonsorerTbl"].Rows.Count;

                if (count > 0)
                {
                    Annonsorer annonsor = new Annonsorer();

                    annonsor.An_Id = Convert.ToInt32(ds.Tables["AnnonsorerTbl"].Rows[i]["An_Id"]);
                    annonsor.An_Fornamn = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Fornamn"].ToString();
                    annonsor.An_Efternamn = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Efternamn"].ToString();
                    annonsor.An_Foretagsnamn = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Foretagsnamn"].ToString();
                    annonsor.An_Organisationsnummer = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Organisationsnummer"].ToString();
                    annonsor.An_Utdelningsadress = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Utdelningsadress"].ToString();
                    annonsor.An_UPostnummer = ds.Tables["AnnonsorerTbl"].Rows[i]["An_UPostnummer"].ToString();
                    annonsor.An_UOrt = ds.Tables["AnnonsorerTbl"].Rows[i]["An_UOrt"].ToString();
                    annonsor.An_Fakturaadress = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Fakturaadress"].ToString();
                    annonsor.An_FPostnummer = ds.Tables["AnnonsorerTbl"].Rows[i]["An_FPostnummer"].ToString();
                    annonsor.An_FOrt = ds.Tables["AnnonsorerTbl"].Rows[i]["An_FOrt"].ToString();
                    annonsor.An_Epost = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Epost"].ToString();
                    annonsor.An_Mobil = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Mobil"].ToString();
                    annonsor.An_Personnummer = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Personnummer"].ToString();
                    annonsor.An_AnnonsPris = Convert.ToInt32(ds.Tables["AnnonsorerTbl"].Rows[i]["An_AnnonsPris"]);

                    errormsg = "Annonsören med det angivna id:et hämtas inte!";
                    return annonsor;
                }
                else
                {
                    errormsg = "Det hämtas ingen annonsör. Kontrollera id:et igen!";
                    return null;
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return null;
            }
            finally
            {
                dbConnection.Close();
            }

        }

        /* Metod: GetAnnonsorId
        * Beskrivning: Denna metod hämtar en annonsör som finns i databasen AnnonsDB 
        * Returnerar: En annonsör som finns längst bak/ner i tabellen i syfte om att hitta annonsörens id
        */
        public Annonsorer GetAnnonsorId(out string errormsg)
        {
            SqlConnection dbConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AnnonsDB;Integrated Security=True"
            };

            string sqlString = "SELECT TOP 1 * FROM [Tbl_Annonsorer] ORDER BY [An_Id] DESC";

            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(dbCommand);
            DataSet ds = new DataSet();

            try
            {
                dbConnection.Open();
                adapter.Fill(ds, "AnnonsorerTbl");

                int count = 0;
                int i = 0;
                count = ds.Tables["AnnonsorerTbl"].Rows.Count;

                if (count > 0)
                {
                    Annonsorer annonsor = new Annonsorer();
                    annonsor.An_Id = Convert.ToInt32(ds.Tables["AnnonsorerTbl"].Rows[i]["An_Id"]);
                    annonsor.An_Fornamn = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Fornamn"].ToString();
                    annonsor.An_Efternamn = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Efternamn"].ToString();
                    annonsor.An_Foretagsnamn = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Foretagsnamn"].ToString();
                    annonsor.An_Organisationsnummer = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Organisationsnummer"].ToString();
                    annonsor.An_Utdelningsadress = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Utdelningsadress"].ToString();
                    annonsor.An_UPostnummer = ds.Tables["AnnonsorerTbl"].Rows[i]["An_UPostnummer"].ToString();
                    annonsor.An_UOrt = ds.Tables["AnnonsorerTbl"].Rows[i]["An_UOrt"].ToString();
                    annonsor.An_Fakturaadress = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Fakturaadress"].ToString();
                    annonsor.An_FPostnummer = ds.Tables["AnnonsorerTbl"].Rows[i]["An_FPostnummer"].ToString();
                    annonsor.An_FOrt = ds.Tables["AnnonsorerTbl"].Rows[i]["An_FOrt"].ToString();
                    annonsor.An_Epost = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Epost"].ToString();
                    annonsor.An_Mobil = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Mobil"].ToString();
                    annonsor.An_Personnummer = ds.Tables["AnnonsorerTbl"].Rows[i]["An_Personnummer"].ToString();
                    annonsor.An_AnnonsPris = Convert.ToInt32(ds.Tables["AnnonsorerTbl"].Rows[i]["An_AnnonsPris"]);

                    errormsg = "Det senaste id:et går inte att hämta!";
                    return annonsor;
                }
                else
                {
                    errormsg = "Det hämtas ingen annons. Kontrollera id:et igen!";
                    return null;
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return null;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        /* Metod: GetPrenumerant
        * Beskrivning: Denna metod hämtar en prenumerant som finns i databasen PrenumeranterDB
        * Returnerar: En prenumerant baserat på ett valt id  
        */
        public Prenumeranter GetPrenumerant(int id, out string errormsg)
        {
            SqlConnection dbConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PrenumeranterDB;Integrated Security=True"
            };

            string sqlString = "SELECT * FROM Tbl_Prenumeranter WHERE Pr_Id = @Pr_Id";

            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);

            dbCommand.Parameters.Add("Pr_Id", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(dbCommand);
            DataSet ds = new DataSet();

            try
            {
                dbConnection.Open();
                adapter.Fill(ds, "PrenumeranterTbl");

                int count = 0;
                int i = 0;
                count = ds.Tables["PrenumeranterTbl"].Rows.Count; 

                if(count > 0)
                {
                    Prenumeranter prenumerant = new Prenumeranter();
                    prenumerant.Pr_Id = Convert.ToInt32(ds.Tables["PrenumeranterTbl"].Rows[i]["Pr_Id"]);
                    prenumerant.Pr_Fornamn = ds.Tables["PrenumeranterTbl"].Rows[i]["Pr_Fornamn"].ToString();
                    prenumerant.Pr_Efternamn = ds.Tables["PrenumeranterTbl"].Rows[i]["Pr_Efternamn"].ToString();
                    prenumerant.Pr_Utdelningsadress = ds.Tables["PrenumeranterTbl"].Rows[i]["Pr_Utdelningsadress"].ToString();
                    prenumerant.Pr_Postnummer = Convert.ToInt32(ds.Tables["PrenumeranterTbl"].Rows[i]["Pr_Postnummer"]);
                    prenumerant.Pr_Ort = ds.Tables["PrenumeranterTbl"].Rows[i]["Pr_Ort"].ToString();
                    prenumerant.Pr_Epost = ds.Tables["PrenumeranterTbl"].Rows[i]["Pr_Epost"].ToString();
                    prenumerant.Pr_Mobil = ds.Tables["PrenumeranterTbl"].Rows[i]["Pr_Mobil"].ToString();
                    prenumerant.Pr_Personnummer = ds.Tables["PrenumeranterTbl"].Rows[i]["Pr_Personnummer"].ToString();

                    errormsg = "Prenumeranten med det angivna prenumerationsnumret hämtas inte!";
                    return prenumerant; 
                }
                else
                {
                    errormsg = "Det hämtas ingen prenumerant. Kontrollera prenumerationsnumret igen!";
                    return null; 
                }
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return null; 
            }
            finally
            {
                dbConnection.Close(); 
            }
        }

        /* ALLA POST-METODER. LÄGGER TILL DATA I DATABASEN
        * Beskrivning: Dessa metoder lägger till en annonsör och en annons i databasen AnnonsDB 
        */

        /* Metod: PostAd
        * Beskrivning: Denna metod lägger till en annons i databasen AnnonsDB
        * Returnerar: Den nya annonsen som har lagts till 
        */
        public int PostAd(Ads ad, out string errormsg)
        {
            SqlConnection dbConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AnnonsDB;Integrated Security=True"
            };

            string sqlString = "INSERT INTO Tbl_Ads (Ad_Rubrik, Ad_Annonsor, Ad_Innehall, Ad_VaransPris, Ad_AnnonsPris) " +
                "VALUES (@Ad_Rubrik, @Ad_Annonsor, @Ad_Innehall, @Ad_VaransPris, @Ad_AnnonsPris)";

            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);

            dbCommand.Parameters.Add("Ad_Rubrik", SqlDbType.NVarChar, 50).Value = ad.Ad_Rubrik;
            dbCommand.Parameters.Add("Ad_Annonsor", SqlDbType.Int).Value = ad.Ad_Annonsor;
            dbCommand.Parameters.Add("Ad_Innehall", SqlDbType.NVarChar, 500).Value = ad.Ad_Innehall;
            dbCommand.Parameters.Add("Ad_VaransPris", SqlDbType.Int).Value = ad.Ad_VaransPris;
            dbCommand.Parameters.Add("Ad_AnnonsPris", SqlDbType.Int).Value = ad.Ad_AnnonsPris;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery();
                if (i == 1)
                {
                    errormsg = "";
                }
                else
                {
                    errormsg = "Det skapas ingen ny annons i databasen!";
                }
                return (i);
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return 0;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        /* Metod: PostAnnonsor
        * Beskrivning: Denna metod lägger till en annonsör (prenumerant eller företag) i databasen AnnonsDB
        * Returnerar: Den nya annonsören som har lagts till 
        */
        public int PostAnnonsor(Annonsorer nyAnnonsor, out string errormsg)
        {
            SqlConnection dbConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AnnonsDB;Integrated Security=True"
            };

            string sqlString = "INSERT INTO Tbl_Annonsorer (An_Fornamn, An_Efternamn, An_Foretagsnamn, An_Organisationsnummer, An_Epost, " +
                "An_Mobil, An_Utdelningsadress, An_UPostnummer, An_UOrt, An_Fakturaadress, An_FPostnummer, An_FOrt, An_Personnummer, An_AnnonsPris) " +
                "VALUES(@An_Fornamn, @An_Efternamn, @An_Foretagsnamn, @An_Organisationsnummer, @An_Epost, @An_Mobil, @An_Utdelningsadress, " +
                "@An_UPostnummer, @An_UOrt, @An_Fakturaadress, @An_FPostnummer, @An_FOrt, @An_Personnummer, @An_AnnonsPris)";

            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);

            if(nyAnnonsor.An_Fornamn == null)
            {
                dbCommand.Parameters.AddWithValue("@An_Fornamn", DBNull.Value);
            }
            else
            {
                dbCommand.Parameters.Add("An_Fornamn", SqlDbType.NVarChar, 50).Value = nyAnnonsor.An_Fornamn;
            }
            if (nyAnnonsor.An_Efternamn == null)
            {
                dbCommand.Parameters.AddWithValue("@An_Efternamn", DBNull.Value);
            }
            else
            {
                dbCommand.Parameters.Add("An_Efternamn", SqlDbType.NVarChar, 50).Value = nyAnnonsor.An_Efternamn;
            }
            if (nyAnnonsor.An_Foretagsnamn == null)
            {
                dbCommand.Parameters.AddWithValue("@An_Foretagsnamn", DBNull.Value);
            }
            else
            {
                dbCommand.Parameters.Add("An_Foretagsnamn", SqlDbType.NVarChar, 50).Value = nyAnnonsor.An_Foretagsnamn;
            }
            if (nyAnnonsor.An_Organisationsnummer == null)
            {
                dbCommand.Parameters.AddWithValue("@An_Organisationsnummer", DBNull.Value);
            }
            else
            {
                dbCommand.Parameters.Add("An_Organisationsnummer", SqlDbType.NVarChar, 50).Value = nyAnnonsor.An_Organisationsnummer;
            }
            dbCommand.Parameters.Add("An_Epost", SqlDbType.NVarChar, 50).Value = nyAnnonsor.An_Epost;
            dbCommand.Parameters.Add("An_Mobil", SqlDbType.NVarChar, 10).Value = nyAnnonsor.An_Mobil;
            dbCommand.Parameters.Add("An_Utdelningsadress", SqlDbType.NVarChar, 50).Value = nyAnnonsor.An_Utdelningsadress;
            dbCommand.Parameters.Add("An_UPostnummer", SqlDbType.NVarChar, 5).Value = nyAnnonsor.An_UPostnummer;
            dbCommand.Parameters.Add("An_UOrt", SqlDbType.NVarChar, 50).Value = nyAnnonsor.An_UOrt;
            if (nyAnnonsor.An_Fakturaadress == null)
            {
                dbCommand.Parameters.AddWithValue("@An_Fakturaadress", DBNull.Value);
            }
            else
            {
                dbCommand.Parameters.Add("An_Fakturaadress", SqlDbType.NVarChar, 50).Value = nyAnnonsor.An_Fakturaadress;
            }
            if (nyAnnonsor.An_FPostnummer == null)
            {
                dbCommand.Parameters.AddWithValue("@An_FPostnummer", DBNull.Value);
            }
            else
            {
                dbCommand.Parameters.Add("An_FPostnummer", SqlDbType.NVarChar, 5).Value = nyAnnonsor.An_FPostnummer;
            }
            if (nyAnnonsor.An_FOrt == null)
            {
                dbCommand.Parameters.AddWithValue("@An_FOrt", DBNull.Value);
            }
            else
            {
                dbCommand.Parameters.Add("An_FOrt", SqlDbType.NVarChar, 50).Value = nyAnnonsor.An_FOrt;
            }
            if(nyAnnonsor.An_Personnummer == null)
            {
                dbCommand.Parameters.AddWithValue("@An_Personnummer", DBNull.Value);
            }
            else
            {
                dbCommand.Parameters.Add("An_Personnummer", SqlDbType.NVarChar, 10).Value = nyAnnonsor.An_Personnummer;
            }
            dbCommand.Parameters.Add("An_AnnonsPris", SqlDbType.NVarChar, 50).Value = nyAnnonsor.An_AnnonsPris;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery(); 
                if(i == 1)
                {
                    errormsg = "";
                }
                else
                {
                    errormsg = "Det skapas ingen ny annonsör i databasen"; 
                }
                return (i);
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return 0; 
            }
            finally
            {
                dbConnection.Close(); 
            }
        }

        /* ALLA PUT-METODER. UPPDATERAR DATA I DATABASEN
        * Beskrivning: En metod som uppdaterar/ändrar en annons i databasen AnnonsDB 
        */

        /* Metod: PutAd
        * Beskrivning: Denna metod uppdaterar/ändrar en annons baserat på id
        * Returnerar: Den uppdaterade annonsen 
        */
        public int PutAd(int id, Ads ad, out string errormsg)
        {
            SqlConnection dbConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AnnonsDB;Integrated Security=True"
            };

            string sqlString = "UPDATE Tbl_Ads " +
                               "SET Ad_Rubrik = @Ad_Rubrik, Ad_VaransPris = @Ad_VaransPris, Ad_Innehall = @Ad_Innehall " +
                               "WHERE Ad_Id = @Ad_Id";

            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);

            dbCommand.Parameters.Add("Ad_Id", SqlDbType.Int).Value = id;
            dbCommand.Parameters.Add("Ad_Rubrik", SqlDbType.NVarChar, 50).Value = ad.Ad_Rubrik;
            dbCommand.Parameters.Add("Ad_VaransPris", SqlDbType.Int).Value = ad.Ad_VaransPris;
            dbCommand.Parameters.Add("Ad_Innehall", SqlDbType.NVarChar, 500).Value = ad.Ad_Innehall;

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery(); 
                if(i == 1)
                {
                    errormsg = "";
                }
                else
                {
                    errormsg = "Det gick inte att uppdatera annonsen!";
                }
                return (i);
            }
            catch(Exception e)
            {
                errormsg = e.Message;
                return 0;
            }
            finally
            {
                dbConnection.Close();
            }
        }

        /* ALLA DELETE-METODER. TAR BORT DATA FRÅN DATABASEN
        * Beskrivning: En metod som tar bort en annons från databasen AnnonsDB 
        */

        /* Metod: DeleteAd
        * Beskrivning: Denna metod tar bort en specifik annons baserat på id
        * Returnerar: Ett meddelande som säger att annonsen har blivit borttagen 
        */
        public int DeleteAd(int id, out string errormsg)
        {
            SqlConnection dbConnection = new SqlConnection
            {
                ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AnnonsDB;Integrated Security=True"
            };

            string sqlString = "DELETE FROM Tbl_Ads WHERE Ad_Id = @Ad_Id";

            SqlCommand dbCommand = new SqlCommand(sqlString, dbConnection);

            dbCommand.Parameters.Add("Ad_Id", SqlDbType.Int).Value = id; 

            try
            {
                dbConnection.Open();
                int i = 0;
                i = dbCommand.ExecuteNonQuery(); 
                if(i == 1)
                {
                    errormsg = "";
                }
                else
                {
                    errormsg = "Det går inte att ta bort annonsen från databasen!";
                }
                return (i);
            }
            catch (Exception e)
            {
                errormsg = e.Message;
                return 0;
            }
            finally
            {
                dbConnection.Close(); 
            }
        }
    }
}
