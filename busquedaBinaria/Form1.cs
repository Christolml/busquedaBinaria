using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace busquedaBinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Vector vector;

        private void btnTamaño_Click(object sender, EventArgs e)
        {
            vector = new Vector(Convert.ToInt16(txtTamaño.Text)); 
        }

        private void btnLimite_Click(object sender, EventArgs e)
        {
            vector.llenar(Convert.ToInt16(txtLimite.Text));
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //vector.metodoBurbuja();
            txtResultado.Text = vector.ToString();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int sacado = vector.buscar(Convert.ToInt16(txtBuscar.Text));
            if (sacado >= 0)
            {
                txtResultado.Text = "Número " + sacado + " encontrado\r\n Número de comparaciones: " +
                   vector.comparaciones;
            }
            else
                MessageBox.Show("Número no encontrado", "Error");
        }
    }
}
