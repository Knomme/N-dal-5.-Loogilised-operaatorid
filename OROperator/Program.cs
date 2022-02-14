using System;

namespace OROperator
{
	class Program
	{
		static void Main(string[] args)
		{
			//Programm küsib kasutajal sisestada kasutajatunnus ja salasõna
			// Kui sisestatud kasutajatunnus on "admin" ja sissestatud salasõna on "admin1234"
			// Siis konsoolis kuvatakse "Tere tulemast";
			// Muuljuhul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti";


			Console.WriteLine("Sisesta kasutajatunnus!");
			string userName = Console.ReadLine();
			Console.WriteLine("Sisesta salasõna!");
			string userPassword = Console.ReadLine();


			//OR (võ) || (pipes)

			// true || true --> true
			// false || true -- true
			// true || false -- true
			// false || false --> false 

			if (userName != "admin" || userPassword != "admin1234")
			{
				Console.WriteLine("Vale kasutajatunnus või salasõna! Proovi uusti");

			}
			else
			{
				Console.WriteLine("Tere tulemst");
			}

			// "admin1" != "admin" || "admin1234" == "admin1234" --> true || false --> true
			// "admin" != "admin" || "admin123 != "admin1234" --> false || trure --> true 
			// "admin1" != "admin" || "admin123" != "admin1234" --> true || true --> true
			// "admin != "admin" || "admin1234" != "admin1234" --> false || false --> false






		}
	}
}
