namespace tekmi_ciftmi_projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if (sayi % 2 == 0)
            {
                MessageBox.Show("bu sayý çift bir sayýdýr.");
            }
            if (sayi % 2 == 1)
            {
                MessageBox.Show("bu sayý tek bir sayýdýr.");
            }
        }
    }
}
            
            
        
        
        


