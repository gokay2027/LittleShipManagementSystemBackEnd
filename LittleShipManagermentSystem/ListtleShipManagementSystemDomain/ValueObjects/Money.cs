namespace ListtleShipManagementSystemDomain.ValueObjects
{
    public class Money : ValueObject
    {
        public Money()
        {
        }

        public Money(string moneyNationalityName, int moneyAmount)
        {
            MoneyNationalityName = moneyNationalityName;
            MoneyAmount = moneyAmount;
        }

        public string MoneyNationalityName { get; private set; }

        public int MoneyAmount { get; private set; }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return MoneyAmount;
            yield return MoneyNationalityName;
        }
    }
}