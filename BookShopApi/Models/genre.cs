using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{
    [Table("genre")]
    public class Genre
    {
        [Column("id_genre")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }
    }
}
