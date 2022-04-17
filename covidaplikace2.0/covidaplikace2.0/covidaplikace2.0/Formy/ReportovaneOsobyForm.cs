using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace covidaplikace2._0
{
    public partial class ReportovaneOsobyForm : Form
    {
        public string loginValueX;
        public ReportovaneOsobyForm(string loginValue)
        {
            InitializeComponent();
            loginValueX = loginValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit();
            exit.ExitX();
        }

        private void ReportovaneOsobyForm_Load(object sender, EventArgs e)
        {
            // TODO: Tento řádek načte data do tabulky 'loginDBDataSet_ReportovaneOsoby.TableReport'. Můžete jej přesunout nebo jej odstranit podle potřeby.
            this.tableReportTableAdapter.Fill(this.loginDBDataSet_ReportovaneOsoby.TableReport);

            string aktualniSlozka = Environment.CurrentDirectory;
            string kombinace = Path.GetFullPath(Path.Combine(aktualniSlozka, @"..\..\..\DB\LoginDB.mdf"));
            //SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={kombinace};Integrated Security=True;Connect Timeout=30");

            using (SqlConnection con = new SqlConnection($@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={kombinace};Integrated Security=True;Connect Timeout=30"))
            {
                using (SqlCommand cmd = new SqlCommand($"SELECT * FROM TableReport WHERE ReportujiciO = '{loginValueX}';", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
