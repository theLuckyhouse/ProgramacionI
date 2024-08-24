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
    public partial class Pregunta2 : Form
    {
        // Lista para almacenar las respuestas
        private List<string> respuestas;
        public Pregunta2(List<string> respuestasRecibidas)
        {
            InitializeComponent();
            // Guardamos la referencia de la lista
            respuestas = respuestasRecibidas; 
        }

        private void Pregunta2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Opcion3_Click(object sender, EventArgs e)
        {
            // Respuesta incorrecta
            respuestas.Add("Correcta");

            // Cerrar y abrir nuevo formulario
            Respuestas Obj = new Respuestas(respuestas);
            Obj.Show();
            this.Hide();
        }

        private void Opcion1_Click(object sender, EventArgs e)
        {
            // Respuesta incorrecta
            respuestas.Add("Incorrecta");

            // Cerrar y abrir nuevo formulario
            Respuestas Obj = new Respuestas(respuestas);
            Obj.Show();
            this.Hide();
        }

        private void Opcion2_Click(object sender, EventArgs e)
        {
            // Respuesta incorrecta
            respuestas.Add("Incorrecta");

            // Cerrar y abrir nuevo formulario
            Respuestas Obj = new Respuestas(respuestas);
            Obj.Show();
            this.Hide();
        }
    }
}
