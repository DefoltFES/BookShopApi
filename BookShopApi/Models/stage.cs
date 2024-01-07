using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopApi.Models
{
    [Table("stage")]
    public class Stage
    {
        [Column("id_stage")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }

        public ICollection<OrderStage> OrderStages { get; set; }
    }
}
