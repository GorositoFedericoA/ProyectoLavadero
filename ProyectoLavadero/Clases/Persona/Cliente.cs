using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLavadero.Clases
{
    public class Cliente : Persona
    {
        //public int NroCliente { get; set; }



        //constructores
        public Cliente()
        {
        }


        public Cliente(string nombre, int telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

    }
}
