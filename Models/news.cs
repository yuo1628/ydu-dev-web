using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class News
    {
        // Primary Key
        public int newsId { set; get; }

        public string title { set; get; }
        public string content { set; get; }
        public Nullable<DateTime> publish_time;
        public Nullable<DateTime> edit_time;

        // Foreign Key
        public int categoryId { set; get; }

        // Navigation Property
        public virtual Category category { set; get; }
        public virtual ICollection<File> files { set; get; }
    }
}