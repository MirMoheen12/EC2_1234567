using System.ComponentModel.DataAnnotations;

namespace EC2_1234567.Models
{
    public class PhoneStore
    {

        [Key]
        public int PhoneId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}
