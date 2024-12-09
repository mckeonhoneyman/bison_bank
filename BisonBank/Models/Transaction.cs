namespace BisonBank.Models
{
    public class Transaction
    {
        public int transactionID { get; set; }
        public string description { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime date { get; set; }
        public decimal amount { get; set; }
    }
}
