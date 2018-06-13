using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    class PeliculaActor
    {
        List<Pelicula> Pelicula;
        Actor Actor;
        public PeliculaActor(List<Pelicula> p, Actor a)
        {
            Pelicula = p;
            Actor = a;
        }
        public List<Pelicula> GetPelicula() { return this.Pelicula; }
        public Actor GetActor() { return this.Actor; }
    }
}
