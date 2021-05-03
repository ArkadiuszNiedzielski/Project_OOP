using System;

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