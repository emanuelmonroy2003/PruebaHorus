using PruebaHorus.Methods;

namespace PruebaHorus
{
    public partial class Form1 : Form
    {
        MethodForms1 methodForm1 = new MethodForms1();
        Label[] LabelArray = new Label[150];
        public Form1()
        {
            InitializeComponent();
            methodForm1.GenerarHabitacion(this, LabelArray, comboBoxHab);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxHab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HabSelecionada(object sender, EventArgs e)
        {
            TextModhab.Text = comboBoxHab.SelectedItem.ToString();
            TextModPiso.Text = comboBoxHab.SelectedItem.ToString().Substring(0, 1); 
        }

        private void TextModhab_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextModPiso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
