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
    public partial class Pregunta1 : Form
    {
        // Lista para almacenar las respuestas como "Correcto" o "Incorrecto"
        private List<string> respuestas;
        public Pregunta1()
        {
            InitializeComponent();
            respuestas = new List<string>();
        }

        private void Opcion3_Click(object sender, EventArgs e)
        {
            // Respuesta incorrecta
            respuestas.Add("Incorrecta");

            // Cerrar y abrir nuevo formulario
            Pregunta2 Obj = new Pregunta2(respuestas);
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Opcion1_Click(object sender, EventArgs e)
        {
            // Respuesta incorrecta
            respuestas.Add("Correcta");

            // Cerrar y abrir nuevo formulario
            Pregunta2 Obj = new Pregunta2(respuestas);
            Obj.Show();
            this.Hide();
        }

        private void Opcion2_Click(object sender, EventArgs e)
        {
            // Respuesta incorrecta
            respuestas.Add("Incorrecta");

            // Cerrar y abrir nuevo formulario
            Pregunta2 Obj = new Pregunta2(respuestas);
            Obj.Show();
            this.Hide();
        }
    }
}
