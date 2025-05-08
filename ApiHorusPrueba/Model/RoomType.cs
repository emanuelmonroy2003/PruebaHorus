using System.ComponentModel.DataAnnotations;

namespace ApiHorusPrueba.Model
{
    public class RoomType
    {
        [Key]
        public int IdRoomType { get; set; }
        public string Type { get; set; } = string.Empty;
    }


}
