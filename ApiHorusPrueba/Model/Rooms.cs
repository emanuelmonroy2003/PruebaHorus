﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiHorusPrueba.Model
{
    public class Rooms
    {
        [Key]
        public int IdRooms { get; set; }

        [ForeignKey("RoomType")]
        public int IdRoomType { get; set; }

        public int NumRoom { get; set; }
        public int NumFloor { get; set; }

        public virtual RoomType RoomType { get; set; }

        public string RoomStatus { get; set; } = string.Empty;





        public override string ToString()
        {
            return $"Habitacion: {NumRoom}" +
                $", Piso: {NumFloor}" +
                $", Tipo: {RoomType}" +
                $", Estado: {RoomStatus}";
        }
    }
}
