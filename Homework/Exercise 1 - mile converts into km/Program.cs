using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1___mile_converts_into_km
{
	class Program
	{
		static void Main(string[] args)
		{
			decimal measurementMi = 33.0m;
			decimal measurementKm;
			const decimal convertvalue = 1.609344m;
			//convert formula
			measurementKm = measurementMi * convertvalue;
			Console.WriteLine($"{measurementMi:0.00} mi = {measurementKm:0.00} km");
			measurementMi = measurementKm / convertvalue;
			Console.WriteLine($"{measurementKm:0.00} km = {measurementMi:0.00} mi");
		}
	}
}
