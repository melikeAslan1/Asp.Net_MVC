using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ilk_MVC_Projem.Models
{
    public class Blog
    {
        public int ID { get; set; }

        public string Baslik { get; set; }

        public string Detay { get; set; }

        public DateTime Tarih { get; set; }
        //public Yazar Yazar { get; set; }
    }
}