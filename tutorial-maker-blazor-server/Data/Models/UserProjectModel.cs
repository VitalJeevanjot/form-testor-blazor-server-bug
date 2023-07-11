using System.ComponentModel.DataAnnotations;

namespace form_testor_blazor_server.Data.Models
{
    public class UserProjectModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set;}

        [Required]
        [MaxLength(250)]
        public string CreatedByEmail { get; set; }

        [Required]
        [MaxLength(250)]
        public string GUiD { get; set; }


        [Required]
        [MaxLength(250)]
        public string URLiD { get; set; }


    }
}
