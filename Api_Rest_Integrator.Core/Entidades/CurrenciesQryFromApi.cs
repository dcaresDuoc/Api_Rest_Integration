using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api_Rest_Integrator.Core.Entidades
{
    public class CurrenciesQryFromApi
    {
        public string from {  get; set; }
        public string to { get; set; }
        public int amount { get; set; }
    }
}
