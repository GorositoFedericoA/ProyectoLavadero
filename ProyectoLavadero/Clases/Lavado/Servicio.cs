using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLavadero.Clases
{
    public class Servicio
    {
        public string Tipo { get; set; }

        public int Precio 
        {
            get 
            {
                switch (Tipo.ToUpper())
                {
                    case "BASICO":
                        return 2000;
                    case "PREMIUM":
                        return 4000;
                    case "DETAILING":
                        return 8000;
                    default:
                        return 0;
                }
            }
        }
        public Servicio()
        {
        }

        public Servicio(string tipo)
        {
            Tipo = tipo;
        }

        
    }
}
