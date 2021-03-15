﻿using System;

namespace Events
{
    class Program
    {
        //11.gunodev3
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            Product gsm = new Product(50);
            harddisk.ProductName = "Hard Disk";
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
                
            }

            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("GSM about to finish!!");
        }
    }
}
