namespace BookShopApi.Models
{
    public class OrderStage
    {
        public int Id { get; set; }

        public Order Order { get; set; }

        public Stage Stage { get; set; }

        public DateTime DateStepBeg { get; set; }

        public DateTime DateStepEnd { get; set;}
    }
}
