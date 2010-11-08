using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TMS.Model
{
    public partial class ScrapOrder
    {
        public ScrapOrder()
        {
            ScrapDate = System.DateTime.Now;
            Code = "BF" + ScrapDate.ToString("yyyyMMddHHmmss");
        }
    }
}
