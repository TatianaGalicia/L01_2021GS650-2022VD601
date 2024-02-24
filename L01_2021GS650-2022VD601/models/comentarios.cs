using System.ComponentModel.DataAnnotations;

namespace L01_2021GS650_2022VD601.models
{
    public class comentarios
    {
        [Key]
        public int cometarioId { get; set; }

        public int publicacionId { get; set; }

        public string comentario { get; set; }

        public int usuarioId { get; set; }

    }
}
