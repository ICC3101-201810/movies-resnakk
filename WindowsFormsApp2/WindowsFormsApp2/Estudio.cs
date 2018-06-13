using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Estudio
    {
        string Nombre;
        string Direccion;
        DateTime FechaApertura;
        public Estudio(string n, string D, DateTime F)
        {
            Nombre = n;
            Direccion = D;
            FechaApertura = F;
        }
        public string GetNombre() { return this.Nombre; }
        public string GetDireccion() { return this.Direccion; }
        public DateTime GetFechaApertura() { return this.FechaApertura; }
    }
}
