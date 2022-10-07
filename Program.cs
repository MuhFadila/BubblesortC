using System;

namespace BubblesortC
{
    class Program
    {
        // Deklarasi array int dengan ukuran 20
        private int[] a = new int[20];

        // Deklarasi variabel int untuk menyimpan banyaknya data pada array 
        private int n;

        // Fungsi/Method untuk menerima masukan
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang di simpan pada array
            while (true)
            {
                Console.Write("Masukan banyaknya elemen pada array: ");
                String s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _");
            Console.WriteLine(" Masukan elemen Array");
            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ ");

            // Pengguna memasukan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + "> ");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
    }
    public void display()