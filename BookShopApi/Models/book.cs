using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{
    [Table("book")]
    public class Book
    {
        [Column("id_book")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("name")]
        public string Name { get; set; }

        public Author Author { get; set; }
        public Genre Genre { get; set; }

        [Column("amount")]
        public int Amount { get; set; }
        [Column("price")]
        public decimal Price { get; set; }

        public ICollection<BookOrder> BookOrders { get; set; }


    }
}
