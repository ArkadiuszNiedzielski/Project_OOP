using System;

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