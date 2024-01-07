using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{
    [Table("order_stage")]
    public class OrderStage
    {
        [Column("id_order_stage")]
        public int Id { get; set; }

        [Column("id_order")]
        public int IdOrder { get; set; }

        [Column("id_stage")]
        public int IdStage{ get; set; }

        public Order Order { get; set; }

        public Stage Stage { get; set; }

        public DateTime DateStepBeg { get; set; }

        public DateTime DateStepEnd { get; set;}

        public ICollection<OrderStage> OrderStages { get; set; }

    }
}
