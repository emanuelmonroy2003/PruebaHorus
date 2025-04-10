using System.ComponentModel.DataAnnotations;

namespace PruebaHorus.ModelForms
{
    public class RoomType
    {
        [Key]
        public int IdRoomType { get; set; }
        public string Type { get; set; } = string.Empty;
        public virtual ICollection<Rooms> Rooms { get; set; } = new List<Rooms>();
    }

}
