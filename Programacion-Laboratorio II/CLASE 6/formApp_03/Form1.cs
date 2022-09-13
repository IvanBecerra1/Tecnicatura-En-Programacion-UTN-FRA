namespace formApp_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.textBox2.Enabled = this.textBox3.Enabled = false;
        }

        /**
         * Metodo de logica 
         */
        private void button1_Click(object sender, EventArgs e)
        {
            double monto = double.Parse(this.textBox1.Text);
            double descuento = 0;

            descuento = calcularDescuento(monto);
            this.textBox2.Text = $"{(monto * descuento)}";
            this.textBox3.Text = $"{monto - (monto * descuento)}";
        }
        /**
         *  Metodo de limpiar datos
         */
        private void button2_Click(object sender, EventArgs e)
        {

            foreach (Control aux in this.groupBox1.Controls)
            {
                if ( (aux is TextBox) == false)
                {
                    continue;
                }
                ((TextBox)aux).Clear();
            }
        }

        public double calcularDescuento(double monto)
        {
            return (monto >= 3000 && monto <= 5000) ? 0.10 : (monto >= 5000) ? 0.20 : 0;
        }
    }   
}