using System.Linq;

namespace Aggregation
{
    public class Client
    {
        private readonly Deposit[] deposits;

        public Client()
        {
            deposits = new Deposit[10];
        }

        public bool AddDeposit(Deposit deposit)
        {
            var added = false;

            for (int i = 0; i < deposits.Length; i++)
            {
                if (deposits[i] != default) continue;

                deposits[i] = deposit;
                added = true;
                break;
            }

            return added;
        }

        public decimal TotalIncome()
        {
            return deposits.Where(dep => dep != null).Sum(dep => dep.Income());
        }

        public decimal MaxIncome()
        {
            return deposits.Where(dep => dep != null).Max(dep => dep.Income());
        }

        public decimal GetIncomeByNumber(int number)
        {
            if (number < 1 || deposits[number - 1] == default) return 0;

            return deposits[number - 1].Income();
        }
    }
}