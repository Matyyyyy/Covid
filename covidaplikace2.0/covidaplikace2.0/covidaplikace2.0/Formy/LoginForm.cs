using System;
using System.Windows.Forms;

namespace covidaplikace2._0
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Exit
            Exit exit = new Exit();
            exit.ExitX();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            //načtení databáze a DbCheck pro hide formu
            LogInDatabaze logindatabaze = new LogInDatabaze();
            logindatabaze.Data(btnInputEmail.Text.Trim(), btnInputHeslo.Text.Trim());
            if (logindatabaze.DbCheck() == 1)
            {
                this.Hide();
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Zahvedickovani textboxu textu v hvezdicku
            btnInputHeslo.PasswordChar = '*';
        }

        private void btnRegistrace_Click(object sender, EventArgs e)
        {
            //Překliknutí na form registrace
            RegForm objregform = new RegForm();
            objregform.Show();
        }
    }
}
