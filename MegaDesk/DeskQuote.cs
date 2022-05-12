using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk2
{
    public enum rushOrder
    {
        Rush3Days,
        Rush5Days,
        Rush7Days,
        None
    }

    internal class DeskQuote
    {
        public string CustomeName { get; set; }

        public DateTime QuoteDate { get; set; }

        public string Shipping { get; set; }

        public Desk desk { get; set; }

        public decimal GetQuote()
        {
            // TODO
            return 0;
        }
    }
}
