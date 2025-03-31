using PruebaHorus.Methods;

namespace PruebaHorus
{
    public partial class Form1 : Form
    {
        private readonly Label[] _label_array = new Label[150];
        public Form1()
        {
            InitializeComponent();
            MethodForms1.GenerarHabitacion(this, _label_array, comboBoxHab);
        }

        private void Form1_Load(object sender, EventArgs e) { }
        private void comboBoxHab_SelectedIndexChanged(object sender, EventArgs e) { }

        private void HabSelecionada(object sender, EventArgs e)
        {
            TextModhab.Text = comboBoxHab.SelectedItem?.ToString(); // comboBoxHab.SelectedItem.ToString();
            TextModPiso.Text = comboBoxHab.SelectedItem?.ToString()?[..1]; // comboBoxHab.SelectedItem.ToString().Substring(0, 1);
        }

        private void TextModhab_TextChanged(object sender, EventArgs e) { }
        private void TextModPiso_TextChanged(object sender, EventArgs e) { }
    }
}
