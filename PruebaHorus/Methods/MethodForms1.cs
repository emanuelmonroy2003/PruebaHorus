using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaHorus.Methods
{
    class MethodForms1
    {
        
        public void GenerarHabitacion(Control control, Label[] LabelArray,ComboBox comboBox)
        {
            //Interativo i= Piso, j= Habitacion
            int[][] habitaciones = new int[][] { [101, 102, 103], [201, 202, 203], [301, 302, 303,304],
                                                 [401,402,403,404,405,406],[501,502]};

            foreach
                (var item in habitaciones)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    comboBox.Items.Add(item[i]);
                }
                   
            }

            int y = 0;
            int piso = 0;
            for (int i = habitaciones.Length-1; i >= 0; i--)
            {
                
                y = 0; // Itenrativo para el array labels
                for (int j = 0; j < habitaciones[i].Length; j++)
                {
                    
                    LabelArray[y] = new Label();
                    LabelArray[y].Name = $"Label{habitaciones[i][j].ToString()}";
                    LabelArray[y].Text = $"{habitaciones[i][j]}";
                    LabelArray[y].Location = new System.Drawing.Point(50 * y, 30 *piso); // Posición en el formulario
                    LabelArray[y].AutoSize = true;
                    control.Controls.Add(LabelArray[y]); // Agregar a la Ventana Form1
                    y++;
                }
                piso++;

            }
        }
        public void ModificarHabitacion()
        {
            //Modificar habitación
           
        }
    }

}
