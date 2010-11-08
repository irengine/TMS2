using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMS.Model
{
    public partial class InboundOrder
    {
        public InboundOrder()
        {
            InboundDate = System.DateTime.Now;
            Code = "GH" + InboundDate.ToString("yyyyMMddHHmmss");
        }
    }
}
