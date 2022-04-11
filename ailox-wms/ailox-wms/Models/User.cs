using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ailox_wms.Models
{
    public class User
    {
        [StringLength(50, MinimumLength = 3)]
        [Key]
        public string username { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string password { get; set; }
    }
}
