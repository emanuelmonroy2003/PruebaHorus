using PruebaHorus.Methods;

namespace PruebaHorus
{
    public partial class Form1 : Form
    {
        MethodForms1 methodForm1 = new MethodForms1();
        public Form1()
        {       
            InitializeComponent();
            methodForm1.GenerarHabitacion(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
