using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieStore.Models.Domain
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string? Baslık { get; set; }
        public string? CıkısYılı { get; set; }

        public string? Afis { get; set; }  // stores movie image name with extension (eg, image0001.jpg)
        [Required]
        public string? Oyuncular { get; set; }
        [Required]
        public string? Yonetmen { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        [NotMapped]
        [Required]
        public List<int>? Genres { get; set; }
        [NotMapped]
        public IEnumerable<SelectListItem>? GenreList { get; set; }
        [NotMapped]
        public string? GenreNames { get; set; }

        [NotMapped]
        public MultiSelectList? MultiGenreList { get; set; }
        public string MovieImage { get; internal set; }
        public object Title { get; internal set; }
    }
}