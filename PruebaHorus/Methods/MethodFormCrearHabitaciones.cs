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
        public async void CrearHabitacion(TextBox txtNumRoom, TextBox txtNumFloor, ComboBox comboBoxRoomType, string txtRoomStatus)
        {
            // Aquí puedes implementar la lógica para crear una habitación
            // Por ejemplo, abrir un formulario para ingresar los detalles de la habitación
            // y luego guardar esos detalles en la base de datos.
   
            try
            {
                // 1. Crear objeto Rooms desde los controles
                Rooms nuevaHabitacion = new Rooms
                {
                    NumRoom = int.Parse(txtNumRoom.Text),
                    NumFloor = int.Parse(txtNumFloor.Text),
                    IdRoomType = (int)comboBoxRoomType.SelectedValue,
                    RoomStatus = txtRoomStatus
                };

                // 2. Enviar a la API
                HttpClient httpClient = new HttpClient();
                var url = "http://localhost:5154/api/Rooms";

                var options = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase };
                string json = JsonSerializer.Serialize(nuevaHabitacion, options);

                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Habitación creada exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al crear la habitación: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        public async void CrearTipoHabitacion(TextBox textAñadirTipo, Label labelNombreTipo,
            Button buttonGuardarTipo, Button buttonCerrarTipo, ComboBox comboBoxTipo)
        {

            RoomType roomType = new RoomType();
            roomType.Type = textAñadirTipo.Text;
            HttpClient httpClient = new HttpClient();
            var json = JsonSerializer.Serialize(roomType);
            var Url = "http://localhost:5154/api/RoomTypes";
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(Url, content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Tipo de habitación creado exitosamente.");
                comboBoxTipo.Items.Add(roomType.Type);
               
                textAñadirTipo.Clear();
            }
            else
            {
                MessageBox.Show("Error al crear el tipo de habitación.");
            }


            labelNombreTipo.Visible = false;
            textAñadirTipo.Visible = false;
            buttonGuardarTipo.Visible = false;
            buttonCerrarTipo.Visible = false;

        }

        public async void LlenarComboBox(ComboBox comboBox)
        {
            HttpClient httpClient = new HttpClient();
            var Url = "http://localhost:5154/api/RoomTypes";
            var response = await httpClient.GetAsync(Url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true // asegura que no importe mayúsculas/minúsculas
                };

                List<RoomType> roomTypes = JsonSerializer.Deserialize<List<RoomType>>(json, options);

                if (roomTypes != null)
                {
                    comboBox.Items.Clear(); // limpia antes de agregar

                    foreach (var roomType in roomTypes)
                    {
                         // aquí cargas el nombre visible
                        comboBox.DataSource = roomTypes;        // roomTypes es tu lista deserializada
                        comboBox.DisplayMember = "Type";        // Lo que se muestra al usuario
                        comboBox.ValueMember = "IdRoomType";    // Lo que realmente usas (el ID)
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron tipos de habitación.");
                }
            }
            else
            {
                MessageBox.Show("Error al conectar con la API.");
            }
        }
    }
}
