using System;

namespace DiceGame
{
	class Program
	{
		static void Main(string[] args)
		{
			// Mängus osaleb 2 mängijat - arvuti (cpu) ja kasutaja (user)
			// Mõlemad mängijad viskavad täringuid;
			// Programm kontrollib, kumb mängija viskas rohkem;
			// Mängija kes viskab rohkem on võitja;
			// *Täringuid visatakse kolm korda;
			// Programm kuulutab võitja;

			Random rnd = new Random();

			int cpuScore = 0;
			int userScore = 0;


			for (int i = 0; i < 3; i++)
			{
				int cpuRandom = rnd.Next(1, 7);
				int userRandom = rnd.Next(1, 7);

				Console.WriteLine($"Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}");

				if (cpuRandom < userRandom)
				{
					userScore = userScore + 1;
					Console.WriteLine($"Mängu number {i + 1} võitis Kasutaja");
				}

				else if (cpuRandom > userRandom)
				{
					cpuScore = cpuScore + 1;
					Console.WriteLine($"Mängu number {i + 1} võitis Arvuti");
				}
				else
				{
					Console.WriteLine($"Mäng number {i + 1} on viigis!");
				}

			}

			if (cpuScore > userScore)
			{
				Console.WriteLine($"Arvuti võitis {cpuScore}/{userScore}");
			}
			else if (cpuScore < userScore)
			{
				Console.WriteLine($"Kasutaja võitis {userScore}/{cpuScore}");
			}
			else
			{
				Console.WriteLine("Seis on viigis, keegi ei võitnud");
			}
					
			Console.WriteLine("Kena päeva!");

		}
	}
}
