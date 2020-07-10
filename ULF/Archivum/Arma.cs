using System;

namespace ULF
{
  public class Arma : Caussae
  {
    public Materiae Materia = new Materiae();
    public string Peritia{get; private set;}
    public int Acutus{get; private set;}
    public int Acutulus{get; private set;}
    public int Obtusus{get; private set;}
    public int DamnumT{get; private set;}
    public double Spatium{get; private set;}
    public double Toleratio{get; private set;}
    public int Deficio{get; private set;}
  
    public Arma(string nom="", string mat="", string typ="hand", int Dtyp=0, int tus=4, int lus=4, int sus=4, double pon=1, double pre=1, double spa=0, double tol=1, string pe="", int def=0){
      Materia = Materia.Tributare(mat);

      this.Nomen = nom;

      this.Acutus = tus;
      this.Acutulus = lus;
      this.Obtusus = sus;
      this.Typus = typ;

      this.Pondus = pon;
      this.Pretium = pre;
      this.Spatium = spa;
      this.Toleratio = Math.Round(Materia.Toleratio * tol);
      this.Deficio=def;
      Damnum(Dtyp);
    }

    public void Damnum(int typ){
      switch(typ){
        case 0:
          this.DamnumT = this.Obtusus;
          break;
        case 1:
          this.DamnumT = this.Acutus;
          break;
        case 2:
          this.DamnumT = this.Acutulus;
          break;
        default:
        this.DamnumT = typ;
          break;
      }
    }

    public static Arma Ornare(string mat=""){
      Arma SteelSword = new Arma("Steel Sword" ,"steel", "sword", 1, 6, 4, 1, 0.8, 12, 60, 1, "Blade Proficiency");
      Arma SteelLongSword = new Arma("Steel Long Sword" ,"steel", "sword", 1, 8, 4, 1, 1.5, 15, 110, 1, "Blade Proficiency");
      Arma SteelDagger = new Arma("Steel Dagger" ,"steel", "dagger", 2, 4, 4, 1, 0.1, 1, 10, 0.59, "Blade Proficiency");
      Arma ChestnutStaff = new Arma("Chestnut Staff" ,"chestnut", "staff", 0, 0, 0, 6, 0.5, 2, 70, 0.6, "");
      Arma MapleBow = new Arma("Maple Bow" ,"maple", "bow", 7, 0, 0, 1, 0.4, 3, 70, 0.4, "Bow Mastery");

      Arma Fist = new Arma("First", "flesh", "fist", 0, 0, 0, 4, 0, 0, 0, 1);

      mat=mat.ToLower();
      switch(mat){
        case "steel sword":
          return SteelSword;
        case "steel long sword":
          return SteelLongSword;
        case "steel dagger":
          return SteelDagger;
        case "chestnut staff":
          return ChestnutStaff;
        case "maple bow":
          return MapleBow;
        case "iron":
          // return Iron;
        case "steel":
          // return Steel;
        case "gold":
          // return Gold;
        case "osmium":
          // return Osmium;
        case "lead":
          // return Lead;
        case "ice":
          // return Ice;
        default:
          return null;
      }
    }   
  
    public void Index(){
      Console.WriteLine($"\n{this.Nomen}\n{this.Materia.Nomen}\nSharp: 1d{this.Acutus}\nPenetration: 1d{this.Acutulus}\nBlunt: 1d{this.Obtusus}\nWeith: {this.Pondus}Kg\nPrice: {this.Pretium}C\nReach: {this.Spatium}cm\nDurability: {this.Toleratio}");  
    }
  }
}