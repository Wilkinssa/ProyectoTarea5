using ProyectoTarea5.Cap10.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProyectoTarea5.Cap10
{
    public partial class Ejercicio1Cap10 : Form
    {
        public Ejercicio1Cap10()
        {
            InitializeComponent();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            InventarioTienda tienda = new InventarioTienda();
            tienda.NombreProducto = NombreTextBox.Text;
            tienda.Precio = Convert.ToSingle(PrecioTextBox.Text);
            tienda.Cantidad = Convert.ToInt32(CantidadTextBox.Text);
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            NombreTextBox.Clear();
            PrecioTextBox.Clear();
            CantidadTextBox.Clear();
        }
    }
}
