using System;
using System.Collections.Generic;

namespace ULF
{
	public class Taberna : Regio
	{
		public Taberna(string nomen,  int lum=0, int noc=86400,Dictionary<string, string> ample=null) : base(nomen, new string[]{}, lum, noc, ample){
      
    }

    public void Utor(Persona Ego){
      if(!Ego.Charta.ContainsKey(this.Nomen))Ego.Charta.Add(this.Nomen, this.praesto);
      do{
        this.Paridor();
				Ego.Charta[this.Nomen]=this.praesto;
        Console.WriteLine("\nYou are in "+Primor.homo.Regio.Nomen+" at "+Agrum.Centuria[2]+":"+Agrum.Centuria[1]+":"+Agrum.Centuria[0]+".\n");
        Σ.rector = Console.ReadLine().ToLower();

        switch (Σ.rector){
          case "doc":
            Console.WriteLine(scriptum);
            Console.ReadLine();
            break;
          case "eat":
            Agrum.Centuria[0]+=1800;
            Ego.jeiunium[1]=Agrum.Centuria[9];
            Ego.jeiunium[0]=0;
            Ego.Virtus();
            Adventum.Verso(Ego);
          break;
          case "sleep":
            if(Ego.Studium.Count>0){
              do{
                Console.WriteLine("What would you like to meditate on?");
                Σ.rector=Console.ReadLine();
                if(Ego.Studium.Contains(Σ.rector)){
                  Random roll = new Random();
                  if(roll.Next(5)>2)Console.WriteLine("You mind opens to the possibilities of "+Σ.rector);
                  else Console.WriteLine(Σ.rector+" still confuses you, but you feel closer to the truth.");
                } else Console.WriteLine("You have not trained that today.");
              }while(Σ.rector!="");
            }
            
            Console.WriteLine("You sleep for eight hours...");
            Agrum.Centuria[0]+=28800;
            Ego.jeiunium[1]+=28800;
            Ego.sonmus[1]=Agrum.Centuria[9];
            Ego.sonmus[0]=0;
            Adventum.Verso(Ego);
            break;
          default:
            Adventum.Generalis(Ego);
            break;
        }
      } while (Σ.rector != "exit");
      Environment.Exit(0);
    }

    public static Taberna Advenire(string tab){

      switch (tab)
      {
        case "Tiny Equine Inn":return TinyEquine;
        default:return null;
      }
    }

    static Taberna TinyEquine = new Taberna("Tiny Equine Inn", ample:new Dictionary<string, string>{{"Emerald Village","100300"}});


    public static string scriptum = "\nThis is an inn." +
    "\nAn inn is a place of rest and organizing your life." +
    "\nUse 'stay' to stay for the night and get a day's worth of food." +
		"\nUse 'sleep' to sleep." +
		"\nUse 'eat' to buy a meal." +
    "\nUse 'look' and 'go' to move to new locations.";
	}
}