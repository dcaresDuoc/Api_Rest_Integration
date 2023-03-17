using Api_Rest_Integrator.Core.Entidades;
using System.Net.Http.Headers;

namespace Api_Rest_Integrator.Infrastructure.Data.Services
{
    internal class GetChangeMoney : ClientApi
    {
        public override string configBaseRoute()
        {
            return "https://api.apilayer.com/exchangerates_data";
        }

        public override HttpClient configHttpClient()
        {
            HttpClient client = new HttpClient();
            if(client.BaseAddress == null )
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //add headers
                client.DefaultRequestHeaders.Add("apikey", "AQk5Fc3WObugsnyOp4Ykfy7P6QSNcLOx");                
            }

            return client;
        }

        public async Task<CurrenciesFromApi> GetCurrenciesFromApi()
        {
            try
            {
                return await GetReturnAsync<CurrenciesFromApi>($"convert?to=CLP&from=USD&amount=1");
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
