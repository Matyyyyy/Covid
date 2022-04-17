using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace covidaplikace2._0
{
    class LogInDatabaze
    {
        //proměnné pro exportování dat do dalšího formuláře
        string jmenoX;
        string prijmeniX;
        string idX;
        //check pro ověření zda se jedná o správné login a heslo
        int check = 0;
        public void Data(string email, string heslo)
        {
            //Lokace složky v pc
            string aktualniSlozka = Environment.CurrentDirectory;
            string kombinace = Path.GetFullPath(Path.Combine(aktualniSlozka, @"..\..\..\DB\LoginDB.mdf"));
            //načtení databáze
            SqlConnection sqlcon = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={kombinace};Integrated Security=True;Connect Timeout=30");
            //Matchnutí dat s databází
            string query = "Select * from dbo.TableLogin Where email = '" + email + "' and heslo ='" + heslo + "'";
            SqlDataAdapter sqla = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sqla.Fill(dtbl);
            check = dtbl.Rows.Count;
            //export dat do formu
            foreach (DataRow row in dtbl.Rows)
            {
                jmenoX = row["jmeno"].ToString();
                prijmeniX = row["prijmeni"].ToString();
                idX = row["id"].ToString();
            }
            if (dtbl.Rows.Count == 1)
            {
                //Otevření main formu pokud je spráné heslo a email
                MenuForm objmain2 = new MenuForm(email, jmenoX, prijmeniX, idX);
                objmain2.Show();
            }
            else
            {
                MessageBox.Show("Špatné jméno nebo email");
            }
        }
        //check pro ověření zda se jedná o správné login a heslo
        public int DbCheck()
        {
            return check;
        }
    }
}
