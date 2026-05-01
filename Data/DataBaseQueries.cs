using FuzzySharp;
using Microsoft.EntityFrameworkCore;
using StockMaster.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockMaster.Data
{
    public class DataBaseQueries
    {
        private readonly NyDatabaseContext _context;
        public DataBaseQueries(NyDatabaseContext context) {
            _context = context;
        }
        public bool IsNameTaken(string name) => _context.Users.Any(t => t.UserName == name);
        public void AddUser(User user) {
            var local = _context.Users.Local.FirstOrDefault(entry => entry.Id == user.Id);
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public User? IsUserExist(User user) => _context.Users.AsNoTracking().FirstOrDefault(u => u.UserName == user.UserName && u.UserPassword == user.UserPassword);
        public void DeleteUser(User user) {
            var local = _context.Users.Local.FirstOrDefault(entry => entry.Id == user.Id);
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
        public Stock AddStock(Stock stock) {
            var local = _context.Stocks.Local.FirstOrDefault(entry => entry.Id == stock.Id);
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
            _context.Stocks.Add(stock);
            _context.SaveChanges();
            return stock;
        }
        public void UpdateStock(Stock stock) {
            var local = _context.Stocks.Local.FirstOrDefault(entry => entry.Id == stock.Id);
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
            _context.Stocks.Update(stock);
            _context.SaveChanges();
        }
        public async Task<List<Stock>> GetAllStocks() => await _context.Stocks.AsNoTracking().Include(s => s.Creator).ToListAsync();
        public async Task<List<Stock>> GetAllPhysicStocks() => await _context.Stocks.AsNoTracking().Where(s => s.KindOfStock == TypeOfStocks.PhysicalStock).Include(s => s.Creator).ToListAsync();
        public void DeleteStockById(int id)
        {
            var stock = _context.Stocks.Find(id);
            if (stock == null) 
                return;

            var linkedStocks = _context.Stocks.Where(s => s.LinkedPhysicStockId == id).ToList();

            foreach (var linked in linkedStocks)
                linked.LinkedPhysicStockId = null;

            _context.Stocks.Remove(stock);
            _context.SaveChanges();
        }
        public void AddFunctionStockData(FunctionStockData data) {
            _context.FunctionStockData.Add(data);
            _context.SaveChanges();
        }
        public async Task<List<FunctionStockData>> GetAllFunctionDataStocksById(int id) => await _context.FunctionStockData.Where(f => f.StockId == id).ToListAsync();
        public FunctionStockData GetFunctionDataStockById(int id, int stockId) => _context.FunctionStockData.FirstOrDefault(f => f.Id == id && f.StockId == stockId);
        public void UpdateFunctionDataStock(FunctionStockData data) {
            var local = _context.FunctionStockData.Local.FirstOrDefault(entry => entry.Id == data.Id);
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }

            _context.FunctionStockData.Update(data);
            _context.SaveChanges();
        }
        public void DeleteFunctionDataById(int id) {
            var temp = _context.FunctionStockData.Find(id);
            if (temp != null) {
                _context.FunctionStockData.Remove(temp);
                _context.SaveChanges();
            }
        }
        public async Task<List<FunctionStockData>> SearchFunctionDataByQuantity(int quantity, int stockId) => await _context.FunctionStockData.AsNoTracking().Where(d => d.Quantity == quantity && d.StockId == stockId).ToListAsync();
        public async Task<List<FunctionStockData>> SearchFunctionDataByPrice(decimal price, int stockId) => await _context.FunctionStockData.AsNoTracking().Where(d => d.Price == price && d.StockId == stockId).ToListAsync();
        public async Task<List<FunctionStockData>> SearchFunctionDataByDate(DateTime date, int stockId) {
            var startDate = date.AddMinutes(-30);
            var endDate = date.AddMinutes(+30);
            return await _context.FunctionStockData
                .AsNoTracking()
                .Where(d => d.DateOfArrival >= startDate && d.DateOfArrival <= endDate && d.StockId == stockId)
                .OrderBy(d => d.DateOfArrival)
                .ToListAsync();
        }
        public async Task<List<FunctionStockData>> SearchFunctionDataByName(string name, int stockId) {
            var data = await _context.FunctionStockData.AsNoTracking().Where(d => d.StockId == stockId).ToListAsync();
            var searchedData = data.Where(d => Fuzz.Ratio(name, d.NameOfGood) > 80).ToList();
            return searchedData;
        }
        public void AddPhysicDataStock(PhysicStockData data) {
            _context.PhysicStockData.Add(data);
            _context.SaveChanges();
        }
        public async Task<List<PhysicStockData>> GetAllPhysicDataStockById(int id) => await _context.PhysicStockData.Where(f => f.StockId == id).ToListAsync();
        public void DeletePhysicDataById(int id) {
            var temp = _context.PhysicStockData.Find(id);
            if (temp != null) {
                _context.PhysicStockData.Remove(temp);
                _context.SaveChanges();
            }
        }
        public PhysicStockData GetPhysicDataStockById(int id, int stockId) => _context.PhysicStockData.FirstOrDefault(f => f.Id == id && f.StockId == stockId);
        public void UpdatePhysicDataStock(PhysicStockData data) {
            var local = _context.PhysicStockData.Local.FirstOrDefault(entry => entry.Id == data.Id);
            if (local != null) {
                _context.Entry(local).State = EntityState.Detached;
            }
            _context.PhysicStockData.Update(data);
            _context.SaveChanges();
        }
        public async Task<List<PhysicStockData>> SearchPhysicDataByName(string name, int stockId) {
            var data = await _context.PhysicStockData.AsNoTracking().Where(d => d.StockId == stockId).ToListAsync();
            var searchedData = data.Where(d => Fuzz.Ratio(name, d.NameOfGood) > 80).ToList();
            return searchedData;
        }
        public async Task<List<PhysicStockData>> SearchPhysicDataByQantity(int quantity, int stockId) => await _context.PhysicStockData.AsNoTracking().Where(d => d.Quantity == quantity && d.StockId == stockId).ToListAsync();
        public void UpdatePhysicDataQuantity(int dataId ,int stockId ,int quantity) {
            var currentDataToAdd = GetPhysicDataStockById(dataId,stockId);
            if (currentDataToAdd.Quantity + quantity <= 0)
                currentDataToAdd.Quantity = 0;
            else
                currentDataToAdd.Quantity += quantity;

            UpdatePhysicDataStock(currentDataToAdd);
        }
        public PhysicStockData GetPhysicDataByName(string name, int stockId) => _context.PhysicStockData.FirstOrDefault(s => s.NameOfGood == name && s.StockId == stockId);
    }
}
