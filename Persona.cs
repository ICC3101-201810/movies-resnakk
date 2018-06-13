using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    [Serializable]
    abstract class Persona
    {
        string Nombre;
        string Apellido;
        DateTime FechaNacimiento;
        string Biogrfia;
        public Persona(string n, string A, DateTime F, string B)
        {
            Nombre = n;
            Apellido = A;
            FechaNacimiento = F;
            Biogrfia = B;
        }
        public string GetNombre() { return this.Nombre; }
        public string GetApellido() { return this.Apellido; }
        public DateTime GetFechaNacimiento() { return this.FechaNacimiento; }
        public string GetBiografia() { return this.Biogrfia; }
    }
    [Serializable]
    class Actor : Persona
    {
        string Nombre;
        string Apellido;
        DateTime FechaNacimiento;
        string Biogrfia;
        public Actor(string n, string A, DateTime F, string B) : base(n, A, F, B)
        {
            Nombre = n;
            Apellido = A;
            FechaNacimiento = F;
            Biogrfia = B;
        }
    }
    [Serializable]
    class Director : Persona
    {
        string Nombre;
        string Apellido;
        DateTime FechaNacimiento;
        string Biogrfia;
        public Director(string n, string A, DateTime F, string B) : base(n, A, F, B)
        {
            Nombre = n;
            Apellido = A;
            FechaNacimiento = F;
            Biogrfia = B;
        }
    }
    [Serializable]
    class Productor : Persona
    {
        string Nombre;
        string Apellido;
        DateTime FechaNacimiento;
        string Biogrfia;
        public Productor(string n, string A, DateTime F, string B) : base(n, A, F, B)
        {
            Nombre = n;
            Apellido = A;
            FechaNacimiento = F;
            Biogrfia = B;
        }
    }
}
