using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webtintuc.Models
{
    public class Dulieu
    {
        protected override void Seed(LienKet context)
        {
            GetPhanLoais().ForEach(c => context.PhanLoais.Add(c));
            GetSanPhams().ForEach(p => context.SanPhams.Add(p));
        }
        private static List<PhanLoai> GetPhanLoais()
        {
            var phanloais = new List<PhanLoai>
            {
                new PhanLoai
                {
                    Tgia_ID = 1,
                    TenTG = "bàn ăn"
                },
                new PhanLoai
                {
                    Tgia_ID = 2,
                    TenTG = "Ghế"
                }
            };
            return phanloais;
        }
        private static List<SanPham> GetSanPhams()
        {
            var sanphams = new List<SanPham> {
                new SanPham
                {
                    TinID = 1,
                    Noidung = "Bàn trà",
                    Ngaygui = "Phong cách hiện đại",
                    HinhAnh ="bantra.jpg",
                    Tgia_ID = 1
                    },
                new SanPham
                {
                    TinID = 2,
                    Noidung= "Bàn ăn",
                    Ngaygui = "Phong cách đơn giản",
                    HinhAnh ="banan1.jpg",
                    Tgia_ID = 1
                },
                new SanPham
                {
                    TinID = 2,
                    Noidung = "Ghế",
                    Ngaygui = " Phong cách Châu Âu",
                    HinhAnh ="ghe.jpg",
                    Tgia_ID = 2
                },
            };
            return sanphams;
        }
    }
}