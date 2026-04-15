using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        /*
            ТИПУ КРУТО.
            Як я зрозумів воно не буде показуватися в БД. Тобто такої колонки в таблиці не буде,
            але коли ми будемо звертатися до цієї властивості то EF автоматично подивиться на тип цієї властивості,
            і знайде відповідну таблицю. Потім він задопомогою ForeignKey в відповідній таблиці знайде відповідного User
            якого він на поверне.
         */
        public virtual User Creator { get; set; }

        [Required]
        [MaxLength(50)]
        public string StockName { get; set; }

        [Required]
        public TypeOfStocks KindOfStock { get; set; }

        [Required]
        public AccessOfStocks AccessStock { get; set; }

        public string? Password { get; set; }
    }
}
