using System;
using System.Collections.Generic;

namespace ULF
{
  public class Urbs : Regio
  {
    
    public Urbs(string nomen="", Dictionary<string, string> ample=null, int lum=0, int noc=86400) : base(nomen, ample, lum, noc){
      
    }

    public void Utor(Persona Ego){
      do{
        Console.WriteLine("\nYou are in "+Primor.homo.Regio.Nomen+" at "+Agrum.Centuria[2]+":"+Agrum.Centuria[1]+":"+Agrum.Centuria[0]+".\n");
        Σ.rector = Console.ReadLine().ToLower();

        switch (Σ.rector){
          case "walk":
            if(Mechanicae.Volvere(4) > 2){
              do
              {
                Console.WriteLine("You have been ambushed by 'Bandit'!");
                Adventum.Bellum(Ego, true, Primor.Hostis["Bandit"]);
              } while (Σ.rector == "");
            }
            Agrum.Centuria[0]+=600;
            Agrum.Aeon();
            break;
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

    public static Urbs Advenire(string urb){
      Urbs EmeraldVillage = new Urbs("Emerald Village", new Dictionary<string, string>{{"Baazar","200500"},{"Mage Guild","300300"},{"Tiny Equine Inn","400300"}});

      switch (urb)
      {
        case "Emerald Village":
          return EmeraldVillage;
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


    public static string scriptum = "\nThis is a city." +
    "\nA city is a mid-point to seek events outside or inside, travel or use any facilities such as inns, shops and guilds." +
    "\nUse 'walk' to take a walk." +
    "\nUse 'look' and 'go' to move to new locations.";
  }
}