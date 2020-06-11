using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
	public class hutan : IHabitat
	{
		public void tempatTinggal()
		{
			Console.WriteLine("Habitat hutan ini biasanya diperuntukkan untuk hewan buas seperti harimau");
		}
	}
}
