using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ailox_wms.Models
{
    public class Supplier
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Initial { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public int Postcode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }

    }
}
