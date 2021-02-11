namespace Aggregation
{
    public abstract class Deposit
    {
        public decimal Amount { get; }
        public int Period { get; }

        protected Deposit(decimal amount, int period)
        {
            this.Amount = amount;
            this.Period = period;
        }

        public abstract decimal Income();

    }
}