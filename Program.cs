using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectProduk
{
    class Program
    {
        
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
			bool loop = true;
            while (loop)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
						Console.Clear();
						Console.WriteLine("Sorry Menu Yang Anda Pilih Belum Tersedia, Terima Kasih")
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
			Console.WriteLine("Pilih Menu Aplikasi");
			Console.WriteLine("\n 1. Tambah Produk");
			Console.WriteLine("2. Hapus Produk");
			Console.WriteLine("3. Tampilkan Produk");
			Console.WriteLine("4. Keluar");
			
            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahProduk()
        {
            Console.Clear();

			Produk produk = new produk();
			Console.WriteLine("Tambah Data Produk");
			Console.Write("\nKode Produk : ");
			produk.KodeProduk = Console.ReadLine();
			Console.Write("Nama Produk : ");
			produk.NamaProduk = Console.ReadLine();
			Console.Write("Harga Beli : ");
			produk.HargaBeli = double.Parse(Console.ReadLine());
			Console.Write("Harga Jual : ");
			produk.HargaJual = double.Parse(Console.ReadLine());
			daftarProduk.Add(produk);
			
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
            Console.Clear();

            int no = -1, hapus = -1;
            Console.WriteLine("Hapus Data Produk");
            Console.Write("Kode Produk : ");
            string kode = Console.ReadLine();
            foreach (Produk produk in daftarProduk)
            {
                no++;
                if(produk.KodeProduk == kode)
                {
                    hapus = no;
                }
            }
            if (hapus != -1)
            {
                daftarProduk.RemoveAt(hapus);
                Console.WriteLine("\nData produk yang berhasil di hapus");
            }
            else
            {
                Console.WriteLine("\nKode produk yang tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
			
		}	


        static void TampilProduk()
        {
            Console.Clear();

            int noUrut = 0;
			Console.WriteLine("Data Produk");
			foreach (Produk produk in daftarProduk)\
			{
				noUrut++;
				Console.WriteLine("{0}. Kode Produk: {1}, Name Produk: {2}, Harga Beli: {3}, Harga Jual: {4}", noUrut, produk.KodeProduk, produk.NamaProduk, produk.HargaBeli, produk.HargaJual);
			}
			if (noUrut < 1)
			{
				Console.WriteLine
			}
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
