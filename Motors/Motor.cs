using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motors
{
	internal class Motor
	{
		string brand;
		string name;
		int releaseYear;
		double performance;
		double priceInEur;

		public Motor(string brand, string name, int releaseYear, double performance, double priceInEur)
		{
			this.brand = brand;
			this.name = name;
			this.releaseYear = releaseYear;
			this.performance = performance;
			this.priceInEur = priceInEur;
		}

		public string Brand { get => brand; }
		public string Name { get => name; }
		public int ReleaseYear { get => releaseYear; }
		public double Performance { get => performance; }
		public double PriceInEur { get => priceInEur; }
	}
}
