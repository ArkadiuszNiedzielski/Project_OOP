using System;


namespace Projekt_OOP
{
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
}

