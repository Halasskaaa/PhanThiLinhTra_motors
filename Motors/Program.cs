namespace Motors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Statisztika statisztika = new Statisztika();

			string filename = "motors.txt"; 
			statisztika.ReadFromFile(filename);

            Console.WriteLine($"Összes motor összértéke: {statisztika.SumPrices()} EUR");

            Console.WriteLine(); //////////////////////////////////

            string valasztottMotor = "Royal Enfield";
			if ( ( statisztika.Contains(valasztottMotor) ) == true )
			{
                Console.WriteLine($"Van {valasztottMotor} a listában.");
            } 
			else
			{
				Console.WriteLine($"{valasztottMotor} nincs a listában.");
			}

			Console.WriteLine(); //////////////////////////////////

			Console.WriteLine($"A választott {valasztottMotor} brand motorok kollektív összege: {statisztika.SumBasedOnBrand(valasztottMotor, filename)}");

			Console.WriteLine(); //////////////////////////////////

			Console.WriteLine($"A legidősebb motor: {statisztika.Oldest()}");

			Console.WriteLine(); //////////////////////////////////

			statisztika.Sort();
			Console.WriteLine("Teljesítmény alapján sorbarendezés:");
			foreach (var motor in statisztika.motors)
			{
				Console.WriteLine($"Motor: {motor.Name}, Performance: {motor.Performance} HP");

			}
		}
	}
}
