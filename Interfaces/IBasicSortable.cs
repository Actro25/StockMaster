using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMaster.Interfaces
{
    internal interface IBasicSortable
    {
        public void SortDataByIdColumn(bool isFromHigher);
        public void SortDataByNameColumn(bool isFromHigher);
        public void SortDataByQuantityColumn(bool isFromHigher);
    }
}
