﻿using System.ComponentModel.DataAnnotations;

namespace logic_page_net6.Modelos
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de categoria es obigatorio")]
        [StringLength(30, ErrorMessage = "{0} El nombre debe tener entre {2} y {1}", MinimumLength = 4)]
        public string Nombre { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha de creacion")]
        public DateTime ? FechaCreacion { get; set; }
    }
}
