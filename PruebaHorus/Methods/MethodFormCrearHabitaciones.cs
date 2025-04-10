using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using PruebaHorus.ModelForms;


namespace PruebaHorus.Methods
{
    public class MethodFormCrearHabitaciones
    {
        public static void CrearHabitacion()
        {
            // Aquí puedes implementar la lógica para crear una habitación
            // Por ejemplo, abrir un formulario para ingresar los detalles de la habitación
            // y luego guardar esos detalles en la base de datos.



        }

        public async void CrearTipoHabitacion(TextBox textAñadirTipo,Label labelNombreTipo,
            Button buttonGuardarTipo, Button buttonCerrarTipo)
        {
            // Aquí puedes implementar la lógica para crear un tipo de habitación

            HttpClient client = new HttpClient();

            RoomType roomType = new RoomType
            {
                Type = textAñadirTipo.Text
            };


            var url = "https://localhost:7260/api/RoomTypes";
            var json = JsonSerializer.Serialize(roomType);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("https://localhost:5001/api/rooms", content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Tipo de habitación añadido correctamente.");
            }
            else
            {
                MessageBox.Show("Error al añadir el tipo de habitación.");

                labelNombreTipo.Visible = false;
                textAñadirTipo.Visible = false;
                buttonGuardarTipo.Visible = false;
                buttonCerrarTipo.Visible = false;
            }


        }

        public async void LlenarComboBox(ComboBox comboBox)
        {
          HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://localhost:5154/api/RoomTypes");
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                
             
            }
            else
            {
                MessageBox.Show("Error al cargar los tipos de habitación.");
            }
        }
    }
}
