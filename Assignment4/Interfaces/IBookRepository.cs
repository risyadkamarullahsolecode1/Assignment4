using Assignment4.Models;

namespace Assignment4.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);
        Task<Book> AddBook(Book book);
        Task<Book> UpdateBook(Book book);
        Task<bool> DeleteBook(int id);
    }
}
