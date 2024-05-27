namespace KhumaloCraft_Emporium.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public string ImageURL { get; set; }
        public bool Availability { get; set; }
    }
}
