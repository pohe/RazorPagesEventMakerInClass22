using System.ComponentModel.DataAnnotations;

namespace RazorPagesEventMakerInClass22.Models
{
    public class Event
    {
        [Required]
        [Range(typeof(int), "1","1000", ErrorMessage = "Id er uden for intervallet")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Name ogf event is required"), MaxLength(30)]
        public string Name { get; set; }

        public string Description { get; set; }


        public string CountryCode { get; set; }


        [Required]
        [StringLength(18,ErrorMessage ="City kan ikke være længere end 18 karakter lang")]
        public string City { get; set; }

        [Required]
        [Range(typeof(DateTime), "18/11/2022", "18/11/2023", ErrorMessage = "Datoen er uden for intervallet")]
        public DateTime DateTime { get; set; }

        public override bool Equals(object? obj)
        { 
            if (obj == null)
                return false;
            else
            {
                Event other = (Event) obj;
                if (other.Id == Id)
                    return true;
                else
                    return false;
            }
        }
    }
}
