namespace Api_Rest_Integrator.Core.Entidades
{
    public class CurrenciesFromApi
    {
        public bool success { get; set; }
        public CurrenciesQryFromApi query { get; set; }        
        public CurrenciesInfoFromApi info { get; set; }
        public DateTime date { get; set; }
        public double result { get; set; }
    }
}
