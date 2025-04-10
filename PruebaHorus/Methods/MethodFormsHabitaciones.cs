using System.ComponentModel;

namespace PruebaHorus.Methods
{
    class MethodFormsHabitaciones
    {

        public static void GenerarHabitacion(Control control, Label[] LabelArray)
        {
            // Interativo i = Piso, j = Habitacion

             int[][] hotelRoomsPerFloor = {[101, 102, 103],
                  [201, 202, 203],
                  [301, 302, 303,304],
                  [401, 402, 403, 404, 405, 406],
                  [501, 502],
                  [601,602,603,604,605]}
                  
              ;
           
            if (hotelRoomsPerFloor == null) {
                MessageBox.Show("No hay habitaciones Creadas");
                return;
            }
            
           

            int piso = 0;

            for (int floorIndex = hotelRoomsPerFloor.Length - 1; floorIndex >= 0; floorIndex--)
            {
                int y = 0; // Itenrativo para el array labels

                foreach (int roomNumber in hotelRoomsPerFloor[floorIndex])
                {
                    LabelArray[y] = new()
                    {
                        Name = $"Label{roomNumber}",
                        Text = $"{roomNumber}",
                        Location = new Point(50 * y, 30 * piso), // Posición en el formulario
                        AutoSize = true
                    };

                    control.Controls.Add(LabelArray[y]); // Agregar a la Ventana Form1
                    y++;
                }

                piso++;
            }
        }


     

    }

}
