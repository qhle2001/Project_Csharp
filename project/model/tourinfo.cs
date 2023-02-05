using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.model
{
    public class tourinfo
    {
        public string Id { set; get; }
        public string Diemden { set; get; }
        public string Ten { set; get; }
        public string Lichtrinh { set; get; }
        public string Khoihanh { set; get; }
        public string Thoigian { set; get; }
        public string Giatien { set; get; }
        public tourinfo(string id, string diemden, string ten,  string lichtrinh, string khoihanh, string thoigian, string giatien)
        {
            Id = id;
            Diemden = diemden;
            Ten = ten;
            Lichtrinh = lichtrinh;
            Khoihanh = khoihanh;
            Thoigian = thoigian;
            Giatien = giatien;
        }
    }
}
