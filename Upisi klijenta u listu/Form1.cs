namespace Upisi_klijenta_u_listu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                textBox1.Text = "izicko lice";
                label3.Text = "Ime";
                label4.Text = "Prezime";
            }
            if (e.KeyCode == Keys.P)
            {
                textBox1.Text = "ravno lice";
                label3.Text = "Naziv firme";
                label4.Text = "Kontakt osoba";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskCompleted == true)
            {
                int sifraKlijenta = int.Parse(maskedTextBox1.Text);
                string vrstaKlijenta = textBox1.Text;
                string imeNaziv = textBox2.Text;
                string prezimeKontakt = textBox3.Text;
                string adresa = textBox4.Text;
                Klijent novi = new Klijent(sifraKlijenta, vrstaKlijenta, imeNaziv, prezimeKontakt, adresa);
                listBox1.Items.Add(novi.ToString());
            }
            else
            {
                MessageBox.Show("Niste pravilno popunili sifru");
            }
            maskedTextBox1.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}