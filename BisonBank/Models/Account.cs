using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BisonBank.Models
{
    public class Account
    {
        public int accountID { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal balance { get; set; }
        public int accountNumber { get; set; }
        public int routingNumber { get; set; }
        public DateTime dateCreated { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal interest { get; set; }
        public List<Transaction> transactions { get; set;}
        public string userID { get; set; }
    }
}
