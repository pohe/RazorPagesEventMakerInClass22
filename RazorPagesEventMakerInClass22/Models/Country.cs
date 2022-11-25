using System.ComponentModel.DataAnnotations;

namespace RazorPagesEventMakerInClass22.Models
{
    public class Country
    {
        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
    }

}
