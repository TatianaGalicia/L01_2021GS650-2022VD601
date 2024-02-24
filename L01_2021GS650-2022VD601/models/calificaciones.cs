using System.ComponentModel.DataAnnotations;

namespace L01_2021GS650_2022VD601.models
{
    public class calificaciones
    {
        [Key]

        public int calificacionId { get; set; }

        public int publicacionId { get; set; }

        public int usuarioId { get; set; }

        public int calificacion { get; set; }

    }
}
