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
    public partial class Respuestas : Form
    {
        // Lista para almacenar las respuestas
        private List<string> respuestas;
        public Respuestas(List<string> respuestasRecibidas)
        {
            InitializeComponent();
            // Guardamos la referencia de la lista
            respuestas = respuestasRecibidas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Usar un bucle for para recorrer las respuestas
            for (int i = 0; i < respuestas.Count; i++)
            {
                listBox1.Items.Add(respuestas[i]); // Añadir cada respuesta al ListBox
            }
        }
    }
}
