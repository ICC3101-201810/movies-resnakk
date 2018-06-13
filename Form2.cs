using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CC.Items.Clear();
            List<Pelicula> p = Metodos.DeserializarPeliculas();
            foreach (Pelicula item in p)
            {
                CC.Items.Add(item.GetNombre());
            }
            Metodos.SerializarPeliculas(p);
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            List<Pelicula> peliculas = Metodos.DeserializarPeliculas();
            List<DirectorPelicula> DPS = Metodos.DeserializarDPS();
            List<PeliculaActor> PAS = Metodos.DeserializarPAS();
            List<PeliculaProductor> PPS = Metodos.DeserializarPPS();
            List<EstudioPelicula> EPS = Metodos.DeserializarEPS();
            Metodos.SerializarPeliculas(peliculas);
            Metodos.SerializarDPS(DPS);
            Metodos.SerializarPAS(PAS);
            Metodos.SerializarPPS(PPS);
            Metodos.SerializarEPS(EPS);
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void BEnviar_Click(object sender, EventArgs e)
        {
            string nombre = TNombre.Text;
            string comentario = TComentario.Text;
            string combo = CC.SelectedItem.ToString();
            List<Pelicula> p = Metodos.DeserializarPeliculas();
            List<Critica> C = Metodos.DeserializarCri();
            foreach (Pelicula item in p)
            {
                if (item.GetNombre() == combo)
                {
                    Critica c = new Critica(item, nombre, comentario);
                    C.Add(c);
                    MessageBox.Show("Critica Enviada con exito!");
                    this.Close();
                }
            }
            Metodos.SerializarPeliculas(p);
            Metodos.SerializarCri(C);

        }

        private void CC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
