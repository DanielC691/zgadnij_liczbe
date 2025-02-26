using System;

namespace GraZgadnijLiczbe
{
    class Program
    {
        static void Main(string[] args)
        {
            bool grajPonownie = true;

            while (grajPonownie)
            {
                // Wyświetlenie prostego UI do rozpoczęcia gry
                Console.Clear();
                Console.WriteLine("*********************************");
                Console.WriteLine("* Witaj w grze 'Zgadnij Liczbę'! *");
                Console.WriteLine("*********************************");
                Console.WriteLine("Naciśnij dowolny klawisz, aby rozpocząć...");
                Console.ReadKey();

                // Losowanie tajnej liczby z zakresu 1 do 128
                Random random = new Random();
                int tajnaLiczba = random.Next(1, 129); // Next(min, max) - max jest wyłączone, więc 129 daje 1-128
                int liczbaProb = 0;
                bool odgadnieta = false;

                Console.Clear();
                Console.WriteLine("Komputer wylosował liczbę od 1 do 128.");
                Console.WriteLine("Spróbuj ją odgadnąć!");

                // Główna pętla gry
                while (!odgadnieta)
                {
                    Console.Write("\nPodaj swoją liczbę: ");
                    string input = Console.ReadLine();
                    int zgadywanaLiczba;

                    // Sprawdzenie, czy użytkownik podał poprawną liczbę
                    if (!int.TryParse(input, out zgadywanaLiczba))
                    {
                        Console.WriteLine("To nie jest poprawna liczba. Spróbuj ponownie.");
                        continue;
                    }

                    liczbaProb++;

                    if (zgadywanaLiczba < tajnaLiczba)
                    {
                        Console.WriteLine("Twoja liczba jest za mała!");
                    }
                    else if (zgadywanaLiczba > tajnaLiczba)
                    {
                        Console.WriteLine("Twoja liczba jest za duża!");
                    }
                    else
                    {
                        Console.WriteLine("\nGratulacje! Odgadłeś liczbę!");
                        Console.WriteLine("Liczba prób: " + liczbaProb);
                        odgadnieta = true;
                    }
                }

                // Opcja zakończenia gry lub rozpoczęcia nowej
                Console.WriteLine("\nCzy chcesz zagrać ponownie? (T/N)");
                string odpowiedz = Console.ReadLine().Trim().ToLower();

                if (odpowiedz == "t" || odpowiedz == "tak")
                {
                    grajPonownie = true;
                }
                else
                {
                    grajPonownie = false;
                }
            }

            Console.WriteLine("\nDzięki za grę! Naciśnij dowolny klawisz, aby zakończyć...");
            Console.ReadKey();
        }
    }
}