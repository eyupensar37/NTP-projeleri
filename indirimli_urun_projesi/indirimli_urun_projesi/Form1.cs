namespace indirimli_urun_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int etiketfiyati, indirimlifiyati;
        private void button1_Click(object sender, EventArgs e)
        {
            etiketfiyati = Convert.ToInt32(textBox1.Text);
            indirimlifiyati = etiketfiyati - etiketfiyati * 10 / 100;
            textBox2.Text = indirimlifiyati.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            etiketfiyati = Convert.ToInt32(textBox1.Text);
            indirimlifiyati = etiketfiyati - etiketfiyati * 50 / 100;
            textBox2.Text = indirimlifiyati.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            etiketfiyati = Convert.ToInt32(textBox1.Text);
            indirimlifiyati = etiketfiyati - etiketfiyati * 85 / 100;
            textBox2.Text = indirimlifiyati.ToString();
        }
    }
}
