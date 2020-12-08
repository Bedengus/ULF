using System;
using System.Collections.Generic;
using System.Windows;
using System.Threading;
using System.Threading.Tasks;
// using System.Windows.Navigation;
using System.Numerics;

// ctrl + ; for comment, dotnet run for terminal

// mechanic of friction energy converted to heat damage to weapon and target
// mechanic of activating the buff as passive on and off

// 'pray to Azure so that may the Winged Lotus guide your way'; and so goes to the Ochre class and
// teaches all mechanics of weapon dice x speed by graciosity and strength and heat, and all mechanics of combat
// or talk to the Queen about all ways of the world

// 'omni' static class with a 'babylon' method void acc string; every text displayed is cast as a variable
// then they are all there and assigned to the desired language by a if or switch on the babylon method; and so it is translation ready

namespace ULF
{
	public class Primor
	{
		public static Persona homo = new Persona();
    public static Dictionary<string, Persona> Hostis = new Dictionary<string, Persona>();

    [STAThread]
    public static void Main()
		{
      Console.Title="Ultimate Legendary Fantasy";
      Origo();
			Console.WriteLine("Salve Mundus!\n");

      /*homo.Intro();

      Console.WriteLine(Adventum.aux);
      Console.ReadLine();
      homo.Regio.Iter("129800", "Emerald Village", homo);*/

      // /*

      // Mechanicae.Artificium();

      // Materiae.Mass();

      homo.Porto("Su");
      homo.Regio.Iter(homo.regreg[0], homo.regreg[1], homo);
      
      /*homo.Arma=Arma.Ornare("Caelum Fractum");
      Adventum.Bellum(homo, true, Hostis["Bandit"]);*/
      
      // Mechanicae.Momentum(homo, 25, 0);
      // homo.Regio.Iter("128800", "Emerald Village", homo);

      // */

      Console.ReadLine(); 
		}

    public static void Learner(Persona Ego, string typ="", string nom=""){
      if(typ==""){
        Console.WriteLine("What do you wish to learn?\n1>Proffession\n2>Mastery\n3>Spell\n4>Skill\n5>Buff");
        Σ.notou = Console.ReadLine();
        Console.WriteLine("Name it.");
        Σ.notod = Console.ReadLine();
      } else{
        Σ.notou = typ;
        Σ.notod = nom;
      }
      
      switch(Σ.notou){
        case "1":
          Ego.AddicioM(nom);
          break;
        case "2":
          Ego.AddicioM(nom, verbum:"peritia");
          break;
        case "3":
          Ego.Addicio("repertoire", nom);
          break;
        case "4":
          Ego.Addicio(nom);
          break;
        case "5":
          Ego.AddicioB(nom);
          break;
        default:
          
          break;
      }
    }
    public static void Origo(){
      Hostis["Bandit"] = new Persona();
      Hostis["Bandit"].Nomen = "Bandit";
      Hostis["Bandit"].Cognomen = "Bandit";
      Hostis["Bandit"].Genus.Auto("human", Hostis["Bandit"].Nomen);
      Hostis["Bandit"].Arma = Arma.Ornare("steel sword");
      Hostis["Bandit"].Actus[2]="Slash";
      Hostis["Bandit"].Actus[1]="Strike";
      Hostis["Bandit"].Actus[3]="Thrust";
      Hostis["Bandit"].Actus[0]="Step";
      Hostis["Bandit"].Actus[4]="Wait";
      Hostis["Bandit"].Lotus.X=100;
      Hostis["Bandit"].Lotus.Y=100;
      Hostis["Bandit"].PV[1]=10;
      Hostis["Bandit"].panaN["Human Skin"]=5;
      foreach(var u in Hostis["Bandit"].panaN){
        Hostis["Bandit"].Archivum[0]=Caussae.Acquirere(u.Key, u.Value);
      }
      Hostis["Bandit"].Galea=Galea.Ornare("Goat Leather Helmet");

      Hostis["Boar"] = new Persona();
      Hostis["Boar"].Nomen = "Boar";
      Hostis["Boar"].Cognomen = "Boar";
      Hostis["Boar"].Genus.Auto("quadrupod", Hostis["Boar"].Nomen);
      Hostis["Boar"].Arma = Arma.Ornare("steel sword");
      Hostis["Boar"].Actus[1]="Strike";
      Hostis["Boar"].Actus[0]="Step";
      Hostis["Boar"].Lotus.X=50;
      Hostis["Boar"].Lotus.Y=50;
      Hostis["Boar"].panaN["Human Skin"]=5;
      foreach(var u in Hostis["Boar"].panaN){
        Hostis["Boar"].Archivum[0]=Caussae.Acquirere(u.Key, u.Value);
      }

      Hostis["h"] = new Persona();
      Hostis["h"].Nomen = "h";
      Hostis["h"].Cognomen = "h";
      Hostis["h"].Genus.Auto("human", Hostis["h"].Nomen);
      Hostis["h"].Arma = Arma.Ornare("steel sword");
      Hostis["h"].Actus[2]="Slash";
      Hostis["h"].Actus[1]="Strike";
      Hostis["h"].Actus[3]="Thrust";
      Hostis["h"].Actus[0]="Step";
      Hostis["h"].Actus[4]="Wait";
      Hostis["h"].Lotus.X=100;
      Hostis["h"].Lotus.Y=100;
      Hostis["h"].PV[1]=10;

      Hostis["j"] = new Persona();
      Hostis["j"].Nomen = "j";
      Hostis["j"].Cognomen = "j";
      Hostis["j"].Genus.Auto("human", Hostis["j"].Nomen);
      Hostis["j"].Arma = Arma.Ornare("steel sword");
      Hostis["j"].Actus[2]="Slash";
      Hostis["j"].Actus[1]="Strike";
      Hostis["j"].Actus[3]="Thrust";
      Hostis["j"].Actus[0]="Step";
      Hostis["j"].Actus[4]="Wait";
      Hostis["j"].Lotus.X=10;
      Hostis["j"].Lotus.Y=10;
      Hostis["j"].PV[1]=10;
    }
    public static void Telechargere(){
      Arma.Ornare("Steel Sword").Salvare();
      Arma.Ornare("Steel Long Sword").Salvare();
      Arma.Ornare("Steel Dagger").Salvare();
      Arma.Ornare("Chestnut Staff").Salvare();
      Arma.Ornare("Maple Bow").Salvare();
    }
  }
}

/*Console.WriteLine("Run in 'c'onsole or window?");
      Σ.rector=Console.ReadLine().ToLower();

      if(Σ.rector=="c"){

      } else{
        App oc = new App();
        OC occ = new OC();
        Task(()=>oc.Run(occ));
        Environment.Exit(0);
      }*/