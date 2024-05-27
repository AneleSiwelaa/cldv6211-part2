namespace KhumaloCraft_Emporium.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
