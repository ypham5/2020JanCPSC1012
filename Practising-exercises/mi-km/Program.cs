using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mi_km
{
    class Program
    {
        static void Main(string[] args)
        {
            //MILE TO KM
            decimal measurementMi = 33.0m;
            decimal measurementKm;
            const decimal convertvalue = 1.609344m;
            //convert formula
            measurementKm = measurementMi * convertvalue;
            Console.WriteLine($"{measurementMi:0.00} mi = {measurementKm:0.00} km");
            //KM TO MILE
            decimal lengthinMi;
            decimal lengthinKm = 5.0m;
            lengthinMi = lengthinKm / convertvalue;
            Console.WriteLine($"{lengthinKm:0.00} km = {lengthinMi:0.00} mi");
        }
    }
}
