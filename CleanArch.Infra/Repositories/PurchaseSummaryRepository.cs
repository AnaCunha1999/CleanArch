using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;

namespace CleanArch.Infra.Repositories
{
    public class PurchaseSummaryRepository : IPurchaseSummaryRepository
    {
        private readonly IRepository<Customer> _customerRepository;
        private readonly IRepository<CustomerPurchase> _purchaseRepository;
        private readonly IRepository<PurchaseItem> _purchaseItemRepository;
        public PurchaseSummaryRepository(IRepository<Customer> customerRepository,
            IRepository<CustomerPurchase> purchaseRepository,
            IRepository<PurchaseItem> purchaseItemRepository)
        {
            _customerRepository = customerRepository;
            _purchaseRepository = purchaseRepository;
            _purchaseItemRepository = purchaseItemRepository;
        }

        public async Task<Customer> GetCustumer(int customerId)
        {
            return await _customerRepository.SelectById(customerId);
        }
        public async Task<CustomerPurchase> GetPurchaseByCustomerId(int purchaseId)
        {
            return await _purchaseRepository.SelectById(purchaseId);
        }
        public async Task<PurchaseItem> GetPurchaseItem(int itemId)
        {
            return await _purchaseItemRepository.SelectById(itemId);
        }
    }
}
