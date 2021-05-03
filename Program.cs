using System;
using System.Collections;


namespace Projekt_OOP
{


    class Program
    {
        public static void wybor(string x, ArrayList T)
        {
          
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Wprowadź następujące dane zatwierdzając każdą zmienną przyciskiem Enter:");
           
                switch (x)

                {
                    case "1":
                        Console.WriteLine("Imię, nazwisko, data urodzenia, pesel, nr. zaświadczenia, zakres uprawnień");
                        T.Add(new UprawnieniaUDT(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
                        break;
                    case "2":
                        Console.WriteLine("Imię, nazwisko, data urodzenia, pesel, id karty");
                        T.Add(new KartaNFZ(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), uint.Parse(Console.ReadLine())));
                        break;
                    case "3":
                        Console.WriteLine("Płeć(K/M), imie, drugie_imię, nazwisko, dataur, pesel, imię matki, imię ojca, organ_wydajacy, nr_dokumentu");
                        T.Add(new Dowod(char.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), (Console.ReadLine())));
                        break;

                    case "4":
                        Console.WriteLine("Płeć(K/M), imie, drugie_imię, nazwisko, dataur, pesel, organ_wydajacy, nr_dokumentu");
                        T.Add(new Paszport(char.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
                        break;
                    case "5":
                        Console.WriteLine("Płeć(K/M), imie, drugie_imię, nazwisko, dataur, pesel, organ_wydajacy, nr_dokumentu, kategoria");
                        T.Add(new PrawoJazdy(char.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
                        break;




                    default:
                        {
                            Console.WriteLine("Zły wybór. Kończę program");
                            Environment.Exit(0);
                            break;
                        }
                
            }
            
        }
        public static void wybor2(string x, ArrayList T)

        {
            Dokument pojemnik;

            switch (x)
            {
                case "1":
                    Console.WriteLine("---------------------------------------------------");
                    Console.WriteLine("Wprowadź 1, aby dodać do bazy uprawnienia UDT    /|");
                    Console.WriteLine("Wprowadź 2, aby dodać do bazy kartę NFZ          /|");
                    Console.WriteLine("Wprowadź 3, aby dodać do bazy dowód osobisty     /|");
                    Console.WriteLine("Wprowadź 4, aby dodać do bazy paszport           /|" );
                    Console.WriteLine("Wprowadź 5, aby dodać do bazy prawo jazdy        /|");
                    Console.WriteLine("___________________________________________________");


                    x = Console.ReadLine();
                    wybor(x, T);
                    T.TrimToSize();
                    break;
                case "2":
                    Console.WriteLine("usuwanie dokumentu, wprowadz indeks");
                    x = Console.ReadLine();
                    T.RemoveAt(int.Parse(x)); 
                    T.TrimToSize();
                    break;

                case "3":
                    Console.WriteLine("Wyszukanie po nazwisku");
                    Console.WriteLine("----------");
                    x = Console.ReadLine();
                    for (int i = 0; i < T.Capacity; i++)
                    {

                        pojemnik = (Dokument)T[i];
                        if (x.Equals(pojemnik.wNazwisko()))
                        {
                            Console.WriteLine("Nr indeksu w bazie:" + i);
                            pojemnik.wyswietl();
                        }
                    }
                    Console.WriteLine("----------");
                    break;
                case "4":
                    Console.WriteLine("Wyświetl Wszystkie");
                    for (int i = 0; i < (T.Capacity); i++)
                    {
                        Console.WriteLine("----------");
                        pojemnik = (Dokument)T[i];
                        Console.WriteLine("Nr indeksu w bazie:" + i);
                        pojemnik.wyswietl();
                        Console.WriteLine("----------");



                    }
                    break;
                case "5":
                    Console.WriteLine("Zakończ program");
                    break;
            }


        }

        static void Main(string[] args)
        {
           
            ArrayList T = new ArrayList();
            string p;

            do
            {
                Console.WriteLine("--------------------MENU--------------------");
                Console.WriteLine("Wprowadź 1, aby dodać Dokument            /|");
                Console.WriteLine("Wprowadź 2, aby usunąć dokument           /|");
                Console.WriteLine("Wprowadź 3, aby wyszukać po nazwisku      /|");
                Console.WriteLine("Wprowadź 4, aby wyswietlić wszystko       /|");
                Console.WriteLine("Wprowadź 5, aby zakończyć                 /|");
                Console.WriteLine("____________________________________________");
                p = Console.ReadLine();
                try
                {
                    if (int.Parse(p) > 5 || int.Parse(p) < 1)

                    {
                        Console.WriteLine("Zły wybór. Kończę program");
                        Environment.Exit(0);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Zły wybór. Kończę program");
                    Environment.Exit(0);
                }

                wybor2(p, T);

            } while (p != "5");
        }
    }
}

