using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RegisterMyBooks_00012453.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Display(Name = "Author")]
        public string BookAuthor { get; set; }

        [Display(Name = "Title")]
        public string BookTitle { get; set; }

        [Display(Name = "Purchase Date")]

        public int Price { get; set; }

        public Category Category { get; set; }
        public DateTime PurchaseDate { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }

    public enum Category
    {
        Science,
        Religion,
        Poetry,
        Educational,
        Foreign
    }
}
