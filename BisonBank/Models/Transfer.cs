using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BisonBank.Models
{
    public class Transfer : Transaction
    {
        public string description { get; set; }
        public string originAccount { get; set; }
        public string destinationAccount { get; set; }
    }
}
