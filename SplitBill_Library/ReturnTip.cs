using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitBill_Library
{
    public class ReturnTip
    {
        public decimal CalculateTipPerHead(decimal price, int NoOfPatrons, float tipPercent)
        {
            if (price <= 0)
                throw new ArgumentException("Price must be above than zero..!");

            if (NoOfPatrons <= 0)
                throw new ArgumentException("Number of patrons must be greater than zero..!");

            if (tipPercent < 0 || tipPercent > 100)
                throw new ArgumentException("Tip percentage should be between 0 to 100..!");

            decimal totalTips = price * (decimal)(tipPercent / 100);
            return totalTips / NoOfPatrons;
        }
    }
}
