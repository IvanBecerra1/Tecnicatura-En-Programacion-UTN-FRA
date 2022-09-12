using System.Text;

namespace WinFormsApp1_l01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSaludar_Click(object sender, EventArgs e)
        {
            if (validar(this.textNombre.Text, this.textApellido.Text) == false)
            {
                return;
            }

            Form2 fm = new Form2();

            fm.setLbTitulo_02($"Soy {this.textNombre.Text}" +
                $" {this.textApellido.Text} y mi materia favorita es " +
                $"{this.listaMaterias.SelectedItem}");

            fm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listaMaterias.Items.AddRange(new object[] {
                "Programacion II",
                "Laboratorio II",
                "Estadistica",
                "Arquitectura S.O",
                "Metodologia INV",
                "Ingles II"
            });

            this.listaMaterias.SelectedIndex = 0;
        }

        private bool validar(string nombre, string apellido)
        {

            StringBuilder notificacion = new StringBuilder();
            bool permitir = true;

            if (String.IsNullOrWhiteSpace(nombre))
            {
                notificacion.AppendLine("* Campo nombre");
                permitir = false;
            }

            if (String.IsNullOrWhiteSpace(apellido))
            {
                notificacion.AppendLine("* Campo apellido");
                permitir = false;
            }

            if (!permitir)
            {
                DialogResult rr = MessageBox.Show($"Se debe completar los siguientes campos\n{notificacion.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return permitir;
        }
    }
}