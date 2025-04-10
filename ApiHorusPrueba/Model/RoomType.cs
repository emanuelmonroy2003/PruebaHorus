using System.ComponentModel.DataAnnotations;

namespace ApiHorusPrueba.Model
{
    public class RoomType
    {
        [Key]
        public int IdRoomType { get; set; }
        public string Type { get; set; } = string.Empty;
        public virtual ICollection<Rooms> Rooms { get; set; } = new List<Rooms>();
    }

}
