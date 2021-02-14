using System;
using System.Collections;

// coś tam coś tam
namespace Projekt_OOP
{

    abstract class Dokument
    {
        protected string imie, nazwisko, dataur;
        protected string pesel;
        public Dokument(string imie, string nazwisko, string dataur, string pesel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.dataur = dataur;
            this.pesel = pesel;

        }
        public virtual void wyswietl()
        {
            Console.WriteLine(imie);
            Console.WriteLine(nazwisko);
            Console.WriteLine(dataur);
            Console.WriteLine(pesel);
        }
        public string wNazwisko()       //getter
        {
            return this.nazwisko;
        }

    }

    class UprawnieniaUDT : Dokument
    {
        private string nr_zaswiadczenia;
        private string zakres_uprawnien;
        public UprawnieniaUDT(string imie, string nazwisko, string dataur, string pesel, string nr_zaswiadczenia, string zakres_uprawnien) : base(imie, nazwisko, dataur, pesel)
        {
            this.nr_zaswiadczenia = nr_zaswiadczenia;
            this.zakres_uprawnien = zakres_uprawnien;
        }
        public override void wyswietl()
        {
            base.wyswietl();
            Console.WriteLine(nr_zaswiadczenia);
            Console.WriteLine(zakres_uprawnien);
        }
    }
    class KartaNFZ : Dokument
    {
        private uint id_karty;
        public KartaNFZ(string imie, string nazwisko, string dataur, string pesel, uint id_karty) : base(imie, nazwisko, dataur, pesel)
        {
            this.id_karty = id_karty;
        }
        public override void wyswietl()
        {
            base.wyswietl();
            Console.WriteLine(id_karty);
        }

    }

    class Paszport : Dokument
    {
        protected char plec;
        protected string organ_wydajacy, drugie_imie, nr_dokumentu;
        public Paszport(char plec, string imie, string drugie_imie, string nazwisko, string dataur, string pesel, string organ_wydajacy, string nr_dokumentu) : base(imie, nazwisko, dataur, pesel)
        {
            this.plec = plec;
            this.drugie_imie = drugie_imie;
            this.organ_wydajacy = organ_wydajacy;
            this.nr_dokumentu = nr_dokumentu;

        }

        public override void wyswietl()
        {
            Console.WriteLine(plec);
            Console.WriteLine(imie);
            Console.WriteLine(drugie_imie);
            Console.WriteLine(nazwisko);
            Console.WriteLine(dataur);
            Console.WriteLine(pesel);
            Console.WriteLine(organ_wydajacy);
            Console.WriteLine(nr_dokumentu);
           
        }
    }

    class Dowod : Paszport
    {
        private string imie_matki, imie_ojca;
        public Dowod(char plec, string imie, string drugie_imie, string nazwisko, string dataur, string pesel, string imie_matki, string imie_ojca, string organ_wydajacy, string nr_dokumentu) : base(plec, imie, drugie_imie, nazwisko, dataur, pesel, organ_wydajacy, nr_dokumentu)
        {
            this.imie_matki = imie_matki;
            this.imie_ojca = imie_ojca;
        }
        public override void wyswietl()
        {
            Console.WriteLine(plec);
            Console.WriteLine(imie);
            Console.WriteLine(drugie_imie);
            Console.WriteLine(nazwisko);
            Console.WriteLine(dataur);
            Console.WriteLine(pesel);
            Console.WriteLine(imie_matki);
            Console.WriteLine(imie_ojca);
            Console.WriteLine(organ_wydajacy);
            Console.WriteLine(nr_dokumentu);
          

        }
    }
    class PrawoJazdy : Paszport
    {
        private string kategoria;

        public PrawoJazdy(char plec, string imie, string drugie_imie, string nazwisko, string dataur, string pesel, string organ_wydajacy, string nr_dokumentu, string kategoria) : base(plec, imie, drugie_imie, nazwisko, dataur, pesel, organ_wydajacy, nr_dokumentu)
        {
            this.kategoria = kategoria;
        }
        public override void wyswietl()
        {

            Console.WriteLine(plec);
            Console.WriteLine(imie);
            Console.WriteLine(drugie_imie);
            Console.WriteLine(nazwisko);
            Console.WriteLine(dataur);
            Console.WriteLine(pesel);
            Console.WriteLine(organ_wydajacy);
            Console.WriteLine(nr_dokumentu);
            Console.WriteLine(kategoria);
        }
    }


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

