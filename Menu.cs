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
    public partial class Menu : Form
    {
        Metodos Metodo = new Metodos();
        int ver = 0;
        public Menu()
        {
            InitializeComponent();
            
            
        }

        private void BPeliculas_Click(object sender, EventArgs e)
        {
            CC.Items.Clear();
            List<Pelicula> p = Metodos.DeserializarPeliculas();
            foreach (Pelicula item in p)
            {
                CC.Items.Add(item.GetNombre());
            }
            ver = 1;
            


        }

        private void BTodo_Click(object sender, EventArgs e)
        {
            string Search = TSearch.Text;
            string s = "";
            List<Pelicula> peliculas = Metodos.DeserializarPeliculas();
            List<DirectorPelicula> DPS = Metodos.DeserializarDPS();
            List<PeliculaActor> PAS = Metodos.DeserializarPAS();
            List<PeliculaProductor> PPS = Metodos.DeserializarPPS();
            List<EstudioPelicula> EPS = Metodos.DeserializarEPS();
            if (Search.Length <= 2)
            {
                DialogResult msm;
                msm = MessageBox.Show("Ingrese un Nombre valido");
                TSearch.Clear();
                Metodos.SerializarPeliculas(peliculas);
                Metodos.SerializarDPS(DPS);
                Metodos.SerializarPAS(PAS);
                Metodos.SerializarPPS(PPS);
                Metodos.SerializarEPS(EPS);
            }
            else
            {

                s += Metodo.BuscarPelicula(Search, s, peliculas, PAS);
                s += Metodo.BuscarActor(Search, s, PAS);
                s += Metodo.BuscarDirector(Search, s, DPS);
                s += Metodo.BuscarProductor(Search, s, PPS);
                s += Metodo.BuscarEstudio(Search, s, EPS);
                DialogResult msm;
                msm = MessageBox.Show(s, "hola");
                TSearch.Clear();
                Metodos.SerializarPeliculas(peliculas);
                Metodos.SerializarDPS(DPS);
                Metodos.SerializarPAS(PAS);
                Metodos.SerializarPPS(PPS);
                Metodos.SerializarEPS(EPS);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void BActores_Click(object sender, EventArgs e)
        {
            ver = 2;
            CC.Items.Clear();
            List<Actor> a = Metodos.DeserializarActor();
            foreach (Actor item in a)
            {
                CC.Items.Add(item.GetNombre() + " " + item.GetApellido());
            }
         

        }

        private void BDirectores_Click(object sender, EventArgs e)
        {
            ver = 3;
            CC.Items.Clear();
            List<Director> d = Metodos.DeserializarDirectores();
            foreach (Director item in d)
            {
                CC.Items.Add(item.GetNombre() + " " + item.GetApellido());
            }

        }

        private void BProductores_Click(object sender, EventArgs e)
        {
            ver = 4;
            CC.Items.Clear();
            List<Productor> p = Metodos.DeserializarProductor();
            foreach (Productor item in p)
            {
                CC.Items.Add(item.GetNombre() + " " + item.GetApellido());
            }
        }

        private void BEstudios_Click(object sender, EventArgs e)
        {
            ver = 5;
            CC.Items.Clear();
            List<Estudio> estudios = Metodos.DeserializarEstudio();
            foreach (Estudio item in estudios)
            {
                CC.Items.Add(item.GetNombre());
            }

        }

        private void BVer_Click(object sender, EventArgs e)
        {
            string s = "";
            if (ver == 0) { }
            else if (ver == 1)
            {
               
                List<Pelicula> peliculas = Metodos.DeserializarPeliculas();
                List<PeliculaActor> PAS = Metodos.DeserializarPAS();
                string combo = CC.SelectedItem.ToString();
                DialogResult msm;
                s += Metodo.BuscarPelicula(combo, s, peliculas,PAS);
                msm = MessageBox.Show(s, "Pelicula");
                Metodos.SerializarPeliculas(peliculas);
                Metodos.SerializarPAS(PAS);
                CC.Items.Clear();
            }
            else if (ver == 2)
            {
              
                List<PeliculaActor> PAS = Metodos.DeserializarPAS();
                string combo = CC.SelectedItem.ToString();
                s += Metodo.BuscarActor(combo, s, PAS);
                DialogResult msm;
                msm = MessageBox.Show(s, "Actor");
                Metodos.SerializarPAS(PAS);
                CC.Items.Clear();
            }
            else if (ver ==3)
            {
                List<DirectorPelicula> DPS = Metodos.DeserializarDPS();
                string combo = CC.SelectedItem.ToString();
                DialogResult msm;
                s += Metodo.BuscarDirector(combo, s, DPS);
                msm = MessageBox.Show(s, "Director");
                Metodos.SerializarDPS(DPS);
                CC.Items.Clear();
            }
            else if (ver == 4)
            {
                List<PeliculaProductor> PPS = Metodos.DeserializarPPS();
                string combo = CC.SelectedItem.ToString();
                DialogResult msm;
                s += Metodo.BuscarProductor(combo, s, PPS);
                msm = MessageBox.Show(s, "Productor");
                Metodos.SerializarPPS(PPS);
                CC.Items.Clear();
            }
            else if (ver == 5)
            {
                List<EstudioPelicula> EPS = Metodos.DeserializarEPS();
                string combo = CC.SelectedItem.ToString();
                DialogResult msm;
                s += Metodo.BuscarEstudio(combo, s, EPS);
                msm = MessageBox.Show(s, "Estudio");
                Metodos.SerializarEPS(EPS);
                CC.Items.Clear();
            }

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
        }

        private void BVC_Click(object sender, EventArgs e)
        {
            string d = "";
            List<Critica> C = Metodos.DeserializarCri();
            foreach (Critica item in C)
            {
                d += "Critica: " + item.GetCritica() + " Por: " + item.GetNombre();
                DialogResult m;
                m = MessageBox.Show(d,"Critica")

            }
            Metodos.SerializarCri(C);
        }
    }
}
