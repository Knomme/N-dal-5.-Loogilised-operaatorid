using System;

namespace LogInValidation
{
	class Program
	{
		static void Main(string[] args)
		{
			//Programm küsib kasutajal sisestada kasutajatunnus ja salasõna
			// Kui sisestatud kasutajatunnus on "admin" ja sissestatud salasõna on "admin1234"
			// Siis konsoolis kuvatakse "Tere tulemast";
			// Muuljuhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti";
			// Kasutajal on kolm katset;


			int i = 0;

			while (i < 3)
			{
				Console.WriteLine("Sisesta kasutajatunnus!");
				string userName = Console.ReadLine();
				Console.WriteLine("Sisesta salasõna!");
				string userPassword = Console.ReadLine();

				if (userName == "admin" && userPassword == "admin1234")
				{
					Console.WriteLine("Tere tulemast!");
					break;
				}
				else
				{
					i++;
					Console.WriteLine("Vale kasutajatunnus või salasõna!");
				}

				

			}



		}
	}
}
