using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zzkluck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zzkluck.Tests
{
	[TestClass()]
	public class FunctionCalculatorTests
	{
		[TestMethod()]
		public void calculateTest()
		{
			List<FCResult> result=FunctionCalculator.calculate(0, 1, 0.001, f);
			FCResult r = result[0];
			foreach (FCResult item in result)
			{
				if (item.result > r.result)
					r = item;
			}

			double aaa = r.result;
		}

		double f(double x,double y,double z)
		{
			return 0.225 * x + 0.263 * y + 0.172 * z - 0.348 * x * y - 0.29 * x * z - 0.314 * y * z - 0.087 * x * y * z;
		}
	}
}