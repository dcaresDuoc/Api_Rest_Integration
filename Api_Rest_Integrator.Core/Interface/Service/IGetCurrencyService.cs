using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Rest_Integrator.Core.Interface.Service
{
    public interface IGetCurrencyService
    {
        public Task<string> GetCurrenciesService();
    }
}
