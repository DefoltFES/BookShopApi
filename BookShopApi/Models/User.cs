using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{

    [Table("user")]
    public class User
    {
        [Column("id_user")]
        public int Id { get; set; }

        [Column("name")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Column("surname")]
        [MaxLength(100)]
        public string Surname { get; set; }

        [Column("email")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Column("id_city")]
        [ForeignKey(nameof(Models.City))]
        public int IdCity { get; set; }
        public City City { get; set; }

        public ICollection<Order> Orders { get; set;}
    }
}
