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
	public class AlgorithmTests
	{
		[TestMethod()]
		public void ShuffleArrayTest()
		{
			const int max = 6;
			const int testCount = 10000;
			const double maxDeviation = 0.1;
			const double averageDeviation = 0.05;
			const double averageMeaning = 0.1;
			//允许averageMeaning比例的数据超过averageDeviation但小于maxDeviation

			const double frequencyShouldBe = testCount / max;

			//初始化待排序数组
			List<int> someArray = new List<int>(max);
			for (int i = 0; i < max; i++)
			{
				someArray.Add(i);
			}

			//进行随机排序
			int[,] numberCount = new int[max, max];
			int tc = testCount;
			while (--tc >= 0)
			{
				Algorithm.ShuffleArray(someArray, new Random(testCount));
				for (int i = 0; i < max; i++)
				{
					numberCount[i, someArray[i]] += 1;
				}
			}

			int LargeDeviationCount = 0;
			foreach (double i in numberCount)
			{
				double deviation = Math.Abs((i - frequencyShouldBe) / frequencyShouldBe);
				if (deviation >= maxDeviation)
				{
					Assert.Fail("某一数据误差超过10%：第{0}个数据，误差为{1}",i,deviation);
				}
				else if (deviation >= averageDeviation)
				{
					LargeDeviationCount += 1;
				}

				if (LargeDeviationCount > (testCount * averageMeaning))
					Assert.Fail("平均误差过大：{0}",LargeDeviationCount);
			}
			Assert.IsTrue(true);
		}
	}
}