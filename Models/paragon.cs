using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    // 成功案例
    public class Paragon
    {
        // Primary Key
        public int paragonId { set; get; }

        // 標題
        public string title { set; get; }
        // 內文
        public string content { set; get; }

        // Foreign Key
        public int companyId { set; get; }

        // Navigation Property
        // 圖片
        public virtual ICollection<File> images { set; get; }

        public virtual Company company { set; get; }
    }
}