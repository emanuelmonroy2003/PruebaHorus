using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaHorus.Methods
{
    class MethodForms1
    {
       
        public void GenerarHabitacion(Control control)
        {
            //llamar a la clase Form1
             Label[] LabelArray;
            LabelArray = new Label[150];
            int[][] habitaciones = new int[][] { [101, 102, 103,104], [201, 202, 203], [301, 302, 303,304],
                                                 [401,402,403,404,405,406]};
            int y = 0;




            for (int i = 0; i < habitaciones.Length; i++)
            {
                y = 0;
                for (int j = 0; j < habitaciones[i].Length; j++)
                {
                    
                    LabelArray[y] = new Label();
                    LabelArray[y].Text = $"{habitaciones[i][j]}";
                    LabelArray[y].Location = new System.Drawing.Point(50 * y, 30 *i); // Posición en el formulario
                    LabelArray[y].AutoSize = true;
                    control.Controls.Add(LabelArray[y]); // Agregar a la Ventana Form1
                    y++;
                }

            }
        }
    }
}
