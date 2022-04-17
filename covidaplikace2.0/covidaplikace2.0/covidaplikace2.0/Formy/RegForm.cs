using System;
using System.Linq;
using System.Windows.Forms;

namespace covidaplikace2._0
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            //Zahvezdickovani hesla a pot hesla
            btnInputHeslo.PasswordChar = '*';
            btnInputHesloPot.PasswordChar = '*';
        }

        private void btnRegistrace_Click(object sender, EventArgs e)
        {
            PwdChecker pwdChecker = new PwdChecker();
            bool rozhodnuti = pwdChecker.Same(btnInputHeslo.Text, btnInputHesloPot.Text);
            //zda se hesla shoduji
            if (pwdChecker.Same(btnInputHeslo.Text, btnInputHesloPot.Text) == true)
            {
                //zda je heslo dostatecně dlouhé
                if (pwdChecker.DelkaHesla(btnInputHeslo.Text))
                {
                    //Metoda Check si doplní text pro doplnujici text k heslu
                    string txt = (string)pwdChecker.Check(btnInputHeslo.Text, btnInputHesloPot.Text);
                    this.label7.Text = txt;
                    RegisterDatabaze registracedatabaze = new RegisterDatabaze();
                    //Zkontroluje zda jsou všechny pole vyplněny
                    if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                    {
                        MessageBox.Show("Musíte vyplnit všechna pole!");
                    }
                    else
                    {
                        //Zaregistruje uživatele do databáze
                        registracedatabaze.Register(btnInputEmail.Text.Trim(), btnInputHeslo.Text.Trim(), btninputJmeno.Text.Trim(), btninputPrijmeni.Text.Trim());
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Není vyplněné textové pole hesel");
                }
            }
            else
            {
                MessageBox.Show("Hesla nejsou shodná");
            }


        }
    }
}
