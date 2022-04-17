using QRCoder;
using System;
using System.Windows.Forms;

namespace covidaplikace2._0
{
    public partial class ProdelanyStatusForm : Form
    {
        public ProdelanyStatusForm(string jmeno, string prijmeni, string id)
        {
            InitializeComponent();
            //Generování id pro qr kód
            qrkodtxt.Text = jmeno + "." + prijmeni + "." + id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exit
            Exit exit = new Exit();
            exit.ExitX();
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            //Navrácení do menu
            this.Close();
        }

        private void VakcinacniStatusForm_Load(object sender, EventArgs e)
        {

        }

        private void qrkodtxt_TextChanged(object sender, EventArgs e)
        {
            //Vytvoření qr kódu
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(qrkodtxt.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            qrkodpicture.Image = code.GetGraphic(5);
        }
    }
}
