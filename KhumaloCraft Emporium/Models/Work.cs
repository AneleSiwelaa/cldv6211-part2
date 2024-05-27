using System.ComponentModel.DataAnnotations;

namespace KhumaloCraft_Emporium.Models
{
    public class Work
    {
        [Key]
        public int  WorkId { get; set; }
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
}
