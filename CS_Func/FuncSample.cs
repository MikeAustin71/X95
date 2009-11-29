using System;

namespace CS_Func
{
	public class FuncSample
	{

		public Action<string> WriteResult;

		 public int Multiply(Func<int,int,int> calculator, int i1, int i2)
		 {
				var result = calculator(i1, i2);

				if(WriteResult!=null)
				{
			 		WriteResult(result.ToString());
				}

        return result;
		 }

		public  int MyCalc01(int x, int y)
		{
			return x*y;
		}

	  public int MyCalc02(int arg1, int arg2)
	  {
	    return (arg1*arg2) + 1; 
	  }
	}
}