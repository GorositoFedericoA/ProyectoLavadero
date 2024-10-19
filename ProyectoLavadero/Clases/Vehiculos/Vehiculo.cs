using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLavadero.Clases
{
    public class Vehiculo
    {

        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public string Patente { get; set; }



        public int Precio
        {
            get
            {
                switch (Tipo.ToUpper())
                {
                    case "AUTO":
                        return 3000;
                    case "CAMIONETA":
                        return 4000;
                    case "MOTO":
                    case "CUATRICICLO":
                        return 2000;
                    case "MICROBUS":
                        return 8000;
                    case "CAMION":
                        return 15000;
                    default:
                        return 0;
                }
            }
        }



        //Constructores
        public Vehiculo() 
        {
        }

        public Vehiculo(string marca, string modelo, string patente, string color, string tipo)
        {
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Color = color;
            Patente = patente;
        }


        
    }
}
