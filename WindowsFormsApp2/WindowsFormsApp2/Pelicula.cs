using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Pelicula
    {
        string Nombre;
        Director Director;
        DateTime FechaEstreno;
        List<string> Descripcion;
        int Presupuesto;
        Estudio Estudio;
        public Pelicula(string nombre, Director dir, DateTime fecha, List<string> des, int pre, Estudio es)
        {
            Nombre = nombre;
            Director = dir;
            FechaEstreno = fecha;
            Descripcion = des;
            Presupuesto = pre;
            Estudio = es;
        }
        public string GetNombre() { return this.Nombre; }
        public Director GetDirector() { return this.Director; }
        public DateTime GetFecha() { return this.FechaEstreno; }
        public List<string> GetDescripcion() { return this.Descripcion; }
        public int GetPresupuesto() { return this.Presupuesto; }
        public Estudio GetEstudio() { return this.Estudio; }
    }
}
