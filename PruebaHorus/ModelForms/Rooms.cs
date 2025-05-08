using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaHorus.ModelForms
{
    public class Rooms
    {

        public int IdRooms { get; set; }
        public int RoomTypeId { get; set; }
        public int NumRoom { get; set; }
        public int NumFloor { get; set; }
        public string RoomStatus { get; set; } = string.Empty;
    }
}

