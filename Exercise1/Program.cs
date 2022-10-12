using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        //Deklarasi array int dengan ukuran 3+5+10+20+20-2x15 = 28
        private int[] dimas = new int[28];

        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;

        //Fungsi/method untuk menerima input
        public void read()
        {
            //Menginput angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada Array : ");

                //Menerima input representasi string sebuah angka
                string s = Console.ReadLine();

                //Mengubah representasi string sebuah angka menjadi ekivalen integer 32 bit
                n = int.Parse(s);
                //membuat kondisi jika input banyaknya data melebihi 28 atau tidak
                if (n <= 28)
                    break;
                else
                    Console.WriteLine("\nArray hanya dapat mempunyai maksimal 28 elemen.\n");
            }
            //Membuat tampilan menu untuk memasukkan elemen array
            Console.WriteLine("");
            Console.WriteLine("------------------------");
            Console.WriteLine(" Masukkan elemen Array ");
            Console.WriteLine("------------------------");

            //Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            { 
                Console.Write("<" + (i+ 1) + ">");
                //Menerima input representasi string sebuah angka
                string s1 = Console.ReadLine();
                //Mengubah representasi string sebuah angka menjadi ekivalen integer 32 bit
                dimas[i] = int.Parse(s1);  
                
            }

        }

        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Elemen Array yang telah tersusun");
            Console.WriteLine("---------------------------------");

            //if DB < n maka tampil array
            for (int DB = 0; DB < n; DB++)
            {
                Console.WriteLine(dimas[DB]);
            }
            Console.WriteLine("");
        }


        public void sort()
        {
            //Step 1
            //Repeat steps 2 and 3 varying DB from 0 to n - 2
            for (int DB = 0; DB < n - 1; DB++) 
            {

                //Step 2
                //Deklarasi variabel int untuk membuat temp dan min_index
                int temp, min_index;

                // a. Set min_index = DB
                min_index = DB;

                // b. Repeat step c varying i from DB + 1 to n - 1
                for (int i = DB + 1; i < n; i++)
                {
                    
                    // c. if dimas[i] < dimas[min_index]. min_index = i
                    if (dimas[i] < dimas[min_index])
                    {
                        min_index = i;
                    }

                }

                // Step 3
                //Menukar elemen dimas[min_index] dengan temp 
                temp = dimas[min_index];
                //Menukar elemen dimas[min_index] dengan dimas[DB]
                dimas[min_index] = dimas[DB];
                //Menukar elemen dimas[DB] dengan temp
                dimas[DB] = temp;
            }
        }
        static void Main(string[] args)
        {
            //Membuat objek dari class Program
            Program myApp = new Program();

            //Pemanggilan fungsi untuk menerima elemen array
            myApp.read();

            //Pemanggilan fungsi untuk mengurutkan array
            myApp.sort();

            //Pemanggilan fungsi untuk menampilkan array yang tersusun
            myApp.display();

            //Exit
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();

        }
    }
}
