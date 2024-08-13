using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment4.Models
{
    public class Peminjaman
    {
        public const string SettingName = "PeminjamanSettings";
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }
        public int BukuId { get; set; }
        public Book Book { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateOnly TanggalPinjam { get; set; }
        public DateOnly TanggalKembali { get; set; }
        public List<Book> borrowedBooks { get; set; }
    }
}
