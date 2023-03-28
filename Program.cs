
using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Udemy_Project
{

  


    class Test
    {
        static public void Main(string[]args)
        {
            Console.WriteLine("Hello, Please may I take your name");
            var userName = (Console.ReadLine());

            Console.WriteLine("Hello{0}", userName, "May i take your order please");
            Console.WriteLine("Please can you confirm which base you would like.");

            
         

             Console.WriteLine("Small Pizza: £8.99 ");
            int sm = int.Parse(Console.ReadLine());

            Console.WriteLine("Medium Pizza: £13.99 ");
            int med = int.Parse(Console.ReadLine());

            Console.WriteLine("Large Pizza: £15.99 ");
            int lge = int.Parse(Console.ReadLine());


            float smTotal = 8.99f * sm;
            
            float medTotal = 13.99f * med;

            float lgeTotal = 12.99f * lge;
           
           float sumTotal = (smTotal + medTotal + lgeTotal);

            Console.WriteLine( $"{userName} Your total is £ {sumTotal}");



        }
    }
}

       





        


