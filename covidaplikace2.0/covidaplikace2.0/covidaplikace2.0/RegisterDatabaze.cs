using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace covidaplikace2._0
{
    class RegisterDatabaze
    {
        public void Register(string email, string heslo, string jmeno, string prijmeni)
        {
            //hledání složky v pc
            string aktualniSlozka = Environment.CurrentDirectory;
            string kombinace = Path.GetFullPath(Path.Combine(aktualniSlozka, @"..\..\..\DB\LoginDB.mdf"));
            //načítání databáze
            SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={kombinace};Integrated Security=True;Connect Timeout=30");
            //vložení do databáze
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[TableLogin]
            ([email]
            ,[heslo]
            ,[jmeno]
            ,[prijmeni])
            VALUES
            ('" + email + "','" + heslo + "','" + jmeno + "','" + prijmeni + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registrace úspěšná");
        }
    }
}
