using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{
    [Table("order_stage")]
    public class OrderStage
    {
        [Key]
        [Column("id_order_stage")]
        public int Id { get; set; }

        [Column("id_order")]
        [ForeignKey(nameof(Models.Order))]
        public int IdOrder { get; set; }

        [Column("id_stage")]
        [ForeignKey(nameof(Models.Stage))]
        public int IdStage{ get; set; }

        public Order Order { get; set; }

        public Stage Stage { get; set; }


        [Column("date_step_beg")]
        public DateTime DateStepBeg { get; set; }

        [Column("date_step_end")]
        public DateTime DateStepEnd { get; set;}

        

    }
}
