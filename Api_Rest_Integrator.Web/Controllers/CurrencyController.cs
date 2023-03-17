using Api_Rest_Integrator.Core.Interface.Service;
using Microsoft.AspNetCore.Mvc;

namespace Api_Rest_Integrator.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        private IGetCurrencyService _currencyService;
        public CurrencyController(IGetCurrencyService _currencyService) { 
            this._currencyService = _currencyService;
        }

        [HttpGet(Name = "currency")]
        public async Task<string> Get()
        {
            return await _currencyService.GetCurrenciesService();
        }
    }
}
