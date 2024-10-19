using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLavadero.Clases
{
    public class Trabajador : Persona
    {
        public int NroTrabajador { get; set; }

        public int Horas { get; set; }

        public int Sueldo { get; set; }


        //constructores
        public Trabajador() { }

        public Trabajador(int nroTrabajador,int horas, int sueldo) 
        {
            NroTrabajador = nroTrabajador;
            Horas = horas;
            Sueldo = sueldo;
        }
    }
}
