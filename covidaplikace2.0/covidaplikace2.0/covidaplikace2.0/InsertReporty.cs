using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace covidaplikace2._0
{
    class InsertReporty
    {
        //Metoda rozhodující o tom zda subjekt musí do karantény
        public object rozhodnuti(string ockovani, string chranenyKontakt, string priznaky)
        {
            if (ockovani == "ANO")
            {
                return MessageBox.Show("Subjekt nemusí do karantény");
            }
            else
            {
                if (priznaky == "ANO")
                {
                    return MessageBox.Show("Subjekt musí okamžítě nastoupit do karantény do vyhodnocení testu");
                }
                else
                {
                    if (chranenyKontakt == "NE")
                    {
                        return MessageBox.Show("Subjekt musí okamžítě nastoupit do karantény do vyhodnocení testu");
                    }
                    else
                    {
                        return MessageBox.Show("Subjekt nemusí do karantény");
                    }

                }
            }
        }
        //Metoda vkládající data do databáze TableReport s přímým odkazem na databázi v operačním systému
        public void insertReport(string jmeno, string prijmeni, string email, string telefon, string datNar, string delkaKontaktu, string priznaky, string ockovani, string chranenyKontakt, string reportovalClovek)
        {
            //odkaz na místo v systému
            string aktualniSlozka = Environment.CurrentDirectory;
            string kombinace = Path.GetFullPath(Path.Combine(aktualniSlozka, @"..\..\..\DB\LoginDB.mdf"));
            //Vyhledání databáze a vložení do ní
            SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={kombinace};Integrated Security=True;Connect Timeout=30");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[TableReport]
( 
    [Jméno],    
    [Příjmení], 
    [Email], 
    [Telefonní kontakt], 
    [Datum narození], 
    [Délka kotaktu], 
    [Příznaky], 
    [Očkování],
    [Chráněný kontakt],
    [ReportujiciO]
)
    VALUES
    ('" + jmeno + "','" + prijmeni + "','" + email + "','" + telefon + "','" + datNar + "','" + delkaKontaktu + "','" + priznaky + "','" + ockovani + "','" + chranenyKontakt + "','" + reportovalClovek + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Zadnání úspěšné");
        }

    }
}
