using System.ComponentModel.DataAnnotations.Schema;

namespace BisonBank.Models
{
    public class Withdrawal : Transaction
    {
        public string originAccount { get; set; }
    }
}
