using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class Metodos
    {
        // ======================= Listas ===================
        List<Pelicula> Peliculas = new List<Pelicula>() {
            
            };
        List<Actor> Actores = new List<Actor>() {
            new Actor("Daniel", "Radcliff",new DateTime(1983,05,13),"No hare esto"),
            new Actor("Emma", "Watson", new DateTime(1983, 06, 13), "Parte por ..."),
            new Actor("Rupert", "Grint", new DateTime(1983, 07, 13), "no"),
            new Actor("Felicity","Jones",new DateTime(1990,01,01), "noo"),
            new Actor("Diego","Luna", new DateTime(1990,01,01), "no"),
            new Actor("Forest", "Whitaker",new DateTime(1990,01,01),"nooo"),
            new Actor("Martin", "Freeman",new DateTime(1990,01,01),"nooo"),
            new Actor("Ian", "McKellen",new DateTime(1990,01,01),"nooo"),
            new Actor("Benedict", "Cumberbatch",new DateTime(1990,01,01),"nooo")
            };
               
        List<Director> Directores = new List<Director>() {
            new Director("Chris","Columbus", new DateTime(1990,01,01), "no"),
            new Director("Peter","Jackson", new DateTime(1990,01,01), "no"),
            new Director("Gareth","Edwards", new DateTime(1990,01,01), "no")
            };
        List<Productor> Productores = new List<Productor>();
        List<Estudio> Estudios = new List<Estudio>() {
            new Estudio("Warner Bros", "Studio Tour Drive, Leavesden WD25 7LR, Reino Unido", new DateTime(1923, 04, 23)),
            new Estudio("Disney", "500 S. Buena Vista Street Burbank, CA. 91506", new DateTime(1923, 01, 01)),
            new Estudio("Metro Golden Mayer", "34°03′25″N 118°25′03″O", new DateTime(1924, 04, 19))
            };
        List<PeliculaActor> PAS = new List<PeliculaActor>();
        List<PeliculaProductor> PPS = new List<PeliculaProductor>();
        List<DirectorPelicula> DPS = new List<DirectorPelicula>();
        List<EstudioPelicula> EPS = new List<EstudioPelicula>();
        // ===================================================
        
        
        // ======================= Geters
        public List<Pelicula> GetPeliculas() { return Peliculas; }
        public List<Actor> GetActors() { return Actores; }
        public List<Director> GetDirectors() { return Directores; }
        public List<Productor> GetProductors() { return Productores; }
        public List<Estudio> GetEstudios() { return Estudios; }
        public List<PeliculaActor> GetPeliculaActors() { return PAS; }
        public List<PeliculaProductor> GetPeliculaProductors() { return PPS; }

        //========================= Busquedas =====================
        public void BuscarPelicula(string Search, string s)
        {
            foreach (Pelicula Pelicula  in Peliculas)
            {
                if (Pelicula.GetNombre() == Search)
                {

                    s += "Pelicula: " + Pelicula.GetNombre();
                    s += "Director: " + Pelicula.GetDirector().GetNombre();
                    s += "Fecha Estreno: " + Pelicula.GetFecha().ToString();
                    s += "Presupuesto: " + Pelicula.GetPresupuesto().ToString();
                    s += "Estudio: " + Pelicula.GetEstudio().GetNombre();
                    s += "\n";
                    
                }
            }
            
        }
        public void BuscarDirector(string Search, string s)
        {
            foreach (DirectorPelicula i in DPS)
            {
                if (i.GetDirector().GetNombre() == Search | i.GetDirector().GetApellido() == Search)
                {
                    s += "Director: " + i.GetDirector().GetNombre() + " " + i.GetDirector().GetApellido() + "\n";
                    foreach (Pelicula j in i.GetPelicula())
                    {
                        s += j.GetNombre() + " ";
                    }
                }
            }
        }
        public void BuscarActor(string Search, string s)
        {
            foreach (PeliculaActor i in PAS)
            {
                if (i.GetActor().GetNombre() == Search | i.GetActor().GetApellido() == Search)
                {
                    s += "Actor: " + i.GetActor().GetNombre() + " " + i.GetActor().GetApellido();
                    foreach(Pelicula j in i.GetPelicula())
                    {
                        s += " Participa en: " + j.GetNombre() + " ";
                    }
                }
            } 
        }
        public void BuscarProductor(string Search, string s)
        {
            foreach (PeliculaProductor i in PPS)
            {
                if (i.GetProductor().GetNombre() == Search | i.GetProductor().GetApellido() == Search)
                {

                    s += "Productor: " + i.GetProductor().GetNombre() + " " + i.GetProductor().GetApellido();
                    foreach (Pelicula j in i.GetPelicula())
                    {
                        s += " Participa en: " + j.GetNombre() + " ";
                    }
                }
            }
        }
        public void BuscarEstudio(string Search, string s)
        {
            foreach (EstudioPelicula i in EPS)
            {
                if (i.GetEstudio().GetNombre() == Search)
                {

                    s += "Estudio: " + i.GetEstudio().GetNombre();
                    foreach (Pelicula j in i.GetPeliculas())
                    {
                        s += " Realizo: " + j.GetNombre() + " ";
                    }
                }
            }
        }
    }
}
