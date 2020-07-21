using System;

namespace ULF
{
  public class Materiae
  {
    public Materiae(string mat="", double den=1, double ca=1, string cal="", int tol=0){
      this.Nomen = mat;
      this.Densitas = den;
      this.Calefacio = ca;
      this.Calfacio = cal;
      this.Toleratio = tol;
    }

    public Materiae Tributare(string mat=""){
      Materiae Water = new Materiae("Water", 1.0, 100, "The molecules of this freezing water jump to the vapor of a boil. To do that to this entire things takes:");
      Materiae Dirt = new Materiae("Dirt", 1.22, 800, "Gases are released and the minerals lefts start to liquify melting down. To do that to this entire things takes:");
      Materiae Limestone = new Materiae("Limestone", 2.5, 825, "Well before melting limestone decomposes into calcium carbonate at 825C. To do that to this entire things takes:");
      Materiae Oxygen = new Materiae("Oxygen", 0.001293, 0, "This cannot be oxidated further.");
      Materiae Oak = new Materiae("Oak", 0.8, 3561.18, "This cannot be molten, unless at some special circunstances on vacuum, but it will oxidize if heated to 300C. The energy returned from the perfect burn of it would be:", 50);
      Materiae Iron = new Materiae("Iron", 7.870, 1500, "The dark red incandescent metal boils dangerous as on medieval hellforges. To do that to this entire things takes:");
      Materiae Steel = new Materiae("Steel", 7.80, 1540, "The hard monstrosity from iron melts down like any other material. To do that to this entire things takes:", 120);
      Materiae Gold = new Materiae("Gold", 19.320, 1063, "Even as liquid it shines beautifuly on its incandescence. To do that to this entire things takes:");
      Materiae Osmium = new Materiae("Osmium", 22.57, 3033, "Heavy on its density and resistant on its solid bonding, but even then it starts melting down. To do that to this entire things takes:");
      Materiae Lead = new Materiae("Lead", 11.3, 328, "Surprisingly easily it starts to lose form and drip down. To do that to this entire things takes:");
      Materiae Ice = new Materiae("Ice", 1, 100, "The stable molecules of this solid water jump to vapor. To do that to this entire things takes:");
      Materiae Maple = new Materiae("Maple", 0.68, 3561.18, "This cannot be molten, unless at some special circunstances on vacuum, but it will oxidize if heated to 300C. The energy returned from the perfect burn of it would be:", 50);
      Materiae Chestnut = new Materiae("Chestnut", 0.56, 3561.18, "This cannot be molten, unless at some special circunstances on vacuum, but it will oxidize if heated to 300C. The energy returned from the perfect burn of it would be:", 50);
 
      Materiae Unknown = new Materiae("Unknown", 1, 1, "");

      mat=mat.ToLower();
      switch(mat){
        case "water":
          return Water;
        case "dirt":
          return Dirt;
        case "limestone":
          return Limestone;
        case "oxygen":
          return Oxygen;
        case "oak":
          return Oak;
        case "iron":
          return Iron;
        case "steel":
          return Steel;
        case "gold":
          return Gold;
        case "osmium":
          return Osmium;
        case "lead":
          return Lead;
        case "ice":
          return Ice;
        case "maple":
          return Maple;
        case "chestnut":
          return Chestnut;
        default:
          return Unknown;
      }
    }
    public string Nomen{get; set;}
    public double Densitas{get; set;}
    public double Calefacio{get; set;}
    public string Calfacio{get; set;}
    public int Toleratio{get; set;}

    public void Index(){
      Console.WriteLine($"\n{this.Nomen}\n{this.Densitas}cm³\n{this.Calefacio}°C");
    }
  }
}