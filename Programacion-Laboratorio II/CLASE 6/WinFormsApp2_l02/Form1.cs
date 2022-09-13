using LibreriaRegistro;

namespace WinFormsApp2_l02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listPaises.Items.AddRange(new object[] {
                "Argentina", "Uruguay", "Canada", "Brasil"
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string nombre = this.textNombre.Text;
            string direccion = this.textDireccion.Text;
            Int32 edad = (int)this.numEdad.Value;

            string pais = this.listPaises.SelectedItem.ToString();

            string cursos = getCurso();
            string genero = getGenero();


            if (verificar( nombre,direccion,edad,pais,cursos,genero) == false)
            {
                MessageBox.Show("Complete los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Ingresantes entidadIngresantes = new Ingresantes(cursos, direccion, edad, genero, nombre, pais);

            MessageBox.Show($"Datos de registro:\n{entidadIngresantes.mostrar()}", "Registro", MessageBoxButtons.OK);

            this.textDireccion.Text = this.textNombre.Text = "";
            this.numEdad.Value = 0;
            this.listPaises.SelectedIndex = 0;
        }


        private bool verificar(string nombre, string direccion, Int32 edad, string pais,
                string cursos, string genero)
        {
            if (condicionalCadena(nombre)
               || condicionalCadena(direccion) || condicionalCadena(pais) || condicionalCadena(cursos)
               || condicionalCadena(genero)
               || edad <= 0)
            {
                return false;
            }

            return true;
        }

        private string getCurso()
        {
            if (this.cbC.Checked)
            {
                return cbC.Text;
            }

            if (this.cbCSharp.Checked)
            {
                return this.cbCSharp.Text;
            }

            if (this.cbJava.Checked)
            {
                return this.cbJava.Text;
            }
            return "";
        }

        private string getGenero()
        {
            if (this.rbFemenino.Checked == true)
            {
                return this.rbFemenino.Text;
            }

            if (this.rbMasculino.Checked == true)
            {
                return this.rbMasculino.Text;
            }

            if (this.rdBinario.Checked == true)
            {
                return this.rdBinario.Text;
            }

            return null;
        }

        private bool condicionalCadena(String args)
        {
            return String.IsNullOrWhiteSpace(args);
        }
    }
}