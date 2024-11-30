using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PurchaseSummaryController : ControllerBase
    {

        private readonly ILogger<PurchaseSummaryController> _logger;
        private readonly IPurchaseSummaryService _purchaseSummaryService;

        public PurchaseSummaryController(ILogger<PurchaseSummaryController> logger,
        IPurchaseSummaryService purchaseSummaryService)
        {
            _logger = logger;
            _purchaseSummaryService = purchaseSummaryService;
        }

        [HttpGet(Name = "GetPurchaseSummary")]
        public async Task<IActionResult> Get(int CustomerId)
        {
            _logger.LogInformation("Pegando informações Resumo de compras");
            var result = await _purchaseSummaryService.GetPurchaseSummary(CustomerId);
            return Ok(result);
        }
    }
}