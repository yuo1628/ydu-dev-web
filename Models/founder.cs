using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    // 創業者
    public class Founder
    {
        // Primary Key
        public int founderId { set; get; }

        // 姓名
        public string name { set; get; }
        // 電話
        public string phone { set; get; }
        // 學校
        public string school { set; get; }

        // Navigation Property
        public virtual Company company { set; get; }
    }
}