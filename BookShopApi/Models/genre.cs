using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{
    [Table("genre")]
    public class Genre
    {
        [Column("id_genre")]
        public int Id { get; set; }

        [Column("name")]
        [MaxLength(40)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
