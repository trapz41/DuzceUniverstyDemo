using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Duyurular
    {
        [Key]
        public int id { get; set; }
        public string pictures { get; set; }
        public string baslik { get; set; }
        public string duyuru { get; set; }
    }
}