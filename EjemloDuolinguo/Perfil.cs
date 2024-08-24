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
    public partial class Perfil : Form
    {
        public Perfil(string Nom, string Gen, string edad)
        {
            InitializeComponent();
            Nombre.Text = Nom;
            labeledad.Text = edad;
            if (Gen == "Hombre")
                Foto.Image = Properties.Resources.PerfilHombre3;
            else
                Foto.Image = Properties.Resources.PerfilMujer3;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Foto_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
