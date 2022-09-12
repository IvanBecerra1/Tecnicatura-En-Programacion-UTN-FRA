namespace formApp_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                string num = textBox1.Text;

                for (int i = 0; i < 10; i++)
                {
                    this.listBox1.Items.Add($"{num} x {i+1} = {(i+1) * int.Parse(num)}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.textBox1.Text = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que quieres cerrar la App ?", "Cerrar Aplicacion",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}