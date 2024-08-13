using Assignment4.Interfaces;
using Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment4.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PeminjamanController : ControllerBase
    {
        private readonly IPeminjamanService _peminjamanService;
        private readonly Peminjaman _peminjamans;

        public PeminjamanController(IPeminjamanService peminjamanService, Peminjaman peminjamans)
        {
            _peminjamanService = peminjamanService;
            _peminjamans = peminjamans;
        }

        [HttpPost]
        public IActionResult BorrowBook([FromBody]Peminjaman peminjaman)
        {
            var borrowBook = _peminjamanService.BorrowBook(peminjaman.UserId, peminjaman.BukuId);
            return Ok(borrowBook);
        }
    }
}
