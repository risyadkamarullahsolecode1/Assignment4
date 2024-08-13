using Assignment4.Interfaces;
using Assignment4.Models;
using Assignment4.Repository;

namespace Assignment4.Services
{
    public class PeminjamanService:IPeminjamanService
    {
        private readonly IPeminjamanService _peminjamanService;
        private List<Peminjaman> _peminjamans;
        private readonly IBookRepository _bookRepository;
        private readonly IUserRepository _userRepository;

        public PeminjamanService(IPeminjamanService peminjamanService, IBookRepository bookRepository, IUserRepository userRepository)
        {
            _peminjamanService = peminjamanService;
            _bookRepository = bookRepository;
            _userRepository = userRepository;
        }

        public int BorrowBook(int userId, List<int> bookId)
        {
            var userLibrary = _userRepository.GetUserById(userId);
            if (userLibrary == null)
            {
                throw new Exception("User Tidak Ada");
            }

            var bookLibrary = bookId.Select(Id => _bookRepository.GetBookById(userId)).Where(book => book != null).ToList();
            if (bookLibrary.Count != bookId.Count)
            {
                throw new Exception("buku tidak tersedia");
            }

            var borrowBook = new Peminjaman
            {
                Id = _peminjamans.Count + 1,
                UserId = userId,
                TanggalPinjam = new DateOnly(),
                TanggalKembali = new DateOnly(),
                borrowedBooks = new List<Book>()
            };
            _peminjamans.Add(borrowBook);
            return borrowBook.Id;
        }

        public void ReturnBook(int bookId, int userId, Peminjaman peminjaman)
        {

        }
    }
}
