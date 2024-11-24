using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SupplierDTO
    {
        public int SupplierID {  get; set; }
        public string SupplierName { get; set; }
        public string Phone {  get; set; }
        public string Address { get; set; }

        public SupplierDTO(int supplierID, string supplierName, string phone, string address)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            Phone = phone;
            Address = address;
        }
    }
}
