﻿using System;
using HW4.MKlasse;

namespace HW4
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("starter...");

            MinListe ml = new MinListe();
            MinData md = new MinData(){Id=1,Navn="test1"};
            MinData md2 = new MinData(){Id=2,Navn="test2"};
            MinData md3 = new MinData(){Id=3,Navn="test3"};

            ml.AddData(md);
            ml.AddData(md2);
            ml.AddData(md3);
            ml.PrintListe();
            ml.DelData(2);
            ml.PrintListe();







        }
    }
}
