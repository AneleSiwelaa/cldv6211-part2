namespace KhumaloCraft_Emporium.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionID { get; set; }
        public string TransactionName { get; set; }

        public static string TransactionType { get; set; }
    }
}
