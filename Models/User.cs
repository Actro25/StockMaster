using System.ComponentModel.DataAnnotations;

namespace StockMaster.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(10)]
        [Required]
        public string UserName { get; set; }
        [MaxLength(30)]
        [Required]
        public string UserPassword { get; set; }
    }
}
