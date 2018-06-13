using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Critica
    {
        Pelicula pelicula;
        string nombre;
        public Critica(Pelicula p, string n)
        {
            pelicula = p;
            nombre = n;

        }
        public Pelicula GetPelicula() { return this.pelicula; }
        public string GetNombre() { return this.nombre; }
    }
}
