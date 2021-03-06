﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Metodos.SerializarPeliculas(Metodos.Peliculas);
            Metodos.SerializarActores(Metodos.Actores);
            Metodos.SerializarDirectores(Metodos.Directores);
            Metodos.SerializarProductores(Metodos.Productores);
            Metodos.SerializarEstudios(Metodos.Estudios);
            Metodos.SerializarPAS(Metodos.PAS);
            Metodos.SerializarPPS(Metodos.PPS);
            Metodos.SerializarDPS(Metodos.DPS);
            Metodos.SerializarEPS(Metodos.EPS);
            Metodos.SerializarCri(Metodos.Criticas);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 Bienvenido = new Form1();
            Thread.Sleep(5000);
            Bienvenido.Close();
            Application.Run(new Menu());
        }
    }
}
