using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
       static void Main(string[] args)
        {
                Console.Title = "Responsi UAS Matakuliah Pemrograman";
    
                List<Customer> listCustomer = new List<Customer>();
                
                

                while (true)
                {
                    TampilMenu();

                    Console.Write("\nNomor Menu [1..4]: ");
                    int nomorMenu = Convert.ToInt32(Console.ReadLine());

                    switch (nomorMenu)
                    {
                        case 1:
                            TambahCustomer();
                            break;

                        case 2:
                            HapusCustomer();
                            break;

                        case 3:
                            TampilCustomer();
                            break;

                        case 4: // keluar dari program
                            return;

                        default:
                            break;
                    }
                }
            void TampilMenu()
            {
                Console.Clear();

                // TODO: tuliskan logika Anda di sini ...
                Console.WriteLine();
                Console.WriteLine("Menu :\n1.Tambah Customer\n2. Hapus Customer\n3.Tampilkan Customer\n4. Keluar");
               

            }

            void TambahCustomer()
            {
                Console.Clear();

                // TODO: tuliskan logika Anda di sini ...
                Customer cs = new Customer();
                Console.Write("Kode Customer : ");
                cs.KodeCustomer = Console.ReadLine();
                Console.Write("Nama Customer : ");
                cs.NamaCustomer = Console.ReadLine();
                Console.Write("Total Piutang : ");
                cs.TotalPiutang = Console.ReadLine();

                listCustomer.Add(cs);
                Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
                Console.ReadKey();
            }

            void HapusCustomer()
            {
                Console.Clear();

                // TODO: tuliskan logika Anda di sini ...
                Console.Write("Masukkan Kode Customer : ");
                string search = Console.ReadLine();

                int index = 0;
                foreach(Customer cs in listCustomer)
                {
                    if(cs.KodeCustomer == search)
                    {
                        break;
                    }
                    index++;
                }
                listCustomer.RemoveAt(index);
                Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
                Console.ReadKey();
            }

            void TampilCustomer()
            {
                Console.Clear();

                // TODO: tuliskan logika Anda di sini ...
                int index = 1;
                foreach(Customer cs in listCustomer)
                {
                    Console.WriteLine("{0}.\t{1}\t{2}\t{3}", index++, cs.KodeCustomer, cs.NamaCustomer, cs.TotalPiutang);
                }

                Console.WriteLine("\nTekan enter untuk kembali ke menu");
                Console.ReadKey();
            }
        }

            
           
    }
}
