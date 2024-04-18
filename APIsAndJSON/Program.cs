using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            for (int i = 0; i < 5; i++)
            {
                QuoteGen.KayneQuote();
                QuoteGen.RonQuote();
            }
        }
    }
}
