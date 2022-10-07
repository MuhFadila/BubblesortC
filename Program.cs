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
    public void display()
    {
        // menampilkan array yang tersusun
        Console.WriteLine("");
        Console.WriteLine("_ _ _ _ _ _ _ _ _ _");
        Console.WriteLine("Element array yang telah tersusun");
        Console.WriteLine("_ _ _ _ _ _ _ _ _ _");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i]);
        }
        Console.WriteLine("");
    }
        public void BubblesortArray()
        {
            for (int i = 1; i < n; i++) // For n - 1 passes
            {
                // pada pass i, dibandingkan n - i elemen pertama dengan elemen selanjutnya
                for (int j = 0; j < n - i; j++)
                {
                    if (a[j] > a[j + 1]) // jika elemen tidak dalam urutan yang benar
    