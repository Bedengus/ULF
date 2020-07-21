using System;
using System.Collections.Generic;

namespace ULF
{
	public class Taberna : Regio
	{
		public Taberna(string nomen="", Dictionary<string, string> ample=null, int lum=0, int noc=86400) : base(nomen, ample, lum, noc){
      
    }

    public void Utor(Persona Ego){
      do{
        Console.WriteLine("\nYou are in "+Primor.homo.Regio.Nomen+" at "+Agrum.Centuria[2]+":"+Agrum.Centuria[1]+":"+Agrum.Centuria[0]+".\n");
        Σ.rector = Console.ReadLine().ToLower();

        switch (Σ.rector){
          case "doc":
            Console.WriteLine(scriptum);
            Console.ReadLine();
            break;
          default:
            Adventum.Generalis(Ego);
            break;
        }
      } while (Σ.rector != "exit");
      Environment.Exit(0);
    }

    public static Taberna Advenire(string tab){
      Taberna TinyEquine = new Taberna("Tiny Equine Inn", new Dictionary<string, string>{{"Emerald Village","100300"}});

      switch (tab)
      {
        case "Tiny Equine Inn":
          return TinyEquine;
        case "dex":
            //call
        case "con":
          //call
        case "int":
          //call
        case "wis":
          //call
        default:
          return null;
      }
    }


    public static string scriptum = "\nThis is an inn." +
    "\nAn inn is a place of rest and organizing your life." +
    "\nUse 'stay' to stay for the night and get a day's worth of food." +
		"\nUse 'sleep' to sleep." +
		"\nUse 'eat' to buy a meal." +
    "\nUse 'look' and 'go' to move to new locations.";
	}
}