using Api_Rest_Integrator.Core.Entidades;
using Api_Rest_Integrator.Core.Interface.Repository;
using Api_Rest_Integrator.Core.Interface.Service;

namespace Api_Rest_Integrator.Services
{
    public class GetCurrencieTypeUseCase : IGetCurrencyService
    {
        private IGetCurrencyRepository _repository; 
        public GetCurrencieTypeUseCase(IGetCurrencyRepository repository)
        {
            this._repository = repository;
        }
        public async Task<string> GetCurrenciesService()
        {
            CurrenciesFromApi result = await this._repository.GetCurrencies();

            return result.result.ToString();            
        }
    }
}
