using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMS.Model
{
    public partial class OutboundOrder
    {
        public OutboundOrder()
        {
            OutboundDate = System.DateTime.Now;
            Code = "JY" + OutboundDate.ToString("yyyyMMddHHmmss");
        }
    }
}
