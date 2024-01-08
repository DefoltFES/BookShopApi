using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{
    [Table("author")]
    public class Author
    {
        [Key]
        [Column("id_author")]
        public int Id { get; set; }

        [Column("name")]
        [MaxLength(40)]
        public string Name { get; set; }

        public ICollection<Book> Books { get; set;}


    }
}
