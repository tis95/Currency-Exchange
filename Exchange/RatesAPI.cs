using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Currency_Exchange
{
    public class RatesAPI
    {
        public static double GetRateFromAPI(String oldCurrency, String newCurrency)
        {
            if (oldCurrency == "NIS") oldCurrency = "ILS";
            if (newCurrency == "NIS") newCurrency = "ILS";

            String URLString = "https://prime.exchangerate-api.com/v5/2e2f0fb45768c6e39646dfad/latest/" + oldCurrency;
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(URLString);
                var parsedObject = JObject.Parse(json);
                var currencyJson = parsedObject["conversion_rates"][newCurrency].ToString();
                return Double.Parse(currencyJson);
            }

        }
    }
}
