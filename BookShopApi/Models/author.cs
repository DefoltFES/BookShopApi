using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{
    [Table("author")]
    public class Author
    {
        [Column("id_author")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }


    }
}
