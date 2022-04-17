using System;
using System.Windows.Forms;

namespace covidaplikace2._0
{
    public partial class MenuForm : Form
    {
        //Nahrani dat do formu 
        public MenuForm(string loginValue, string jmeno, string prijmeni, string id)
        {
            InitializeComponent();
            //Nahrani dat do formu z databaze
            txtVratit.Text = loginValue;
            txtPrijmeni.Text = jmeno;
            txtJmeno.Text = prijmeni;
            txtId.Text = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exit
            Exit exit = new Exit();
            exit.ExitX();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //zavolani formu s ProdelanyStatusForm s qr kodem
            ProdelanyStatusForm objProdelanyStatusForm = new ProdelanyStatusForm(txtPrijmeni.Text, txtJmeno.Text, txtId.Text);
            objProdelanyStatusForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Otevření formu s reporty
            ReportForm objreportform = new ReportForm(txtVratit.Text);
            objreportform.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Otevření formu s reportovanými osobami
            ReportovaneOsobyForm reportovaneosobyform = new ReportovaneOsobyForm(txtVratit.Text);
            reportovaneosobyform.Show();

        }
    }
}
