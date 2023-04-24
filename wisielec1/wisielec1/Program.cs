namespace wisielec1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String plik;       
            plik = File.ReadAllText("C:\\Users\\Krzys\\Desktop\\test.txt");// Nie mialem bazy hasel to sam sobie napisalem pare 
            string[] slowa = plik.Split(' ').ToArray();
            int szanse = 5;
            Random rand = new Random();
            string haslo = slowa[rand.Next(slowa.Length)];
            char[] zgadniete = new char[haslo.Length];

            for (int i = 0; i < haslo.Length; i++) 
            {
                zgadniete[i] = '_' ;
            }
            Console.WriteLine("Witaj w wisielcu");
            Console.WriteLine("-----------------");
            while (szanse > 0 && Array.IndexOf(zgadniete, '_') != -1) // Tutaj nie do konca wiedzialem jak uzyc tego index of takze z neta musialem sie wspomoc 
            {
                Console.WriteLine("Masz jeszcze {0} prob ! ", szanse);
                Console.WriteLine(zgadniete);

                Console.Write("Zgadnij litere: ");
                char litera = Console.ReadLine()[0];
                bool trafnie = false;

                for (int i = 0; i < haslo.Length; i++)
                {
                    if (haslo[i] == litera)
                    {
                        zgadniete[i] = litera;
                        trafnie = true;
                        
                    }
                }
                if (trafnie == false)
                {
                    Console.WriteLine("Zle!");
                    szanse--;
                }
            }
            if (szanse == 0)
            {
                Console.WriteLine("Przegrales !!! haslo do odgadniecia to bylo : {0}", haslo);
            }
            else
            {
                Console.WriteLine("Udalo Ci sie !!");
            }
            Console.WriteLine("To slowo to bylo {0} ", haslo);
            Console.ReadLine();
            }
        }
    }
