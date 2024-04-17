namespace SplitBill_Library
{
    public class Splits
    {
        public decimal SplitAmount(decimal totalBill, int numberOfPeople)
        {
            if (numberOfPeople <= 0)
                throw new ArgumentException("Number of people must be more than zero.");

            return totalBill / numberOfPeople;
        }
    }
}
