namespace CleanArch.Domain.Entities
{
    public class PurchaseItem
    {
        public int Id { get; set; }

        public string ItemName { get;set; }

        public string ItemDescription { get;set; }

        public string ItemPrice { get;set; }

        public CustomerPurchase CustomerPurchase { get;set; }
    }
}
