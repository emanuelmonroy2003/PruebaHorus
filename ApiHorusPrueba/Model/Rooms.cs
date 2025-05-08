using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiHorusPrueba.Model
{
    public class Rooms
    {
        [Key]
        public int IdRooms { get; set; }
        [ForeignKey ("RoomTypeId") ]
        public int RoomTypeId { get; set; }
        public int NumRoom { get; set; }
        public int NumFloor { get; set; }
        public string RoomStatus { get; set; } = string.Empty;
        

    }
}
