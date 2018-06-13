using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    class Critica
    {
        Pelicula pelicula;
        string nombre;
        string critica;
        public Critica(Pelicula p, string n, string c)
        {
            pelicula = p;
            nombre = n;
            critica = c;

        }
        public Pelicula GetPelicula() { return this.pelicula; }
        public string GetNombre() { return this.nombre; }
        public string GetCritica() { return this.critica; }
    }
}
