namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoPeso = txtPeso.Text;
            double Peso = Double.Parse(textoPeso); //kg
            string textoAltura = txtAltura.Text;
            double Altura = Double.Parse(textoAltura); //m

            double imc = Peso/ (Altura * Altura);

            MessageBox.Show("El imc es: " + imc);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}