using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BisonBank.Models
{
    public class Transaction
    {
        public int transactionID { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime date { get; set; } = DateTime.UtcNow;

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal amount { get; set; }

        public string transactionType { get; set; }
        public string originAccount { get; set; }
        public string destinationAccount { get; set; }
        public string description { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal savingsAccountNewBalance { get; set; }
        
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal checkingAccountNewBalance { get; set; }
        public string savingsAddOrSubtract { get; set; }
        public string checkingAddOrSubtract { get; set; }
    }
}
