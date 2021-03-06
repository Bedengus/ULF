using System;
using System.Collections.Generic;

namespace ULF
{
  public class Forum : Regio
  {
    public Forum(string nomen, string[] prae, int lum=0, int noc=86400,Dictionary<string, string> ample=null) : base(nomen, prae, lum, noc, ample){
    
    }

    public void Utor(Persona Ego){
      if(!Ego.Charta.ContainsKey(this.Nomen))Ego.Charta.Add(this.Nomen, this.praesto);
      do{
        this.Paridor();
				Ego.Charta[this.Nomen]=this.praesto;
        Console.WriteLine("\nYou are in "+Primor.homo.Regio.Nomen+".\n");
        Σ.rector = Console.ReadLine().ToLower();
        
        switch(Σ.rector){
          case "shop":
            do{
              Merc(Ego);
            } while (Σ.rector == "");
            break;
          case "doc":
            Console.WriteLine(scriptum);
            Console.ReadLine();
            break;
          default:
            Adventum.Generalis(Ego);
            break;
        }
      } while(Σ.rector!="exit");
      Environment.Exit(0);
    }

    public void Merc(Persona Ego){
      Console.WriteLine("Welcome to the NAME GENERATOR Shop.");
      Console.WriteLine("\nWe have here for sale: *rolls random dices*");
      for(int u=0;u<this.praesto.Length;u++){
        Console.WriteLine(this.praesto[u]);
      }
      Console.WriteLine("\nWhat do you want to take a look?");
      Σ.rector=Console.ReadLine();

      if(Array.Exists(this.praesto,u=>u==Σ.rector)){
        Caussae.Acquirere(Σ.rector).Index();

        Console.WriteLine("\nDo you want to buy it?");
        Σ.notou=Console.ReadLine();

        if(Σ.notou=="y" || Σ.notou=="yes"){
          if(Caussae.Acquirere(Σ.rector).Typus=="arrow"){
            Console.WriteLine("\nHow many?");
            Σ.notou=Console.ReadLine();
            Σ.unus=String.IsNullOrEmpty(Σ.notou) ? 1 : Convert.ToInt32(Σ.notou);
          } else{
            Σ.unus=1;
          }
          if(Ego.Credits>=(Caussae.Acquirere(Σ.rector).Pretium*Σ.unus)){
            Ego.ArchAdd(Caussae.Acquirere(Σ.rector));
            Ego.Credits-=(Caussae.Acquirere(Σ.rector).Pretium*Σ.unus);
          } else{
            Console.WriteLine("\nYou lack monetary power for that.");
          }
        }
      } else{
        Console.WriteLine("\nWe do not have that or it is not even real.");
      }
      Console.WriteLine("Anything else? Type to exit.");
      Σ.rector = Console.ReadLine().ToLower();
    }

      public static Forum Advenire(string forum){
        
        switch(forum){
          case "Baazar":return Baazar;
          default:return null;
        }
      }

      static Forum Baazar = new Forum("Baazar",new string[]{
          "Steel Sword", "Steel Long Sword", "Steel Dagger", "Chestnut Staff", "Maple Bow",
          "Light Arrow", "Heavy Arrow"},
          28800, 64800,
          new Dictionary<string, string>{{"Emerald Village","100500"}});

      public static string scriptum = "\nThis is a shop."+
      "\nA shop is where you can buy, and sell, from equipment to commodities."+
      "\nUse 'look' and 'go' to move to new locations."+
      "\nUse 'shop' to browse wares.";

  }
}