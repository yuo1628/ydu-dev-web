using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class File
    {
        // Primary Key
        public int fileId { set; get; }

        // 檔案名稱
        public string name { set; get; }
        // 檔案路徑
        public string path { set; get; }

        // Navigation Property
        public virtual News news { set; get; }
        public virtual Product product { set; get; }
        public virtual Paragon paragon { set; get; }
    }
}