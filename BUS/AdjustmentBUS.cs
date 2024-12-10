using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AdjustmentBUS
    {
        private AdjustmentDAL adjustmentDAL = new AdjustmentDAL();
        public List<AdjustmentDTO> GetAdjustmentsByAdjustmentDate(string date)
        {
            return adjustmentDAL.FindAllAdjustmentsByAdjustmentDate(date);
        }
        public string InsertAdjustment(AdjustmentDTO adjustment)
        {
            if (adjustmentDAL.InsertAdjustment(adjustment)) return "";
            return "Thêm điều chỉnh thất bại";
        }
        public string UpdateAdjustment(AdjustmentDTO adjustment)
        {
            if (adjustmentDAL.UpdateAdjustment(adjustment)) return "";
            return "Cập nhật điều chỉnh thất bại";
        }
        public string DeleteAdjustment(string adjustmentID)
        {
            if (adjustmentDAL.DeleteAdjustment(adjustmentID)) return "";
            return "Xóa điều chỉnh thất bại";
        }
    }
}
