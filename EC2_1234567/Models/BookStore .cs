using System.ComponentModel.DataAnnotations;

namespace EC2_1234567.Models
{
    public class BookStore
    {
        [Key]
        public int BookISBN { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
    }
}
