using StockMaster.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMaster.Abstract
{
    public class BaseDataStock
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int StockId { get; set; }
        [ForeignKey("StockId")]
        public virtual Stock MainStock { get; set; }
        [Required]
        public string NameOfGood { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
