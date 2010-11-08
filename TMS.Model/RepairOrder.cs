using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMS.Model
{
    public partial class RepairOrder
    {
        public RepairOrder()
        {
            RepairDate = System.DateTime.Now;
            Code = "XL" + RepairDate.ToString("yyyyMMddHHmmss");
        }
    }
}
