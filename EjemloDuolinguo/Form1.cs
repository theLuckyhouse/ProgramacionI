using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.TimeZoneInfo;

namespace EjemloDuolinguo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Iniciiamos una variable Nª para el contador 
        int Contador = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Estructura 

            //Aumentamos el contador en 10
            Contador +=20;

            //Cargamos una Frase o Oracion 
            Salida.Text = $"QUE EMOCION\n CARGA AL \n {Contador} ";

            if (Contador == 120)
            {

                // Detenemos el temporizador
                timer1.Enabled = false;

                //Cambiamos Forma de Imagen
                this.BackgroundImageLayout = ImageLayout.Center;

                // Cambiamos la imagen de fondo del formulario
                this.BackgroundImage = Properties.Resources.CargaCompleta; 

                // Cambiamos el texto
                Salida.Text = "¡Empezamos!";

                // Iniciamos el temporizador para la transición
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Detenemos el temporizador
            timer2.Stop();

            // Pausar por 1 segundo 
            System.Threading.Thread.Sleep(1000);

            // Oculta el formulario actual
            this.Hide();

            // Crea una nueva instancia del formulario
            Pregunta1 Obj = new Pregunta1();
            Obj.ShowDialog();
            
    }
    }
}
