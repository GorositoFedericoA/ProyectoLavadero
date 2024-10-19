using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLavadero.Clases
{
    public class Lavado
    {
        public Cliente Cliente { get; set; } = new Cliente();
        public Vehiculo Vehiculo { get; set; } = new Vehiculo();
        public Servicio Servicio { get; set; } = new Servicio();
        public decimal TotalPorLavado { get; set; }
        //public Trabajador trabajador { get; set; }
        //public int LavadoPorMes { get; set; }


        //Constructores
        public Lavado()
        {
        }


        public Lavado(Cliente cliente, Vehiculo vehiculo, Servicio servicio, int totalPorLavado)
        {
            Cliente = cliente;
            Vehiculo = vehiculo;
            Servicio = servicio;
            TotalPorLavado = totalPorLavado;
        }

        public void CalcularTotal() 
        {
            if (Vehiculo != null && Servicio != null) 
            {
                TotalPorLavado = Vehiculo.Precio + Servicio.Precio;
            }
        }


        public override string ToString()
        {
            return $"{Cliente.Nombre} {Cliente.Telefono} {Vehiculo.Tipo} {Vehiculo.Marca} {Vehiculo.Modelo} {Vehiculo.Color} {Vehiculo.Patente} {Servicio.Tipo} {TotalPorLavado}";

        }
    }
}
