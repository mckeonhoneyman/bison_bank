using System.ComponentModel.DataAnnotations.Schema;

namespace BisonBank.Models
{
    public class Deposit : Transaction
    {
        public string depositID { get; set; }
        public string destinationAccount { get; set; }
    }
}
