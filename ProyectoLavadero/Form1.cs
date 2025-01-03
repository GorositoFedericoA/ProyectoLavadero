using ProyectoLavadero.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLavadero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private List<Lavado> lavados = new List<Lavado>();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtBoxNombreCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el nombre del cliente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBoxNombreCliente.Focus();
            }
            else if (txtBoxTelefono.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el telefono del cliente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBoxTelefono.Focus();
            }
            else if (comboBoxTipo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el tipo de vehiculo", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxTipo.Focus();
            }
            else if (comboBoxMarca.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese la marca de vehiculo", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxMarca.Focus();
            }
            else if (txtBoxModelo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el modelo del cliente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBoxModelo.Focus();
            }
            else if (comboBoxColor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el color de vehiculo", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxColor.Focus();
            }
            else if (txtBoxPatente.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese la patente del cliente", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBoxPatente.Focus();
            }
            else if (comboBoxServicio.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el servicio de lavado", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                comboBoxServicio.Focus();
            }
            else 
            {
                Lavado vehiculoLavado = new Lavado();

                vehiculoLavado.Cliente.Nombre = txtBoxNombreCliente.Text;
                vehiculoLavado.Cliente.Telefono = Convert.ToInt32(txtBoxTelefono.Text);

                vehiculoLavado.Vehiculo.Tipo = comboBoxTipo.Text;
                vehiculoLavado.Vehiculo.Marca = comboBoxMarca.Text;
                vehiculoLavado.Vehiculo.Modelo = txtBoxModelo.Text;
                vehiculoLavado.Vehiculo.Color = comboBoxColor.Text;
                vehiculoLavado.Vehiculo.Patente = txtBoxPatente.Text;

                vehiculoLavado.Servicio.Tipo = comboBoxServicio.Text;
                vehiculoLavado.CalcularTotal();
                lavados.Add(vehiculoLavado);
                MostrarEnPantalla();
            }


        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }


        private void btnFinalizado_Click(object sender, EventArgs e)
        {

        }

        //Ver listado de los lavados finalizados.
        private void btnVerFinalizado_Click(object sender, EventArgs e)
        {
            Form2 finalizados = new Form2();

            finalizados.Show();

        }


        public void MostrarEnPantalla() 
        {
            if (lstClientes.Items != null) 
            {
                lstClientes.Items.Clear();
                foreach (Lavado item in lavados) 
                {
                    lstClientes.Items.Add(item.ToString());
                }
            }
        }



        //Carga de comboBox
        private void Form1_Load(object sender, EventArgs e)
        {
            //carga colores
            comboBoxColor.Items.Add("Blanco");
            comboBoxColor.Items.Add("Negro");
            comboBoxColor.Items.Add("Gris");
            comboBoxColor.Items.Add("Rojo");
            comboBoxColor.Items.Add("Azul");
            comboBoxColor.Items.Add("Amarillo");
            comboBoxColor.Items.Add("Naranja");
            //carga vehiculos
            comboBoxTipo.Items.Add("Auto");
            comboBoxTipo.Items.Add("Camioneta");
            comboBoxTipo.Items.Add("Moto");
            comboBoxTipo.Items.Add("Cuatriciclo");
            comboBoxTipo.Items.Add("Microbus");
            comboBoxTipo.Items.Add("Camion");
            //cargar servicio
            comboBoxServicio.Items.Add("Basico");
            comboBoxServicio.Items.Add("Premium");
            comboBoxServicio.Items.Add("Detailing");
            //cargar marcas
            comboBoxMarca.Items.Add("Toyota");
            comboBoxMarca.Items.Add("Ford");
            comboBoxMarca.Items.Add("Volkswagen");
            comboBoxMarca.Items.Add("Audi");
            comboBoxMarca.Items.Add("BMW");
            comboBoxMarca.Items.Add("Chevrolet");
            comboBoxMarca.Items.Add("Susuki");
            comboBoxMarca.Items.Add("Kia");
            comboBoxMarca.Items.Add("Hyundai");
            comboBoxMarca.Items.Add("Renault");
            comboBoxMarca.Items.Add("Peugeot");
            comboBoxMarca.Items.Add("Citroen");
            comboBoxMarca.Items.Add("Fiat");
            comboBoxMarca.Items.Add("Mercedes Benz");
            comboBoxMarca.Items.Add("Jeep");
            comboBoxMarca.Items.Add("Honda");
            comboBoxMarca.Items.Add("Nissan");
            comboBoxMarca.Items.Add("Chery");
            comboBoxMarca.Items.Add("Otros");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
