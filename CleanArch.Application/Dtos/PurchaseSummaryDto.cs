namespace CleanArch.Application.Dtos
{
    public class PurchaseSummaryDto
    {

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public List<PurchaseDto> Purchases { get; set; }
    }
}
