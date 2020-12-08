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
    public string Conditio{get; protected set;}
    public Materiae Materia = new Materiae();
    public string Fractum;

    public Caussae(string nom="", string dep="", string typ="", double pon=0, double pre=0, int val=0, int qua=1, string con="", string fra=""){
      this.Nomen=nom;
      this.Depictium=dep;
      this.Typus=typ;
      this.Pondus=pon;
      this.Pretium=pre;
      this.Quantitas=qua;
      this.Value=val;
      this.Conditio=con;
      this.Fractum=fra;
    }

    public static Caussae Acquirere(string mat="", int qua=1){
      Caussae TeakLog1p36 = new Caussae("Teak Log", "A 100 per 36 log of teak", "log", 65, 3.2, 0, qua);
      Caussae ChestnutLog1p36 = new Caussae("Chestnut Log", "A 100 per 36 log of chestnut", "log", 68, 3.8, 0, qua);
      Caussae MapleLog1p36 = new Caussae("Maple Log", "A delicate 100 per 36 log of maple", "log", 50, 4.2, 0, qua);
      Caussae TeakPlank1p3 = new Caussae("Teak Plank", "A 100 per 3 plank of teak", "plank", 5.4, 0.35, 0, qua);
      Caussae ChestnutPlank1p3 = new Caussae("Chestnut Plank", "A 100 per 3 plank of chestnut", "plank", 5.6, 0.4, 0, qua);
      Caussae MaplePlank1p3 = new Caussae("Maple Plank", "A delicate 100 per 3 plank of maple", "plank", 4.1, 0.5, 0, qua);
      Caussae TeakSplinter = new Caussae("Teak Splinter", "A splinter of teak", "plank", 0.18, 0.01, 0, qua);
      Caussae ChestnutSplinter = new Caussae("Chestnut Splinter", "A splinter of chestnut", "plank", 0.188, 0.01, 0, qua);
      Caussae MapleSplinter = new Caussae("Maple Splinter", "A splinter of maple", "plank", 0.138, 0.01, 0, qua);

      Caussae LightArrow = new Caussae("Light Arrow", "A wooden arrow.", "arrow", 0.025, 0.1, 4, qua);
      Caussae HeavyArrow = new Caussae("Heavy Arrow", "An heavy arrow.", "arrow", 0.040, 0.15, 6, qua);

      Caussae HumanSkin = new Caussae("Human Skin", "The skin of a higher primate.", "ressource", 0.1, 0.1, 0, qua, "hunter1");
      Caussae LeatherStrap = new Caussae("Leather Strap", "Strap of commom leather", "ressource", 0.1, 0.5, 0, qua, "cobbler1");

      Caussae DGoatLeatherHemelt = new Caussae("Damaged Goat Leather Helmet", "A damaged helmet of goat leather", "ressource", 0.5, 0.1, 4, qua);
      
      mat=mat.ToLower();
      switch(mat){
        case "teak log":return TeakLog1p36;
        case "chestnut log":return ChestnutLog1p36;
        case "maple log":return MapleLog1p36;
        case "teak plank":return TeakPlank1p3;
        case "chestnut plank":return ChestnutPlank1p3;
        case "maple plank":return MaplePlank1p3;
        case "teak splinter":return TeakSplinter;
        case "chestnut splinter":return ChestnutSplinter;
        case "maple splinter":return MapleSplinter;

        case "light arrow":return LightArrow;
        case "heavy arrow":return HeavyArrow;
        case "human skin":return HumanSkin;
        case "leather strap":return LeatherStrap;
        case "damaged goat leather helmet":return DGoatLeatherHemelt;
        default:
          if(Arma.Ornare(mat)!=null){
            return Arma.Ornare(mat);
          }
          if(Galea.Ornare(mat)!=null){
            return Galea.Ornare(mat);
          }
          return null;
      }
    }

    public virtual void Index(){
      Console.WriteLine($"\n{this.Nomen}\n{this.Depictium}\nWeith: {this.Pondus}Kg\nPrice: {this.Pretium}C");  
    }
  }
}