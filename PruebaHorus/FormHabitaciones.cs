using PruebaHorus.Methods;

namespace PruebaHorus
{
    public partial class Form1 : Form
    {

        private readonly Label[] _label_array = new Label[150];
        public Form1()
        {
            InitializeComponent();
            MethodFormsHabitaciones.GenerarHabitacion(this, _label_array);
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void comboBoxHab_SelectedIndexChanged(object sender, EventArgs e) { }

        private void HabSelecionada(object sender, EventArgs e)
        {

        }

        private void TextModhab_TextChanged(object sender, EventArgs e) { }
        private void TextModPiso_TextChanged(object sender, EventArgs e) { }

        private void buttonCrearHab_Click(object sender, EventArgs e)
        {

        }

        private void cREARHABITACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCrearHabitaciones formCrearHabitaciones = new FormCrearHabitaciones();
            formCrearHabitaciones.Show();

        }
    }
}
