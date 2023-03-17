using Api_Rest_Integrator.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Rest_Integrator.Core.Interface.Repository
{
    public interface IGetCurrencyRepository
    {
        public Task<CurrenciesFromApi> GetCurrencies();
    }
}
