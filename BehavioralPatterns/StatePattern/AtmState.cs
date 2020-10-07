namespace BehavioralPatterns.StatePattern
{
    public interface AtmState
    {
        void InsertDebitCard();
        void EjectDebitCard();
        void EnterPin();
        void WithdrawMoney();
    }
}
