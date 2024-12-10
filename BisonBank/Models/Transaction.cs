using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BisonBank.Models
{
    public class Transaction
    {
        public int transactionID { get; set; }
        public string description { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime date { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal amount { get; set; }
    }
}
