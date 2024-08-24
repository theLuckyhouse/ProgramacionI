using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemloDuolinguo
{
    public partial class menuInicio : Form
    {
        public menuInicio()
        {
            InitializeComponent();
        }

        private void Salida_Click(object sender, EventArgs e)
        {

        }

        private void datosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        //Funcion de Ingresar
        private void Ingresar()
        {
            // Verifica si el campo de texto 'Nombre' está vacío o es null
            if (string.IsNullOrEmpty(Nombre.Text))
                MessageBox.Show("Por favor escriba su nombre");
            else
            {

                // Oculta el formulario actual
                this.Hide();
                
                //
                //Perfil perf = new Perfil(Nombre.Text, ObtGenero(),ObtEdad());

                // Crea una nueva instancia del formulario
                Seleccioncs Obj = new Seleccioncs();
                
                // Muestra el formulario Form1 como un diálogo modal
                Obj.ShowDialog();
                
            }
        }

        private string ObtEdad()
        {
            DateTime fechaNacimiento = dtFecha.Value;
            DateTime fechaActual = DateTime.Now;

            // Calcula la diferencia en años
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajusta si la fecha de nacimiento aún no ha ocurrido este año
            if (fechaActual < fechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            // Edad
            return ("Edad: " + edad.ToString());
        }
        private string ObtGenero()
        {
            if (Op1.Checked)
                return Op1.Text;
            else
                return Op2.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            salirToolStripMenuItem_Click(sender, e);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Nombre.Text))
            {

                // Crea una nueva instancia del formulario
                Perfil Obj = new Perfil(Nombre.Text, ObtGenero(), ObtEdad());

                // Muestra el formulario Form1 como un diálogo modal
                Obj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor escriba su nombre");
            }
        }

        private void Op1_CheckedChanged(object sender, EventArgs e)
        {

        }

       
    }
}
