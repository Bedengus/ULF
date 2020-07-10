using System;

namespace ULF
{
  public class Caussae
  {
    public string Nomen{get; protected set;}
    public string Depictium{get; private set;}
    public string Typus{get; protected set;}
    public double Pondus{get; protected set;}
    public double Pretium{get; protected set;}
    public int Quantitas{get; set;}
    public int Value{get; private set;}

    public Caussae(string nom="", string dep="", string typ="", double pon=0, double pre=0, int val=0, int qua=1){
      this.Nomen=nom;
      this.Depictium=dep;
      this.Typus=typ;
      this.Pondus=pon;
      this.Pretium=pre;
      this.Quantitas=qua;
      this.Value=val;

    }

    public static Caussae Acquirere(string mat="", int qua=1){
      Caussae LightArrow = new Caussae("Light Arrow", "A wooden arrow.", "arrow", 0.025, 0.1, 4, qua);
      Caussae HeavyArrow = new Caussae("Heavy Arrow", "An heavy arrow.", "arrow", 0.040, 0.15, 6, qua);
      
      mat=mat.ToLower();
      switch(mat){
        case "light arrow":
          return LightArrow;
        case "heavy arrow":
          return HeavyArrow;
        case "steel daggerkk":
          return null;
        case "chestnut staffkk":
          return null;
        case "maple bowkk":
          return null;
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
          if(Arma.Ornare(mat)!=null){
            return Arma.Ornare(mat);
          }
          return null;
      }
    }
    /*
    Light Arrow.
Penetration: 1d4
Weight: 0.025Kg
Material: Maple/Iron
Price: 0.1C
Durability: 5

Heavy Arrow.
Penetration: 1d6
Weight: 0.040Kg
Material: Maple/Iron
Price: 0.15C
Durability: 5

    */
  }
}