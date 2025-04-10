using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using PruebaHorus.Methods;

namespace PruebaHorus
{
    public partial class FormCrearHabitaciones : Form
    {
        MethodFormCrearHabitaciones methodFormCrearHabitaciones = new MethodFormCrearHabitaciones();
        public FormCrearHabitaciones()
        {
            InitializeComponent();
            methodFormCrearHabitaciones.LlenarComboBox(comboBoxTipo);

        }

        private void labelAñadir_MouseEnter(object sender, EventArgs e)
        {
            labelAñadir.BackColor = Color.DarkGray;
        }

        private void labelAñadir_MouseLeave(object sender, EventArgs e)
        {
            labelAñadir.BackColor = Color.Transparent;
        }

        private void labelAñadir_DoubleClick(object sender, EventArgs e)
        {
            labelNombreTipo.Visible = true;
            textAñadirTipo.Visible = true;
            buttonGuardarTipo.Visible = true;
            buttonCerrarTipo.Visible = true;

        }

        private void buttonCerrarTipo_Click(object sender, EventArgs e)
        {
            labelNombreTipo.Visible = false;
            textAñadirTipo.Visible = false;
            buttonGuardarTipo.Visible = false;
            buttonCerrarTipo.Visible = false;
        }

        private void buttonGuardarTipo_Click(object sender, EventArgs e)
        {
          
            methodFormCrearHabitaciones.CrearTipoHabitacion(textAñadirTipo, labelNombreTipo,
                                                            buttonGuardarTipo, buttonCerrarTipo);
        }
    }
}
