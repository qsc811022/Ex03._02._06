using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03._02._06
{
	class Program
	{
		static void Main(string[] args)
		{
			Q1();
			Q2();
			Q3();
		}
		static void Q1()
		{
			DisplayHeader("Q1");
			string value = " abc ";
			// todo  
			var result =value.Trim();
            Console.WriteLine(result.Length);
		}
		static void Q2()
		{
			DisplayHeader("Q2");
			string value = "Allen Kuo";
			// todo 
			var result =value.ToUpper();
            Console.WriteLine(result);
		}
		static void Q3()
		{
			DisplayHeader("Q3");
			string value = "aLLeN kUO";
			// todo 
			TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            Console.WriteLine(ti.ToTitleCase(value));

		}

		static void DisplayHeader(string title)
		{
			Console.WriteLine("\r\n");
			Console.WriteLine(title);
			Console.WriteLine(new string('=', 40));
		}
	}
}
