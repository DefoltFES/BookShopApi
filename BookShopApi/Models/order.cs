using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{
    [Table("order")]
    public class Order
    {
        [Column("id_order")]
        public int Id { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("id_user")]
        [ForeignKey(nameof(Models.User))]
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<BookOrder> BookOrders { get; set; }

        public ICollection<OrderStage> OrderStages { get; set; }

    }
}
