using System;

namespace deel3
{
  public interface IKoffie
  {
    void stap1();
    void stap2();
    void stap3();
    void stap4();
    void stap5();
    void stap6();

    Koffie GetKoffie();
  }

  public class EspressoBrewer : IKoffie
  {
    private Koffie _koffie = new Koffie();

    public void stap1() {
      _koffie.stap1 = "Verwarm water, en laat het even staan om een temperatuur van ongeveer 90 graden te krijgen.";
    }

    public void stap2() {
      _koffie.stap2 = "Plaats een koffiefilter in het koffiezetapparaat.";
    }

    public void stap3() {
      _koffie.stap3 = "Voor een liter gebruik je ongeveer 6 a 7 schepjes. Hoeveel schepjes je zelf lekker vindt zal per persoon verschillen, dit wordt dus gewoon proberen.";
    }

    public void stap4() {
      _koffie.stap4 = "Voeg wat water toe, zodat de koffie nat wordt";
    }

    public void stap5(){
      _koffie.stap5 = "Wacht een paar seconden, en giet vervolgens de rest van het water door de koffie.";
    }

    public void stap6(){
      _koffie.stap6 = "Giet de koffie over in een mok.";
    }

    public Koffie GetKoffie() {
      return _koffie;
    }
  }

  public class Koffie
  {
    public string stap1 {get; set;}
    public string stap2 {get; set;}
    public string stap3 {get; set;}
    public string stap4 {get; set;}
    public string stap5 {get; set;}
    public string stap6 {get; set;}



    public void ShowSteps()
    {
      Console.WriteLine("Stap 1: {0}", stap1);
      Console.WriteLine("Stap 2: {0}", stap2);
      Console.WriteLine("Stap 3: {0}", stap3);
      Console.WriteLine("Stap 4: {0}", stap4);
      Console.WriteLine("Stap 5: {0}", stap5);
      Console.WriteLine("Stap 6: {0}", stap6);
    }
  }
}