using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_Func
{
	class Program
	{
		static void Main(string[] args)
		{
			var u = new FuncSample();
      
		  u.WriteResult += WriteToConsole;

			u.Multiply(u.MyCalc01, 5, 2);

		  u.Multiply(u.MyCalc02, 5, 2);

		  Console.ReadLine();

    }

	  private static void WriteToConsole(string result)
	  {
	    Console.WriteLine("And  the result  is = " + result);
	    Console.WriteLine("-------------------------------------------------");
	  }
	}
}
