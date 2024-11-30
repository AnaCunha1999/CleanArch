using CleanArch.Application.Dtos;

namespace CleanArch.Application.Interfaces
{
    public interface IPurchaseSummaryService
    {
        Task<PurchaseSummaryDto> GetPurchaseSummary(int CustomerId);
    }
}
