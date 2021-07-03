namespace api_videojuegos.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("juegos")]
    public partial class juego
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(30)]
        public string plataforma { get; set; }

        public int anio { get; set; }

        public int precio { get; set; }

        public int stock { get; set; }

        public int? restriccion { get; set; }
    }
}
