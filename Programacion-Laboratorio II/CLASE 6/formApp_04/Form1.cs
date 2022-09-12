using System;

namespace formApp_04
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            this.radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.listBox1.Items.Clear();
        }
        private void burbuja(int[] arreglo)
        {
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.textBox1.Text);
            int maxItems = this.listBox1.Items.Count;

            this.listBox1.Items.Add(numero);
            this.listBox1.Sorted = true;
            /*
             
            if (maxItems > 2)
            {

                char numString = this.listBox1.Text.ElementAt(0);
                int num = (int)numString;

                this.listBox1.Items.Add($"el indice 0 es  = {num}");

            }


             */


            //this.listBox1.Items.Add($"Size : {this.listBox1.Items.Count}");

            // reseteamos.
            this.textBox1.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            /*
             this.isRadioButton = false;
            this.listBox1.Items.Add($"isRadioButton 2 enable ? : {this.radioButton2.Checked}");
             */
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            /*
             
            this.isRadioButton = false;

            this.listBox1.Items.Add($"isRadioButton 1 enable ? : {this.radioButton1.Checked}");
             */


        }
    }
}