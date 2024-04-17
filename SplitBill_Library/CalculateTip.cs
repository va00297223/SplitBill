using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitBill_Library
{
    public class CalculateTip
    {
        public Dictionary<string, decimal> CalculateTipPerPerson(Dictionary<string, decimal> mealCosts, float tipPercent)
        {
            if (mealCosts == null || mealCosts.Count == 0)
                throw new ArgumentException("Costs of Meal Dictionary is empty or null.!");

            if (tipPercent < 0 || tipPercent > 100)
                throw new ArgumentException("Tip percentage should be from 0 to 100.!");

            decimal totalMealBill = mealCosts.Values.Sum();
            decimal totalTips = totalMealBill * (decimal)(tipPercent / 100);

            var tipPerHead = new Dictionary<string, decimal>();
            foreach (var entry in mealCosts)
            {
                decimal tipAmount = entry.Value / totalMealBill * totalTips;
                tipPerHead.Add(entry.Key, tipAmount);
            }

            return tipPerHead;
        }
    }
}
