using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ailox_wms.Models
{
    public enum LoginStatus
    {
        OFFLINE,
        ONLINE
    }

    public enum UserStatus
    {
        ACTIVE,
        INACTIVE,
        OBSOLETE
    }

    public enum Role
    {
        Admin,
        SuperAdmin,
        Operator
    }

    public class User
    {
        public User()
        {
            Role = Role.SuperAdmin;
            LoginStatus = LoginStatus.OFFLINE;
            UserStatus = UserStatus.ACTIVE;
        }
        [StringLength(50, MinimumLength = 3), RegularExpression(@"^[a-z]+\.?+[a-z]*$",ErrorMessage = "")]
        [Key]
        public string username { get; set; }
        [StringLength(50, MinimumLength = 3)]
        public string fullname { get; set; }
        [Required]
        public Role Role { get; set; }
        [Required]
        public LoginStatus LoginStatus { get; set; }
        [Required]
        public UserStatus UserStatus { get; set; }
        public string? Note { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string password { get; set; }
    }
}
