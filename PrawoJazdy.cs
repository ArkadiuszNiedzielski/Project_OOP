using System;


namespace Projekt_OOP
{
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
}

