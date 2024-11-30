namespace CleanArch.Application.Dtos
{
    public class PurchaseDto
    {
        public int PurchaseId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Status { get; set; }
        public List<PurchaseItemDto> PurchaseItems { get; set; }
    }
}