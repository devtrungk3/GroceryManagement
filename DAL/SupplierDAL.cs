using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SupplierDAL : DBConnection
    {
        public List<SupplierDTO> FindAllSuppliers()
        {
            List<SupplierDTO> suppliers = new List<SupplierDTO>();
            try
            {
                OpenConnection();
                string query = $"select supplier_id, supplier_name, phone, address from SUPPLIER order by supplier_id";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int supplierID;
                string supplierName;
                string phone;
                string address;
                while (reader.Read())
                {
                    supplierID = reader.GetInt32(0);
                    supplierName = reader.GetString(1);
                    phone = reader.GetString(2);
                    address = reader.GetString(3);
                    suppliers.Add(new SupplierDTO(supplierID, supplierName, phone, address));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return suppliers;
        }

        public List<SupplierDTO> FindAllSuppliersWithPaging(int pageNumber, int limit)
        {
            List<SupplierDTO> suppliers = new List<SupplierDTO>();
            try
            {
                OpenConnection();
                string query = $"select supplier_id, supplier_name, phone, address from SUPPLIER order by supplier_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int supplierID;
                string supplierName;
                string phone;
                string address;
                while (reader.Read())
                {
                    supplierID = reader.GetInt32(0);
                    supplierName = reader.GetString(1);
                    phone = reader.GetString(2);
                    address = reader.GetString(3);
                    suppliers.Add(new SupplierDTO(supplierID, supplierName, phone, address));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return suppliers;
        }

        public List<SupplierDTO> FindAllSuppliersBySupplierNameWithPaging(int pageNumber, int limit, string txtSearch)
        {
            List<SupplierDTO> suppliers = new List<SupplierDTO>();
            try
            {
                OpenConnection();
                string query = $"select supplier_id, supplier_name, phone, address from SUPPLIER where supplier_name like N'%{txtSearch}%' order by supplier_id offset {pageNumber * limit} rows fetch next {limit} rows only";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                int supplierID;
                string supplierName;
                string phone;
                string address;
                while (reader.Read())
                {
                    supplierID = reader.GetInt32(0);
                    supplierName = reader.GetString(1);
                    phone = reader.GetString(2);
                    address = reader.GetString(3);
                    suppliers.Add(new SupplierDTO(supplierID, supplierName, phone, address));
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return suppliers;
        }

        public bool InsertSupplier(SupplierDTO supplier)
        {
            try
            {
                OpenConnection();
                string query = $"insert into SUPPLIER(supplier_name, phone, address) values (N'{supplier.SupplierName}', '{supplier.Phone}', N'{supplier.Address}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }

        public bool UpdateSupplier(SupplierDTO supplier)
        {
            try
            {
                OpenConnection();
                string query = $"update SUPPLIER set supplier_name=N'{supplier.SupplierName}', phone='{supplier.Phone}', address=N'{supplier.Address}' where supplier_id={supplier.SupplierID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }

        public bool DeleteSupplier(string supplierID)
        {
            try
            {
                OpenConnection();
                string query = $"delete from SUPPLIER where supplier_id={supplierID}";
                SqlCommand cmd = new SqlCommand(query, conn);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { CloseConnection(); }
            return false;
        }
    }
}
