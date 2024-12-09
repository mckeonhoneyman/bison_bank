namespace BisonBank.Models
{
    public class Account
    {
        public int accountID { get; set; }
        public decimal balance { get; set; }
        public int accountNumber { get; set; }
        public int routingNumber { get; set; }
        public DateTime dateCreated { get; set; }
        public decimal interest { get; set; }
        public Transaction[] transactions { get; set;}
    }
}
