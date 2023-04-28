using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassMethod
{
    public class Produk
    {
        public string nama;
        public string description;
        public double harga;

        public Produk(string Nama, string Description, double Harga)
        {
            nama = Nama;
            description = Description;
            harga = Harga;
        }

        public bool CariHarga()
        {
            if (harga >= 3)
            {
                return true;
            }
            return false;
        }
    }
}