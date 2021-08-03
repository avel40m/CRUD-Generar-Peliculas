using System;
using System.ComponentModel.DataAnnotations;

namespace peliculas.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Complete el campo Titulo")]
        public string Titulo { get; set; }
        [Required(ErrorMessage ="Complete el campo Estreno")]
        [DataType(DataType.Date)]
        public DateTime Estreno { get; set; }
        [Required(ErrorMessage ="Complete el campo Genero")]
        public string Genero { get; set; }
        [Required(ErrorMessage ="Complete el campo Precio")]
        public decimal Precio { get; set; }
    }
}