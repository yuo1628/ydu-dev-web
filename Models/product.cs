using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Product
    {
        // Primary Key
        public int productId { set; get; }

        // 名稱
        public string name { set; get; }
        // 介紹
        public string description { set; get; }
        
        // Foreign Key
        public int companyId { set; get; }

        // Navigation Property
        // 圖片
        public virtual ICollection<File> images { set; get; }

        public virtual Company company { set; get; }
    }
}