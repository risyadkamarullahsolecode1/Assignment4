using Assignment4.Models;

namespace Assignment4.Interfaces
{
    public interface IPeminjamanService
    {
        int BorrowBook(int userId, List<int> bookId);
        void ReturnBook(int bookId, int userId, Peminjaman peminjaman);

    }
}
