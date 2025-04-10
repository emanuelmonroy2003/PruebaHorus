using System.ComponentModel.DataAnnotations;

namespace PruebaHorus.ModelForms
{
    public class RoomType
    {
        [Key]
        public int IdRoomType { get; set; }
        public string Type { get; set; } = string.Empty;
        public virtual ICollection<Rooms> Rooms { get; set; } = new List<Rooms>();
    
    // overridar el ToString para mostrar el nombre de la habitacion

    public override string ToString()
       {

            return $"Tipo: {Type}" +
                $", Habitaciones: {Rooms.Count}";
        }

    }
}
