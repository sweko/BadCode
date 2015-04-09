using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIssues
{
    partial class Person
    {
        #region static data

        private static Random random = new Random();
        private static List<string> firstNames = new List<string>
        {
            "Aleksandar",
            "Atanas",
            "Angel",
            "Andon",
            "Blagoja",
            "Bogdan",
            "Branko",
            "Boris",
            "Vladimir",
            "Venko",
            "Viktor",
            "Vojdan",
            "Gorast",
            "Gavril",
            "Goce",
            "Gligor",
            "Dobromir",
            "Dejan",
            "Dragan",
            "Darko",
            "Emanuel",
            "Emil",
            "Evgenij",
            "Zoran",
            "Zlatko",
            "Zdravko",
            "Ilija",
            "Ivan",
            "Igor",
            "Isak",
            "Jakov",
            "Jovan",
            "Jordan",
            "Josip",
            "Kiril",
            "Kliment",
            "Krste",
            "Kuzman",
            "Lazar",
            "Luka",
            "Leonid",
            "Marjan",
            "Marko",
            "Matej",
            "Mitre",
            "Naum",
            "Nestor",
            "Nikola",
            "Oliver",
            "Ognen",
            "Petar",
            "Predrag",
            "Pavle",
            "Petko",
            "Riste",
            "Robert",
            "Rade",
            "Stefan",
            "Simon",
            "Slave",
            "Stojan",
            "Trajan",
            "Todor",
            "Trifun",
            "Filip",
            "Haralampie",
            "Cvetan",
            "Wekoslav"
        };


        private static List<string> lastNames = new List<string>
        {
            "Atanasovski", 
            "Atanasov",
            "Angelov",
            "Angelovski",
            "Angelski",
            "Andonoski",
            "Andonov",
            "Andov",
            "Andovski",
            "Andreev",
            "Andreevski",
            "Blagojevski",
            "Blagoev",
            "Bogdanov",
            "Bogdanovski",
            "Borisovski",
            "Borisov",
            "Vladimirov",
            "Venkovski",
            "Viktorov",
            "Vojdanovski",
            "Vojdanski",
            "Gavrilovski",
            "Gocevski",
            "Gocev",
            "Gligorov",
            "Dobromirski",
            "Draganov",
            "Dimitrov",
            "Dimitrovski",
            "Dimitroski",
            "Donev",
            "Emanuelovski",
            "Emilov",
            "Zlatanov",
            "Zdravkovslo",
            "Iliev",
            "Ivanov",
            "Ilioski",
            "Isakovski",
            "Jakovlev",
            "Jovanov",
            "Jordanovski",
            "Josipov",
            "Kirilovski",
            "Kliment",
            "Kamilovski",
            "Krstevski",
            "Kuzman",
            "Lazarov",
            "Leonidov",
            "Marjanovski",
            "Markov",
            "Matejev",
            "Mitrevski",
            "Naumoski",
            "Nestorov",
            "Nikolov",
            "Ognenov",
            "Petrov",
            "Pavlevski",
            "Petkov",
            "Ristevski",
            "Radeski",
            "Stefanovski",
            "Slavevski",
            "Stojanov",
            "Trajanovski",
            "Todorov",
            "Trifunovski",
            "Filipov",
            "Haralampievski",
            "Cvetanov",
            "Pecijarevski",
            "Belazelkovski",
            "Volkov",
            "Begovski",
            "Popov",
            "Popovski",
            "Hadziristevski",
            "Stamatovski",
            "Zahariev"
        };
        #endregion static data

        public static IEnumerable<Person> GeneratePersons(int count)
        {
            return Enumerable.Range(0, count).Select(_ => GeneratePerson());
        }

        public static Person GeneratePerson()
        {
            string firstName = firstNames[random.Next(firstNames.Count)];
            string lastName = lastNames[random.Next(lastNames.Count)];
            string idNumber = GenerateIdNumber(3, 7);

            return new Person
            {
                FirstName = firstName,
                LastName = lastName,
                IdNumber = idNumber
            };
        }

        private static string GenerateIdNumber(int alpha, int numeric)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < alpha; i++)
            {
                sb.Append((char)('A' + random.Next(26)));
            }
            for (int i = 0; i < numeric; i++)
            {
                sb.Append((char)('0' + random.Next(10)));
            }
            return sb.ToString();
        }
    }
}
