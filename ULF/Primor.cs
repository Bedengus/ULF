using System;
using System.Collections.Generic;
using System.Windows;
// using System.Windows.Navigation;

// ctrl + ; for comment, dotnet run for terminal

namespace ULF
{
	public class Primor
	{
		public static Persona homo = new Persona();
    public static Dictionary<string, Persona> Hostis = new Dictionary<string, Persona>();

    [STAThread]
    public static void Main()
		{
			Console.WriteLine("Salve Mundus!\n");


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
      Hostis["Bandit"].Lotus[0]=100;
      Hostis["Bandit"].Lotus[1]=100;

      homo.Intro();

      Console.WriteLine(Adventum.aux);
      Console.ReadLine();
      homo.Regio.Iter(1, "Emerald Village", homo);

      /*homo.Intro();
      Adventum.Utor(homo);*/


      /*Hostis["Human"] = new Persona();
      Hostis["Human"].Nomen = "Human";
      Hostis["Human"].Cognomen = "Human";
      Hostis["Human"].Genus.Auto("human", Hostis["Human"].Nomen);*/

      



      // homo.Utor();
      // homo.Porto("Su");

      // homo.Spectare();


      /*homo.ArchAdd(Caussae.Acquirere("Maple Bow"));
      homo.Arma=Arma.Ornare("Maple Bow");
      homo.Addicio("actus", "Shoot");

      homo.Spectare();

      Mechanicae.Chronus(homo, Hostis["h"]);*/


      /*homo.ArchAdd(Caussae.Acquirere("Light Arrow"), Caussae.Acquirere("Chestnut Staff"));
      homo.Salvare();*/
    

      Hostis[homo.Cognomen] = new Persona();
      Hostis[homo.Cognomen] = homo;


      /*Console.WriteLine(Adventum.aux);
      Console.ReadLine();
      homo.Regio.Iter(1, "Emerald Village", homo);*/

      // Mechanicae.Chronus(homo, Hostis["h"]);

      /*Actus.Gestus("Cast", homo);
      Actus.Ergo("Cast", homo);*/



      

      /*Hostis["j"] = new Persona();
      Hostis["j"].Nomen = "j";
      Hostis["j"].Cognomen = "j";
      Hostis["j"].Genus.Auto("human", Hostis["j"].Nomen);
      Hostis["j"].Arma = Arma.Ornare("steel sword");
      Hostis["j"].Actus[2]="Slash";
      Hostis["j"].Actus[1]="Strike";
      Hostis["j"].Actus[3]="Thrust";
      Hostis["j"].Actus[0]="Step";
      Hostis["j"].Actus[4]="Wait";*/
      // Mechanicae.Chronus(homo, Hostis["h"]);
      

      // Mechanicae.Utor();
      /*homo.Actus[2]="Slash";
      homo.Actus[1]="Strike";
      homo.Actus[3]="Thrust";*/
      
      // Console.WriteLine("You are at x:"+homo.Lotus[0]+" y:"+homo.Lotus[1]+" no dosu he.");
			// Adventum.Utor(homo);

      // homo.Purgo("orgo");
  
			// Primor.homo.Epistola();

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
      Hostis["h"].Lotus[0]=100;
      Hostis["h"].Lotus[1]=100;
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
      Hostis["j"].Lotus[0]=10;
      Hostis["j"].Lotus[1]=10;
      Hostis["j"].PV[1]=10;

      Console.ReadLine();
      /*Console.WriteLine("Run in 'c'onsole or window?");
      Σ.rector=Console.ReadLine().ToLower();

      if(Σ.rector=="c"){

      } else{
        App oc = new App();
        OC occ = new OC();
        oc.Run(occ);
        Environment.Exit(0);
      }*/
		}
  }
}
