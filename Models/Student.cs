using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EfcoreCodeFirstCRUD.Models
{
    public class Student
    {
        [Key]
        [Column("sid",Order = 0)]
        [Required(ErrorMessage ="Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(30,MinimumLength =2, ErrorMessage = "Length must be of  2 to 20 characters") ]
        public string Name { get; set; }
        [Range(0,100, ErrorMessage = "Range of Marsks(0-100")]
        public double  Marks{ get; set; }
    }
}
