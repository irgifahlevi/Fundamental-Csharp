using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesObjects
{
    class Buku
    {

        // Merupakan atribute
        public string judul;
        public string penulis;
        public int halaman;


        // Constructor
        public Buku(string aJudul, string aPenulis, int aHalaman)
        {
            judul = aJudul;
            penulis = aPenulis;
            halaman = aHalaman;
        }

    }
}