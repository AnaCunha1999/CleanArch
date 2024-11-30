using CleanArch.Domain.Entities;

namespace CleanArch.Domain.Interfaces
{
    public interface IPurchaseSummaryRepository
    {
        Task<Customer> GetCustumer(int customerId);

        Task<CustomerPurchase> GetPurchaseByCustomerId(int CustomerId);

        Task<PurchaseItem> GetPurchaseItem(int PuchaseId);
    }
}
