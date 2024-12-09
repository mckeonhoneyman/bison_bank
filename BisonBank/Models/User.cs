
namespace BisonBank.Models
{
    public class User
    {
        public int userID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Account[] accounts { get; set; }
        public Statement statement { get; set; }
    }
}
