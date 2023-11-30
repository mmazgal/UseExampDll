
using ExampDll;

namespace UseExampDll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKareHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text.ToString());
            int sayininKaresi = Calculator.kareHesapla(sayi);
            textBox1.Text = sayininKaresi.ToString();
        }

        private void buttonKupHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(textBox2.Text.ToString());
            int sayininKupu = Calculator.kupHesapla(sayi);
            textBox1.Text = sayininKupu.ToString();
        }
    }
}
