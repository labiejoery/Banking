namespace Banking.Models.Domein
{
    public class BankAccount
    {

        private readonly string _accountNumber;
        private decimal _balance;


        #region Properties
        public string AccountNumber { get; }
        public decimal Balance { get; set; } = 0M;
        #endregion


        #region constructor
        public BankAccount(string accountNumber)
        {
            AccountNumber = accountNumber;
        }
        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public decimal GetBalance()
        {
            return 0M;
        }
        #endregion
    }


}
