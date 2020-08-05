using System;
namespace Currency_Exchange
{
    public class Program
    {
        public static void Main(String[] args)
        {
            double exchangeRate = RatesAPI.GetRateFromAPI(args[0], args[1]);
            for (int i = 2; i < args.Length; i++)
            {
                Console.WriteLine(exchangeRate * Double.Parse(args[i]));
            }
            Console.Read();
        }
    }
}
