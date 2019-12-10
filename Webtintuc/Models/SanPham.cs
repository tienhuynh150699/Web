using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Webtintuc.Models
{
    public class SanPham
    {
        [ScaffoldColumn(false)]
        public int TinID { get; set; }
        [Required, StringLength(100), Display(Name = "Ten")]
        public string Noidung { get; set; }
        [Required, StringLength(1000), Display(Name = "SanPham Description"),
        DataType(DataType.MultilineText)]
        public string Ngaygui { get; set; }
        public string HinhAnh { get; set; }
        public int? Tgia_ID { get; set; }
        public virtual PhanLoai PhanLoai { get; set; }
    }
}