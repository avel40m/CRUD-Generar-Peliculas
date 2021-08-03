using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace peliculas.Models
{
    public class VerPorGenero
    {
        public List<Pelicula> Pelicula { get; set; }
        public SelectList Genero { get; set; }
        public string GeneroPelicula { get; set; }
        public string BuscarPelicula { get; set; }
    }
}