using System;
using System.Collections;//ctrl+. otomatik eklemeye yardımcı olur.
using System.Collections.Generic;

namespace array_List // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system.Collectionons namespace
            ArrayList liste=new ArrayList();
           //liste.Add("Ayşe");
           //liste.Add(2);
           //liste.Add(true);
           //liste.Add('A');

           ////içerisinde verilere erişim
           //Console.WriteLine(liste[1]);
           //foreach (var item in liste)
           //{
           //    Console.WriteLine(item);
           //}

            //Addrange
            Console.WriteLine("***Add range ***");
            //string[] renkler={"kırmızı","sarı", "yeşil"};
            List<int> sayilar=new List<int>(){1,8,3,7,9,92,5};
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //Sort
            Console.WriteLine("***sort***");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //Binary Search
            Console.WriteLine("***Binary Search***");
            Console.WriteLine(liste.BinarySearch(9));
            //reverse
            Console.WriteLine("***reverse***");//aynalama
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            //Clear
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}
