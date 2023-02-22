using RegisterMyBooks_00012453.Models;

namespace RegisterMyBooks_00012453.DAL
{
    public interface IUserRep
    {
        Book GetBook(int id);
        List<Book> GetAllBooks();

        List<Book> GetCertainBooks(Category category);
        int InsertBook
            (string bookAuthor, string bookTitle,
            int price, Category category, DateTime purchaseDate, string username,
            string password);
        void UpdateBook(string bookAuthor, string bookTitle,
            int price, Category category, DateTime purchaseDate, string username,
            string password);
        void DeleteUser(Book book);
        Book Login(string username, string password);
    }
}
