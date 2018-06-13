using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    class PeliculaProductor
    {
        List<Pelicula> Pelicula;
        Productor Productor;
        public PeliculaProductor(List<Pelicula> p, Productor a)
        {
            Pelicula = p;
            Productor = a;
        }
        public List<Pelicula> GetPelicula() { return this.Pelicula; }
        public Productor GetProductor() { return this.Productor; }
    }
}
