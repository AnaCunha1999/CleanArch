namespace CleanArch.Domain.Entities
{
    public class CustomerPurchase
    {
        public int Id { get; set; } 
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        public int TotalPrice { get; set; } 
        public string PurchaseDate { get; set; }

        public List<PurchaseItem> PurchaseItem { get; set; }
    }
}
