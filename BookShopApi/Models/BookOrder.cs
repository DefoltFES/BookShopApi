using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{
    [Table("book_order")]
    public class BookOrder
    {
        [Key]
        [Column("id_book_order")]
        public int Id { get; set; }

        [Column("id_book")]
        [ForeignKey(nameof(Models.Book))]
        public int IdBook { get; set; }
        public Book Book { get; set; }

        [Column("id_order")]
        [ForeignKey(nameof(Models.Order))]
        public int IdOrder { get; set; }
        public Order Order { get; set; }


    }
}
