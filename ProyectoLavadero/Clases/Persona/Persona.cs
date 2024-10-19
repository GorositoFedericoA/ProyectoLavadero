using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLavadero.Clases
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }





        //constructores
        public Persona()
        {
        }

        public Persona(string nombre, int telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

    }
}
