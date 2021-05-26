using System;
using System.Collections.Generic;
using System.Text;

namespace Principal
{
    class Persona
    {
        private int cedula;
        private String nombre;
        private int edad;

        public Persona()
        {
        }

        public int Cedula { get => cedula; set => cedula = value; }
        public String Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }



    }
}
