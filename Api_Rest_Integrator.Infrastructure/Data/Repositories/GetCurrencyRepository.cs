using Api_Rest_Integrator.Core.Entidades;
using Api_Rest_Integrator.Core.Interface.Repository;
using Api_Rest_Integrator.Infrastructure.Data.Services;

namespace Api_Rest_Integrator.Infrastructure.Data.Repositories
{
    public class GetCurrencyRepository : IGetCurrencyRepository
    {
        public Task<CurrenciesFromApi> GetCurrencies()
        {
            GetChangeMoney getChangeMoney = new GetChangeMoney();
            return getChangeMoney.GetCurrenciesFromApi();
        }
    }
}
