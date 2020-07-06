using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    public abstract class Produk
    {
        public string KodeProduk { get; set; }
        public string NamaProduk { get; set; }
        public double HargaBeli { get; set; }
        public double HargaJual { get; set; }
		
    }
}
