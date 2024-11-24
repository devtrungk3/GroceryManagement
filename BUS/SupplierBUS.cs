using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SupplierBUS
    {
        private SupplierDAL supplierDAL = new SupplierDAL();
        public List<SupplierDTO> GetSuppliers()
        {
            return supplierDAL.FindAllSuppliers();
        }
        public List<SupplierDTO> GetSuppliersWithPaging(int pageNumber, int limit)
        {
            return supplierDAL.FindAllSuppliersWithPaging(pageNumber, limit);
        }
        public List<SupplierDTO> GetSuppliersBySupplierName(int pageNumber, int limit, string txtSearch)
        {
            return supplierDAL.FindAllSuppliersBySupplierNameWithPaging(pageNumber, limit, txtSearch);
        }

        public string InsertSupplier(SupplierDTO supplier)
        {
            if (supplierDAL.InsertSupplier(supplier)) return "";
            else return "Thêm nhà cung cấp thất bại";
        }

        public string UpdateSupplier(SupplierDTO supplier)
        {
            if (supplierDAL.UpdateSupplier(supplier)) return "";
            else return "Cập nhật nhà cung cấp thất bại";
        }

        public string DeleteSupplier(string supplierID)
        {
            if (supplierDAL.DeleteSupplier(supplierID)) return "";
            else return "Xóa nhà cung cấp thất bại";
        }
    }
}
