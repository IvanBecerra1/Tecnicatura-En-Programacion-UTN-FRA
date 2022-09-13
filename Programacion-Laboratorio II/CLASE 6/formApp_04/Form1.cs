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

            foreach (Control control in this.groupBox2.Controls)
            {
                if ( (control is ListBox) == false)
                {
                    continue;
                }
                ((ListBox)control).Items.Clear();
            }

            foreach (Control control in this.groupBox1.Controls)
            {
                if ( (control is TextBox) == false)
                {
                    continue;
                }
                ((TextBox)control).Clear();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(this.textBox1.Text);
            ordenamientoBurbuja();
            
            this.textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ordenamientoBurbuja();
        }

        private void ordenamientoBurbuja()
        {
            int maxItems = this.listBox1.Items.Count;

            for (int i = 0; i < maxItems; i++)
            {
                for (int j = i + 1; j < maxItems; j++)
                {
                    if (this.radioButton2.Checked == true)
                    {
                        if (int.Parse(this.listBox1.Items[i].ToString())
                                > int.Parse(this.listBox1.Items[j].ToString()))
                        {
                            int aux = int.Parse(this.listBox1.Items[i].ToString());
                            this.listBox1.Items[i] = this.listBox1.Items[j];
                            this.listBox1.Items[j] = aux;
                        }
                    }
                    else
                    {
                        if (int.Parse(this.listBox1.Items[i].ToString())
                                < int.Parse(this.listBox1.Items[j].ToString()))
                        {
                            int aux = int.Parse(this.listBox1.Items[i].ToString());
                            this.listBox1.Items[i] = this.listBox1.Items[j];
                            this.listBox1.Items[j] = aux;
                        }
                    }
                }
            }
        }

    }
}