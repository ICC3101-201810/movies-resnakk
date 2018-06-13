using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class EstudioPelicula
    {
        Estudio Estudio;
        List<Pelicula> Peliculas;
        public EstudioPelicula(Estudio E, List<Pelicula> P)
        {
            Estudio = E;
            Peliculas = P;
        }
        public Estudio GetEstudio() { return Estudio; }
        public List<Pelicula> GetPeliculas() { return Peliculas; }
    }
}
