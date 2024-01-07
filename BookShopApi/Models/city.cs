using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{
    [Table("city")]
    public class City
    {
        [Column("id_city")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("day_delivery")]
        public string DayDelivery { get; set; }
    }
}
