using System;
using System.Collections.Generic;
using EjemploAyuda.Models;

namespace EjemploAyuda.Domain.Models
{
    public class Autor
    {
        public int Id { get; set; }
        public string Name2 { get; set; }
        public DateTime Birthday { get; set; }

        public int Age { get; set; }
        public virtual List<Tutorial> Tutoriales { get; set; }
        
    }
}