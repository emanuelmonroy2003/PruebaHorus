namespace PruebaHorus.Methods
{
    class MethodForms1
    {

        public static void GenerarHabitacion(Control control, Label[] LabelArray, ComboBox comboBox)
        {
            // Interativo i = Piso, j = Habitacion

            int[][] hotelRoomsPerFloor = [
                [101, 102, 103],
                [201, 202, 203],
                [301, 302, 303,304],
                [401, 402, 403, 404, 405, 406],
                [501, 502]
            ];

            foreach (int[] roomsOnFloor in hotelRoomsPerFloor)
                foreach (int roomNumber in roomsOnFloor)
                    comboBox.Items.Add(roomNumber);

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

        // Modificar habitación
        public void ModificarHabitacion() { }
    }

}
