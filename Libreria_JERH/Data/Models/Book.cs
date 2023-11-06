using System;
using System.Collections.Generic;

namespace Libreria_JERH.Data.Models
{
    public class Book
    {
        public int Id { get; set; } 
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }
        public string CoverUrl { get; set; }
        public DateTime? DateAdded { get; set; }

        //Propiedades de navegacion
        public int PublisherId { get; set; }
        public Publisher Publishe { get; set; }
        public List<Book_Author> Book_Authors { get; set;}

    }
}
