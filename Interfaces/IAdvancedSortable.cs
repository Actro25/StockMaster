namespace StockMaster.Interfaces
{
    public interface IAdvancedSortable
    {
        public void SortDataByDateColumn(bool isFromHigher);
        public void SortDataByPriceColumn(bool isFromHigher);
    }
}
