using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> items = new List<int>()
			{
				1,
				2,
				3,
				4,
				5,
			};
			items.Remove(2);
			items.Remove(4);

			foreach (int item in items)
			{
				Console.WriteLine(item);
			}
		}
	}
}
