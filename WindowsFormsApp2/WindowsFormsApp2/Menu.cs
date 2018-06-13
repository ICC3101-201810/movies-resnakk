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
        public Menu()
        {
            InitializeComponent();
            
            
        }

        private void BPeliculas_Click(object sender, EventArgs e)
        {
            string Search = TSearch.Text;
            string s = "";
            if (Search.Length <= 2)
            {
                DialogResult msm;
                msm = MessageBox.Show("Ingrese un Nombre valido");
                TSearch.Clear()
            }
            else
            {
                Metodo.BuscarPelicula(Search, s);
                DialogResult msm;
                msm = MessageBox.Show(s);
                TSearch.Clear()
            }
        }

        private void BTodo_Click(object sender, EventArgs e)
        {
            string Search = TSearch.Text;
            string s = "";
            if (Search.Length <= 2)
            {
                DialogResult msm;
                msm = MessageBox.Show("Ingrese un Nombre valido");
                TSearch.Clear();
            }
            else
            {
                Metodo.BuscarPelicula(Search, s);
                Metodo.BuscarActor(Search, s);
                Metodo.BuscarDirector(Search, s);
                Metodo.BuscarProductor(Search, s);
                Metodo.BuscarEstudio(Search, s);
                DialogResult msm;
                msm = MessageBox.Show(s);
                TSearch.Clear();
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
            string Search = TSearch.Text;
            string s = "";
            if (Search.Length <= 2)
            {
                DialogResult msm;
                msm = MessageBox.Show("Ingrese un Nombre valido");
                TSearch.Clear();

            }
            else
            {
                Metodo.BuscarActor(Search, s);
                DialogResult msm;
                msm = MessageBox.Show(s);
                TSearch.Clear();
            }
        }

        private void BDirectores_Click(object sender, EventArgs e)
        {
            string Search = TSearch.Text;
            string s = "";
            if (Search.Length <= 2)
            {
                DialogResult msm;
                msm = MessageBox.Show("Ingrese un Nombre valido");
                TSearch.Clear();
            }
            else
            {
                Metodo.BuscarDirector(Search, s);
                DialogResult msm;
                msm = MessageBox.Show(s);
                TSearch.Clear();
            }
        }

        private void BProductores_Click(object sender, EventArgs e)
        {
            string Search = TSearch.Text;
            string s = "";
            if (Search.Length <= 2)
            {
                DialogResult msm;
                msm = MessageBox.Show("Ingrese un Nombre valido");
                TSearch.Clear();
            }
            else
            {
                Metodo.BuscarProductor(Search, s);
                DialogResult msm;
                msm = MessageBox.Show(s);
                TSearch.Clear();
            }
        }

        private void BEstudios_Click(object sender, EventArgs e)
        {
            string Search = TSearch.Text;
            string s = "";
            if (Search.Length <= 2)
            {
                DialogResult msm;
                msm = MessageBox.Show("Ingrese un Nombre valido");
                TSearch.Clear();
            }
            else
            {
                Metodo.BuscarEstudio(Search, s);
                DialogResult msm;
                msm = MessageBox.Show(s);
                TSearch.Clear();
            }
        }
    }
}
