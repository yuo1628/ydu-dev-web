using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Category
    {
        // Primary Key
        public int categoryId { set; get; }

        // 分類名稱
        public string name { set; get; }

        // Navigation Property
        public virtual ICollection<News> news { set; get; }
    }
}