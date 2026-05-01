using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockMaster.Models
{
    public enum TypeOfStocks
    {
        FunctionalStock,
        PhysicalStock,
    };
    public enum AccessOfStocks { 
        Public,
        Private,
    };
    public class Stock
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CreatorId { get; set; }

        [ForeignKey("CreatorId")] 
        public virtual User Creator { get; set; }

        [Required]
        [MaxLength(10)]
        public string StockName { get; set; }

        [Required]
        public TypeOfStocks KindOfStock { get; set; }

        [Required]
        public AccessOfStocks AccessStock { get; set; }
        [MaxLength(30)]
        public string? Password { get; set; }
        
        public int? LinkedPhysicStockId { get; set; } = null;
        [ForeignKey("LinkedPhysicStockId")]
        public Stock LinkedStock { get; set; }

        public override string ToString()
        {
            var acsSt = (AccessStock == AccessOfStocks.Private) ? "Private" : "Public";
            return $"{StockName} - {acsSt} - {Creator.UserName}";
        }
    }
}
