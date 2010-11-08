using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMS.Model
{
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseDate = System.DateTime.Now;
            Code = "CG" + PurchaseDate.ToString("yyyyMMddHHmmss");
        }
    }
}
