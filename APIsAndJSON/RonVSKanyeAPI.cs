using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void Conversation()
        {
            for (int i = 0; i < 5; i++)
            {
                QuoteGenerator.KanyeQuote();
                QuoteGenerator.RonQuote();
            }
        }
}
}
