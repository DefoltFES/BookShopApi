using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{

    [Table("user")]
    public class User
    {
        [Column("id_user")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("surname")]
        public string Surname { get; set; }

        [Column("email")]
        public string Email { get; set; }
        public City City { get; set; }

        public ICollection<Order> Orders { get; set;}
    }
}
