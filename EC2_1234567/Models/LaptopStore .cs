using System.ComponentModel.DataAnnotations;

namespace EC2_1234567.Models
{
    public class LaptopStore
    {
        [Key]
        public int LaptopId { get; set; }
        [Required(ErrorMessage ="Brand Required")]
        public string Brand { get; set; }
        [Required(ErrorMessage = "Model Required")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Date Required")]
        public DateTime ManufactureDate { get; set; }
        [Required(ErrorMessage = "Quantity Required")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Price Required")]
        public int Price { get; set; }

        public string Image { get; set; }
    }
}
