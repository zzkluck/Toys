using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zzkluck
{
	public static class FunctionCalculator
	{
		public delegate double OneParamFunction(double x);
		public delegate double TwoParamFunction(double x,double y);
		public delegate double ThreeParamFunction(double x,double y,double z);

		public static List<FCResult> calculate(double min,double max,double stepLength,ThreeParamFunction f)
		{
			List<FCResult> results = new List<FCResult>();
			for (double x = min;  x< max; x+=stepLength)
			{
				for(double y = min; y < 1-x; y += stepLength)
				{
					double z = 1 - x - y;
					results.Add(new FCResult(f(x, y, z), x, y, z));
				}
			}
			return results;

		} 

	}

	public class FCResult
	{
		public double result;
		public double x, y, z;
		public FCResult(double result,double x,double y,double z)
		{
			this.result = result;
			this.x = x;
			this.y = y;
			this.z = z;
		}
	}

}
