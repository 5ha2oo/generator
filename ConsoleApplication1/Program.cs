using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Ticket
    {
        static void Main()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(GenerateTicket());
            }
            Console.ReadLine();

        }
        static string GenerateTicket()
        {
            StringBuilder ticket = new StringBuilder(100);
            Random rand = new Random();

            int ulga = rand.Next(0, 5) * 10;
            int price = 100 - ulga;
            ticket.Append(ulga.ToString() + '%' + ',');
            ticket.Append(price.ToString() + ',');
            return ticket.ToString();
        }
    }

    class Play
    {
        static void Main()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(GeneratePlay());
            }
            Console.ReadLine();

        }
        static string GeneratePlay()
        {
            StringBuilder play = new StringBuilder(100);
            Random rand = new Random();

            string[] names = GenerateName(System.IO.File.ReadAllLines(@"sztuki.txt"), 100) ;




            return play.ToString();
        }
        static string[] GenerateName(string[] list, int amount)
        {
            Random rand = new Random();
            string[] generes = { "dramat", "komedia", "opera", "pantomima", "lalki" };


            string[] names = new string[amount];
            for(int i=0; i<amount; i++)
            {
                names[i]=list[i] + ',' + generes[rand.Next(5]);
   
            }
            return names[];
        }


    }


    class Person
    {
        static void Main()
        {

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(GeneratePerson());
            }
            Console.ReadLine();
        }


        static string GeneratePerson()
        {
            StringBuilder person = new StringBuilder(100);
            Random rand = new Random();

            string[] names = System.IO.File.ReadAllLines(@"lista_polskich_imion.txt");
            string[] second_names = System.IO.File.ReadAllLines(@"nazwiska.txt");
            string[] nicknames = System.IO.File.ReadAllLines(@"pseudonimy.txt");

            string[] cities = System.IO.File.ReadAllLines(@"miasta.txt");
            string[] streets = System.IO.File.ReadAllLines(@"ulice.txt");
            string name = GenerateName(names);
            string second_name = GenerateName(second_names);
            string PESEL = GenerateNumber(rand, 11);
            string PhoneNumber = GenerateNumber(rand, 9);
            string email = GenerateEmail(rand, name, second_name);
            person.Append(name + ',');
            person.Append(second_name + ',');
            person.Append(PESEL + ',');
            person.Append(PhoneNumber + ',');
            person.Append(email + ',');

            return person.ToString();
        }
        static string GenerateNumber(Random rand, int n)
        {
            StringBuilder telNo = new StringBuilder(12);
            int number;
            for (int i = 0; i < n; i++)
            {
                number = rand.Next(0, 9);
                telNo = telNo.Append(number.ToString());
            }
            return telNo.ToString();
        }
        static string GenerateName(string[] list)
        {
            Random rand = new Random();
            int index = rand.Next(list.Length);
            return list[index];
        }
        static string GenerateAddress(Random rand, string[] cities, string[] streets)
        {
            int index = rand.Next(cities.Length);
            int index2 = rand.Next(streets.Length);
            StringBuilder address = new StringBuilder(100);
            address.Append(streets[index] + ' ');
            address.Append(rand.Next(100) + ", ");
            address.Append(rand.Next(10, 99) + '-');
            address.Append(rand.Next(100, 999) + ' ');
            address.Append(cities[index2]);
            return address.ToString();

        }

        static string GenerateEmail(Random rand, string name, string surname)
        {

            string[] emails = { "gmail.com", "outlook.com", "yahoo.com", "o2.pl", "interia.pl", "onet.pl", "wp.pl" };

            string email = name.Substring(0, rand.Next(name.Length)) + surname;
            //wybierz domenę ze zbioru
            string ending = emails[rand.Next(emails.Length)];

            //dopisz losowe cyfry
            int digitCount = rand.Next(5);
            for (int i = 0; i < digitCount; i++)
            {
                email += "" + rand.Next(1000);
            }

            email += "@" + ending;

            //zwróć wynik
            return "'" + email + "'";
        }

    }
}
