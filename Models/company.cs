using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Company
    {
        // Primary Key
        public int companyId { set; get; }

        // 名稱
        public string name { set; get; }
        // 簡介
        public string description { set; get; }
        // 地址
        public string address { set; get; }
        // 網址
        public string url { set; get; }
        // 電子郵件
        public string email { set; get; }
        // 電話
        public string phone { set; get; }
        // 傳真
        public string fax { set; get; }

        // Navigation Property
        public virtual ICollection<Product> products { set; get; }
        public virtual ICollection<Paragon> paragons { set; get; }
        public virtual ICollection<Founder> founders { set; get; }
    }
}