using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    class Metodos
    {
        // ======================= Listas ===================
        
        public static List<Actor> Actores = new List<Actor>() {
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
        public static List<Director> Directores = new List<Director>()
            {
            new Director("Chris","Columbus", new DateTime(1990,01,01), "no"),
            new Director("Gareth","Edwards", new DateTime(1990,01,01), "no"),
            new Director("Peter","Jackson", new DateTime(1990,01,01), "no")
            };
        public static List<Productor> Productores = new List<Productor>()
            {
            new Productor("David", "Heyman", new DateTime(1990,01,01),"no"),
            new Productor("Kathleen", "Kennedy", new DateTime(1990,01,01),"no"),
            new Productor("Fran", "Walsh", new DateTime(1990,01,01),"no")
            };
        public static List<Estudio> Estudios = new List<Estudio>() {
            new Estudio("Warner Bros", "Studio Tour Drive, Leavesden WD25 7LR, Reino Unido", new DateTime(1923, 04, 23)),
            new Estudio("Disney", "500 S. Buena Vista Street Burbank, CA. 91506", new DateTime(1923, 01, 01)),
            new Estudio("Metro Golden Mayer", "34°03′25″N 118°25′03″O", new DateTime(1924, 04, 19))
            };
        public static List<Pelicula> Peliculas = new List<Pelicula>() {
            new Pelicula("Harry Potter", Directores[0], new DateTime(2001,09,15), "Mejor Pelicula del mundo",1000000, Estudios[0]),
            new Pelicula("Rogue One", Directores[1], new DateTime(2017,12,16),"Mejor de lo que esperaba", 100000, Estudios[1]),
            new Pelicula("The Hobbit", Directores[2], new DateTime(2017,12,16),"Nunca la vi", 1000000, Estudios[2])
        };
        
        public static List<PeliculaActor> PAS = new List<PeliculaActor>() {
            new PeliculaActor(new List<Pelicula>{ Peliculas[0]}, Actores[0]),
            new PeliculaActor(new List<Pelicula>{ Peliculas[0]}, Actores[1]),
            new PeliculaActor(new List<Pelicula>{ Peliculas[0]}, Actores[2]),
            new PeliculaActor(new List<Pelicula>{ Peliculas[1]}, Actores[3]),
            new PeliculaActor(new List<Pelicula>{ Peliculas[1]}, Actores[4]),
            new PeliculaActor(new List<Pelicula>{ Peliculas[1]}, Actores[5]),
            new PeliculaActor(new List<Pelicula>{ Peliculas[2]}, Actores[6]),
            new PeliculaActor(new List<Pelicula>{ Peliculas[2]}, Actores[7]),
            new PeliculaActor(new List<Pelicula>{ Peliculas[2]}, Actores[8]),
            };
        public static List<PeliculaProductor> PPS = new List<PeliculaProductor>() {
            new PeliculaProductor(new List<Pelicula>{ Peliculas[0]}, Productores[0]),
            new PeliculaProductor(new List<Pelicula>{ Peliculas[1]}, Productores[1]),
            new PeliculaProductor(new List<Pelicula>{ Peliculas[2]}, Productores[2]),
            };
        public static List<DirectorPelicula> DPS = new List<DirectorPelicula>() {
            new DirectorPelicula(Directores[0],new List<Pelicula>{ Peliculas[0]}),
            new DirectorPelicula(Directores[1],new List<Pelicula>{ Peliculas[1]}),
            new DirectorPelicula(Directores[2],new List<Pelicula>{ Peliculas[2]}),
            };
        public static List<EstudioPelicula> EPS = new List<EstudioPelicula>() {
            new EstudioPelicula(Estudios[0],new List<Pelicula>{ Peliculas[0]}),
            new EstudioPelicula(Estudios[1],new List<Pelicula>{ Peliculas[1]}),
            new EstudioPelicula(Estudios[2],new List<Pelicula>{ Peliculas[2]}),
            };
        public static List<Critica> Criticas = new List<Critica>() {};
        public static void SerializarCri(List<Critica> C)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Criticas.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, C);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static List<Critica> DeserializarCri()
        {
            List<Critica> C;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Criticas.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    C = (List<Critica>)bin.Deserialize(stream);
                }
                return C;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static void SerializarPeliculas(List<Pelicula> Peliculas)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Peliculas.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Peliculas);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void SerializarActores(List<Actor> Actores)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Actores.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Actores);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void SerializarDirectores(List<Director> Director)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Directores.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Director);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void SerializarProductores(List<Productor> Productores)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Productores.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, Productores);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void SerializarEstudios(List<Estudio> estudios)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Estudios.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, estudios);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void SerializarPAS(List<PeliculaActor> PAS)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\PAS.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, PAS);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void SerializarPPS(List<PeliculaProductor> PPS)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\PPS.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, PPS);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void SerializarDPS(List<DirectorPelicula> DPS)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\DPS.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, DPS);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void SerializarEPS(List<EstudioPelicula> EPS)
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\EPS.bin");
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, EPS);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static List<Pelicula> DeserializarPeliculas()
        {
            List<Pelicula> Peliculas;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Peliculas.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    Peliculas = (List<Pelicula>)bin.Deserialize(stream);
                }
                return Peliculas;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static List<Actor> DeserializarActor()
        {
            List<Actor> Actores;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Actores.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    Actores = (List<Actor>)bin.Deserialize(stream);
                }
                return Actores;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static List<Director> DeserializarDirectores()
        {
            List<Director> directors;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Directores.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    directors = (List<Director>)bin.Deserialize(stream);
                }
                return directors;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static List<Productor> DeserializarProductor()
        {
            List<Productor> productors;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Productores.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    productors= (List<Productor>)bin.Deserialize(stream);
                }
                return productors;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static List<Estudio> DeserializarEstudio()
        {
            List<Estudio> estudios;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Estudios.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    estudios = (List<Estudio>)bin.Deserialize(stream);
                }
                return estudios;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static List<PeliculaActor> DeserializarPAS()
        {
            List<PeliculaActor> PAS;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\PAS.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    PAS = (List<PeliculaActor>)bin.Deserialize(stream);
                }
                return PAS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static List<PeliculaProductor> DeserializarPPS()
        {
            List<PeliculaProductor> PPS;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\PPS.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    PPS = (List<PeliculaProductor>)bin.Deserialize(stream);
                }
                return PPS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static List<DirectorPelicula> DeserializarDPS()
        {
            List<DirectorPelicula> DPS;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\DPS.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    DPS = (List<DirectorPelicula>)bin.Deserialize(stream);
                }
                return DPS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public static List<EstudioPelicula> DeserializarEPS()
        {
            List<EstudioPelicula> EPS;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\EPS.bin");
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    EPS = (List<EstudioPelicula>)bin.Deserialize(stream);
                }
                return EPS;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        // ===================================================



        //========================= Busquedas =====================
        public string BuscarPelicula(string Search, string s, List<Pelicula> Peliculas, List<PeliculaActor> PAS)
        {
            bool t = false;
            foreach (Pelicula Pelicula  in Peliculas)
            {
                
                if (Pelicula.GetNombre().ToLower().Contains(Search.ToLower()))
                {
                    t = true;
                    s += "Pelicula: " + Pelicula.GetNombre();
                    s += " Director: " + Pelicula.GetDirector().GetNombre();
                    s += " Fecha Estreno: " + Pelicula.GetFecha().ToString();
                    s += " Presupuesto: " + Pelicula.GetPresupuesto().ToString();
                    s += " Estudio: " + Pelicula.GetEstudio().GetNombre();
                    s += "\n";
                    foreach (PeliculaActor item in PAS)
                    {
                        foreach (Pelicula item1 in item.GetPelicula())
                        {
                            if (item1.GetNombre() == Pelicula.GetNombre())
                            {
                                s += "Participa: " + item.GetActor().GetNombre() + " " + item.GetActor().GetApellido() + "\n"; 
                            }
                        }
                    }
                    
                }
            }
            if (t == true)
            {
                return s;
            }
            return "";
        }
        public string BuscarDirector(string Search, string s, List<DirectorPelicula> DPS)
        {
            bool t = false;
            foreach (DirectorPelicula i in DPS)
            {
                if ((i.GetDirector().GetNombre().ToLower() + " " + i.GetDirector().GetApellido().ToLower()).Contains(Search.ToLower()))
                {
                    t = true;
                    s += "Director: " + i.GetDirector().GetNombre() + " " + i.GetDirector().GetApellido();
                    foreach (Pelicula j in i.GetPelicula())
                    {
                        s += j.GetNombre() + " ";
                    }
                }
            }
            if (t == true)
            {
                return s;
            }
            return "";
        }
        public string BuscarActor(string Search, string s, List<PeliculaActor> PAS)
        {
            bool t = false;
            foreach (PeliculaActor i in PAS)
            {
                if ((i.GetActor().GetNombre().ToLower() + " " + i.GetActor().GetApellido().ToLower()).Contains(Search.ToLower()))
                {
                    t = true;
                    s += "Actor: " + i.GetActor().GetNombre() + " " + i.GetActor().GetApellido();
                    foreach(Pelicula j in i.GetPelicula())
                    {
                        s += " Participa en: " + j.GetNombre() + " ";
                    }
                }
            }
            if (t == true)
            {
                return s;
            }
            return "";
        }
        public string BuscarProductor(string Search, string s, List<PeliculaProductor> PPS)
        {
            bool t = false;
            foreach (PeliculaProductor i in PPS)
            {
                if ( (i.GetProductor().GetNombre().ToLower() + " " +  i.GetProductor().GetApellido().ToLower()).Contains(Search.ToLower()))
                {
                    t = true;
                    s += "Productor: " + i.GetProductor().GetNombre() + " " + i.GetProductor().GetApellido();
                    foreach (Pelicula j in i.GetPelicula())
                    {
                        s += " Participa en: " + j.GetNombre() + " ";
                    }
                }
            }
            if (t == true)
            {
                return s;
            }
            return "";
        }
        public string BuscarEstudio(string Search, string s, List<EstudioPelicula> EPS)
        {
            bool t = false;
            foreach (EstudioPelicula i in EPS)
            {
                if (i.GetEstudio().GetNombre().ToLower().Contains(Search.ToLower()))
                {
                    t = true;
                    s += "Estudio: " + i.GetEstudio().GetNombre();
                    foreach (Pelicula j in i.GetPeliculas())
                    {
                        s += " Realizo: " + j.GetNombre() + " ";
                    }
                }
            }

            if (t == true)
            {
                return s;
            }
            return "";
        }

    }
}
