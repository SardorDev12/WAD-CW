using System.ComponentModel.DataAnnotations;

namespace BookStore_00012453.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
    }
}
