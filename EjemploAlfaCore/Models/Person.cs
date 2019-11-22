using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EjemploAlfaCore.Models
{
    public abstract class Person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Segundo Nombre")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Primer nombre no puede ser mayor de 50 characters.")]
        [Column("FirstName")]
        [Display(Name = "Primer Nombre")]
        public string FirstMidName { get; set; }

        [Display(Name = "Nombre")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }
    }
}