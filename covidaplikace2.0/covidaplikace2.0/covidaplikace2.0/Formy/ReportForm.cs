using System;
using System.Linq;
using System.Windows.Forms;

namespace covidaplikace2._0
{
    public partial class ReportForm : Form
    {
        public string valueJmeno;
        public ReportForm(string valueX)
        {
            InitializeComponent();
            //Ziskani value jmena pro databazi
            valueJmeno = valueX;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exit
            Exit exit = new Exit();
            exit.ExitX();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Reseni reportu
            InsertReporty inreport = new InsertReporty();
            //Zkontrolovani jestli nejsou texty prazdne
            if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
            {
                MessageBox.Show("Musíte vyplnit všechna pole!");
            }
            else
            {
                // vlozeni a pote nasteveni textu na clear pro dalsi zadani
                inreport.InsertReport(jmenotxt.Text.Trim(), prijmenitxt.Text.Trim(), emailtxt.Text.Trim(), Convert.ToString(teltxt.Text), Convert.ToString(datnartxt.Text), Convert.ToString(delkakonttxt.Text), Convert.ToString(priznakycbx.Text), Convert.ToString(ockovanicbx.Text), Convert.ToString(chrancbx.Text), valueJmeno);
                inreport.Rozhodnuti(Convert.ToString(priznakycbx.Text), Convert.ToString(ockovanicbx.Text), Convert.ToString(chrancbx.Text));
                priznakycbx.SelectedIndex = -1;
                ockovanicbx.SelectedIndex = -1;
                chrancbx.SelectedIndex = -1;
                foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void delkakonttxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void priznakycbx_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            //zavreni
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
