using System;


namespace Projekt_OOP
{
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
}

