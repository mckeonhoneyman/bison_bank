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
        public string accountNumber { get; set; }
        public string routingNumber { get; set; }
        public DateTime dateCreated { get; set; }

        public string accountType { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal interest { get; set; }
        public List<Transaction> transactions { get; set;}
    }
}
