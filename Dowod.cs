using System;


namespace Projekt_OOP
{
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
}

