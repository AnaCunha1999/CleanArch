using CleanArch.Application.Dtos;
using CleanArch.Application.Interfaces;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Repositories;

namespace CleanArch.Application.Services
{
    public class PurchaseSummaryService : IPurchaseSummaryService
    {
        private readonly IPurchaseSummaryRepository _purchaseSummaryRepository;

        public PurchaseSummaryService(IPurchaseSummaryRepository purchaseSummaryRepository)
        {
            _purchaseSummaryRepository = purchaseSummaryRepository;
        }

        public async Task<PurchaseSummaryDto> GetPurchaseSummary(int CustomerId)
        {
            var customer = await _purchaseSummaryRepository.GetCustumer(CustomerId);
            var puchase = await _purchaseSummaryRepository.GetPurchaseByCustomerId(customer.Customer_Id);
            var item = await _purchaseSummaryRepository.GetPurchaseItem(puchase.Id);
            return new PurchaseSummaryDto();
        }

        //private PurchaseSummaryDto ToDto(Customer customer,CustomerPurchase purchase, PurchaseItem item)
        //{
        //    var itens = new PurchaseItemDto()
        //    {
        //        ItemId = item.Id,
        //        ItemName = item.ItemName,
        //        ItemDescription = item.ItemDescription,

        //    };
        //    var purchases = 
        //    return new PurchaseSummaryDto()
        //    {
        //        CustomerId = customer.Id,
        //        CustomerName = customer.Name,
        //        Purchases = ,

        //    };
        //}
    }
}
