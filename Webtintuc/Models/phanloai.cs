using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webtintuc.Models
{
    public class PhanLoai
    {
        [ScaffoldColumn(false)]
        public int Tgia_ID { get; set; }
        [Required, StringLength(100), Display(Name = "Ten")]
        public string TenTG { get; set; }
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}