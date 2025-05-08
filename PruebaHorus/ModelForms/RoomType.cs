using System.ComponentModel.DataAnnotations;
using System.Text.Json;

namespace PruebaHorus.ModelForms
{
    public class RoomType
    {
        public int RoomTypeId { get; set; }
        public string Type { get; set; } = string.Empty;
        
        // < Registrar Tipo de Habitacion >
        public  async Task<string> CreateType(string type)
        {
            HttpClient HttpClient  = new HttpClient();
            RoomType roomType = new RoomType()
            {
                Type = type
            };
            var json = JsonSerializer.Serialize(roomType);
            string Url = "http://localhost:5154/api/RoomTypes";
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var reponse = await HttpClient.PostAsync(Url,content);
            if (reponse.IsSuccessStatusCode) {
                return type;
            }
            else
            {
                return "No se puedo registrar";
            }

        }

        public async Task<List<RoomType>> GetRoomTypes()
        {
            HttpClient httpClient = new HttpClient();
            string url = "http://localhost:5154/api/RoomTypes";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                List<RoomType> roomTypes =  JsonSerializer.Deserialize<List<RoomType>>(json);
                return roomTypes;
            }
            else
            {
                return  null ;
            }
        }
    }
}
