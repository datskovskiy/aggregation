namespace Aggregation
{
    public class LongDeposit : Deposit
    {
        public LongDeposit(decimal amount, int period) : base(amount, period)
        {
        }

        public override decimal Income()
        {
            var baseAmount = Amount;
            const decimal interest = 0.15M;

            for (int i = 6; i < Period; i++)
            {
                baseAmount += baseAmount * interest;
            }

            return baseAmount - Amount;
        }
    }
}