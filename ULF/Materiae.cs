using System;
using System.Numerics;

namespace ULF
{
  public class Materiae
  {
    // public double mole = 602*Math.Pow(10, 23); //602000000000000000000000
    // public double duallight = 8.988*Math.Pow(10, 16); // 89000000000000000
    public Materiae(string mat="", string gen="", double den=1, double ca=1, double caa=1, string cal="", int tol=0){
      this.Nomen = mat;
      this.Genus=gen;
      this.Densitas = den;
      this.Calefacio[0] = ca;
      this.Calefacio[1] = caa;
      this.Calfacio = cal;
      this.Toleratio = tol;
    }

    public Materiae Tributare(string mat=""){
      Materiae Water = new Materiae("Water", "Water", 1.0, 100, 0, "The molecules of this freezing water jump to the vapor of a boil. To do that to this entire things takes:");
      Materiae Dirt = new Materiae("Dirt", "Mineral", 1.22, 800, 0, "Gases are released and the minerals lefts start to liquify melting down. To do that to this entire things takes:");
      Materiae Limestone = new Materiae("Limestone", "Mineral", 2.5, 825, 0, "Well before melting limestone decomposes into calcium carbonate at 825C. To do that to this entire things takes:");
      Materiae Oxygen = new Materiae("Oxygen", "Gas", 0.001293, 0, 0, "This cannot be oxidated further.");
      Materiae Oak = new Materiae("Oak", "Wood", 0.8, 300, 3561.18, "This cannot be molten, unless at some special circunstances on vacuum, but it will oxidize if heated to 300C and burn at 800C. The energy returned from the perfect burn of it would be:", 50);
      Materiae Iron = new Materiae("Iron", "Metal", 7.870, 1500, 0, "The dark red incandescent metal boils dangerous as on medieval hellforges. To do that to this entire things takes:");
      Materiae Steel = new Materiae("Steel", "Metal", 7.80, 1540, 0, "The hard monstrosity from iron melts down like any other material. To do that to this entire things takes:", 120);
      Materiae Gold = new Materiae("Gold", "Metal", 19.320, 1063, 0, "Even as liquid it shines beautifuly on its incandescence. To do that to this entire things takes:");
      Materiae Osmium = new Materiae("Osmium", "Metal", 22.57, 3033, 0, "Heavy on its density and resistant on its solid bonding, but even then it starts melting down. To do that to this entire things takes:");
      Materiae Lead = new Materiae("Lead", "Metal", 11.3, 328, 0, "Surprisingly easily it starts to lose form and drip down. To do that to this entire things takes:");
      Materiae Ice = new Materiae("Ice", "Water", 1, 100, 0, "The stable molecules of this solid water jump to vapor. To do that to this entire things takes:");
      Materiae Maple = new Materiae("Maple", "Wood", 0.68, 300, 3561.18, "This cannot be molten, unless at some special circunstances on vacuum, but it will oxidize if heated to 300C and burn at 800C. The energy returned from the perfect burn of it would be:", 50);
      Materiae Chestnut = new Materiae("Chestnut", "Wood", 0.56, 300, 3561.18, "This cannot be molten, unless at some special circunstances on vacuum, but it will oxidize if heated to 300C and burn at 800C. The energy returned from the perfect burn of it would be:", 50);
      Materiae Cotton = new Materiae("Cotton", "Wood", 0.08, 100, 1300, "This cannot be molten, unless at some special circunstances on vacuum, but it will oxidize easily and burn weakly. The energy returned from the perfect burn of it would be:", 2);
        Materiae CottonFabric = new Materiae("Cotton Fabric", "Fabric", 0.45, 300, 1300, "It burns.", 10);
      Materiae Leather = new Materiae ("Leather", "Leather", 0.86, 500, 1500, "This cannot be molten, unless at some special circunstances on vacuum, but it will oxidize if heated enough. The energy returned from the perfect burn of it would be:", 10);
      Materiae AzurianSteel = new Materiae("Azurian Steel", "Metal", 7.77, 30000, 0, "You just melted it? Master artesans look in awe from the afterlife.", 7777777);

      Materiae Unknown = new Materiae("Unknown", "Unknown");

      mat=mat.ToLower();
      switch(mat){
        case "water":return Water;
        case "dirt":return Dirt; 
        case "limestone":return Limestone;
        case "oxygen":return Oxygen;
        case "oak":return Oak;
        case "iron":return Iron;
        case "steel":return Steel;
        case "gold":return Gold;
        case "osmium":return Osmium;
        case "lead":return Lead;
        case "ice":return Ice;
        case "maple":return Maple;
        case "chestnut":return Chestnut;
        case "cotton":return Cotton;
        case "cotton fabric":return CottonFabric;
        case "leather":return Leather;
        case "azurian steel":return AzurianSteel;
        default:return Unknown;
      }
    }
    public string Nomen{get; set;}
    public string Genus{get; set;}
    public double Densitas{get; set;}
    public double[] Calefacio = new double[2];
    public string Calfacio{get; set;}
    public int Toleratio{get; set;}

    public void Index(){
      Console.WriteLine($"\n{this.Nomen}\n{this.Densitas}cm³\n{this.Calefacio}°C");
    }
  
    public static void Mass(){
      double[] protons = new double[3];
      double[] neutrons = new double[3];
      double daltonMeV = 931.49410242;
      double MeVtoPicJ = 0.160218;

      double[] total = new double[10];

      protons[0]=1.00728;
      neutrons[0]=1.00867;
      Console.WriteLine("Insert protons.");
      protons[1] = double.Parse(Console.ReadLine());
      Console.WriteLine("Insert neutrons.");
      neutrons[1] = double.Parse(Console.ReadLine());
      protons[2]=protons[0]*protons[1];
      neutrons[2]=neutrons[0]*neutrons[1];
      total[0] = protons[2]+neutrons[2];
      total[1]=daltonMeV*total[0];
      Console.WriteLine("\nThat is Fe52.");
      Console.WriteLine("\nYou have "+protons[1]+" protons for a mass of "+protons[2]+" and "+neutrons[1]+" neutrons for a mass of "+neutrons[2]+".");
      Console.WriteLine("For a total of "+total[0]+" atomic mass; or "+total[1]+" MeV.");
      double Fe52=51.948114;
      // double Pd104=103.904036;
      // double Pd108=107.903892;
      // double U216=216.024760;
      total[2]=total[0]-Fe52;
      total[3]=total[2]*daltonMeV;
      total[4]=total[3]*MeVtoPicJ;
      Console.WriteLine("The actual mass of Fe52 is "+Fe52+" and so the defect is "+total[2]+" of mass or "+total[3]+" MeV.");
      Console.WriteLine(total[4]+" Picojoules.");
      total[5]=protons[1]+neutrons[1];
      total[6]=total[3]/total[5];
      Console.WriteLine("\nThat is a binding energy, a released mass, of "+total[6]+" MeV per nucleon.");
    }
  }
}

/*public void Atomus(string ele){
      BigInteger mole = new BigInteger(6.0221407);
      mole=mole*BigInteger.Pow(10, 23);

      double H=1.00794;
      double He=4.002602;
      double Li=6.941;
      double Be=9.012182;
      double B=10.811;
      double C=12.0107;
      double N=14.0067;
      double O=15.9994;
      double F=18.9984032;
      double Ne=20.1797;
      double Na=22.98976928;
      double Mg=24.3050;
      double Al=26.9815386;
      double Si=28.0855;
      double P=30.973762;
      double S=32.065;
      double Cl=35.453;
      double Ar=39.948;
      double K=39.0983;
      double Ca=40.078;
      double Sc=44.955912;
      double Ti=47.867;
      double V=50.9415;
      double Cr=51.9961;
      double Mn=54.938045;
      double Fe=55.845;
      double Co=58.933195;
      double Ni=58.6934;

      // The isopodes must be taken into account and the binding energy and mass defect to properly give results

      Console.WriteLine("Inform the element.");
      // code switch
      BigInteger el=new BigInteger(H);
      Console.WriteLine("Inform the weight.");
      BigInteger weight=new BigInteger();
      weight=BigInteger.Parse(Console.ReadLine());
      BigInteger count=new BigInteger();
      count=weight/el;
      count=count*mole;
      Console.WriteLine("There are "+count+" atoms in that.");

      
      Console.WriteLine("What would you like to fuse?");
      // switch code
      Console.WriteLine("Fuse in what?");
      // switch code
      Console.WriteLine("That generates xxx energy. In joules it is...");
    }*/
    /*4H > 1He = 26 MeV
      2He > 1Be = -0.0918 MeV (51.9192)
      1Be + 1He > 1C(2y) = 7.367 MeV (59,2862)
      TriA = 7.275 MeV (59,2862)
      1C + 1He > 1O(y) = 7.16 MeV (92,4462)85,2862
      1O + 1He > 1Ne(y) = 4.73 MeV (123,1762)111,2862
      1Ne + 1He > 1Mg(y) = 9.32 MeV (158,4962)137,2862
      1Mg + 1He > 1Si(y) = 9.98 MeV (194,4762)163,2862
      1Si + 1He > 1S(y) = 6.95 MeV (227,4262)189,2862
      1S + 1He > 1Ar(y) = 6.64 MeV (260,0662)215,2862
      1Ar + 1He > 1Ca(y) = 7.04 MeV (293,1062)241,2862
      1Ca + 1He > 1Ti(y) = 5.13 MeV (324,2362)267,2862
      1Ti + 1He > 1Cr(y) = 7.70 MeV (357,9362)293,2862
      1Cr + 1He > 1Fe(y) = 7.94 MeV (391,8762)319,2862
      1Fe + 1He > 1Ni(y) = 8.00 MeV (425,8762)345,2862
      AlLa = 391.8762 52H(Fe) or 425.8762 56H(Ni)
      */

/*double mike = 9999999999999999999;
      mike=Math.Pow(mike,10);
      double kk=mike/1000;
      double mm=kk/1000;
      double gg=mm/1000;
      double tt=gg/1000;
      double pp=tt/1000;
      double xx=pp/1000;
      double zz=xx/1000;
      double yy=zz/1000;
      Console.WriteLine(mike+"\n"+kk+"\n"+mm+"\n"+gg+"\n"+tt+"\n"+pp+"\n"+xx+"\n"+zz+"\n"+yy+"\n");
      BigInteger lager = new BigInteger(9999999999999999999);
      lager=BigInteger.Pow(lager, 10);
      Console.WriteLine(lager);*/