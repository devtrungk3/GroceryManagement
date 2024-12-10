using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class InventoryBUS
    {
        private InventoryDAL inventoryDAL = new InventoryDAL();
        public List<InventoryDTO> GetInventoriesWithPaging(int pageNumber, int limit)
        {
            return inventoryDAL.FindAllInventoriesWithPaging(pageNumber, limit);
        }
        public List<InventoryDTO> GetInventoriesByProductNameWithPaging(int pageNumber, int limit, string txtSearch)
        {
            return inventoryDAL.FindAllInventoriesByProductName(pageNumber, limit, txtSearch);
        }
        public int GetTotalQuantity()
        {
            return inventoryDAL.FindTotalQuantity();
        }
    }
}
