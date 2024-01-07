using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{
    [Table("book_order")]
    public class BookOrder
    {
        [Column("id_book_order")]
        public int Id { get; set; }

        [Column("id_book")]
        public int IdBook { get; set; }

        [Column("id_order")]
        public int IdOrder { get; set; }

        public Book Book { get; set; }

        public Order Order { get; set; }


    }
}
