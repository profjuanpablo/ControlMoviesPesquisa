
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControlMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } //? permite campo nulo

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }


    }
}
