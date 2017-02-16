using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zzkluck
{ 
    public static class Algorithm
    {
		public static int ShuffleArray<T>
			(List<T> someArray)
		{
			return ShuffleArray(someArray, new Random());
		}

		public static int ShuffleArray<T>
			(List<T> someArray,Random r)
		{
			int i = someArray.Count;
			int j = 0;
			T temp = default(T);
			if (i == 0)
				return 0;
			while (--i > 0)
			{
				j = r.Next(i);
				temp = someArray[i];
				someArray[i] = someArray[j];
				someArray[j] = temp;
			}
			return 1;
		}
	}
}
