using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    class DirectorPelicula
    {
        Director Director;
        List<Pelicula> Pelicula;
        public DirectorPelicula(Director d, List<Pelicula> p)
        {
            Director = d;
            Pelicula = p;
        }
        public Director GetDirector() { return Director; }
        public List<Pelicula> GetPelicula() { return Pelicula; }
    }
}
