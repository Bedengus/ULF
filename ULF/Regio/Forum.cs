using System;
using System.Collections.Generic;

namespace ULF
{
  public class Forum
  {
    public string Nomen{get; private set;}
    public static Dictionary<string, int> Amplexus = new Dictionary<string, int>();
    public Forum(string nomen, Dictionary<string, int> ample){
        Nomen=nomen;
        Amplexus=ample; 
    }

    public static void Utor(Persona Ego){
            do{
                Console.WriteLine("\nYou are in "+Primor.homo.Regio.Nomen+"\n");
                Σ.rector = Console.ReadLine().ToLower();
                
                switch(Σ.rector){
                    case "save":
                        Ego.Salvare();
                    break;
                    case "look":
                      foreach (var u in Amplexus){
                        Console.WriteLine(u.Key+"\n");
                      }
                    break;
                    case "go":
                        Console.WriteLine("Whither?");
                        Σ.rector = Console.ReadLine();
                        Ego.Regio.Iter(Σ.rector, Ego);
                    break;
                    case "shop":
                      do{
                        Merc(Ego);
                      } while (Σ.rector == "");
                      break;
                    case "inventory":   
                      do{
                        Panoplia(Ego);
                      } while (Σ.rector == "");       
                    break;
                    case "doc":
                        Console.WriteLine(scriptum);
                        Console.ReadLine();
                    break;
                    case "help":
                      Console.WriteLine(Adventum.aux);
                      Console.ReadLine();
                    break;
                    default:
                    break;
                }
            } while(Σ.rector!="exit");
            Environment.Exit(0);
        }

      public static void Merc(Persona Ego){
        Console.WriteLine("Welcome to the NAME GENERATOR Shop.");
        /*Console.WriteLine("\nWe have here for sale: *rolls random dices*"+
        "\n"+Ego.Arma.Ornare("steel sword").Nomen+": "+Ego.Arma.Ornare("steel sword").Pretium+"C"+
        "\n"+Ego.Arma.Ornare("steel long sword").Nomen+": "+Ego.Arma.Ornare("steel long sword").Pretium+"C"+
        "\n"+Ego.Arma.Ornare("steel dagger").Nomen+": "+Ego.Arma.Ornare("steel dagger").Pretium+"C"+
        "\n"+Ego.Arma.Ornare("chestnut staff").Nomen+": "+Ego.Arma.Ornare("chestnut staff").Pretium+"C"+
        "\n"+Ego.Arma.Ornare("maple bow").Nomen+": "+Ego.Arma.Ornare("maple bow").Pretium+"C");
        Console.WriteLine("\nWhat do you want to buy?");
        Σ.rector=Console.ReadLine().ToLower();
        if(Σ.rector==Ego.Arma.Ornare(Σ.rector).Nomen.ToLower()){
          if(Ego.Credits>=Ego.Arma.Ornare(Σ.rector).Pretium){
            Ego.Addicio("panoplia",Ego.Arma.Ornare(Σ.rector).Nomen);
            Ego.Credits-=Ego.Arma.Ornare(Σ.rector).Pretium;
          } else{
            Console.WriteLine("\nYou lack monetary power for that.");
          }
        } else{
          Console.WriteLine("\nThat is not real.");
        }*/
        Console.WriteLine("Anything else? Type to exit.");
        Σ.rector = Console.ReadLine().ToLower();
      }

      public static void Panoplia(Persona Ego){
          Console.WriteLine("\nWhat do you want to do with your inventory?\n Use 'look' or name an item to select it.");
          Σ.rector = Console.ReadLine().ToLower();
          if(Σ.rector=="look"){
            Ego.Spectare();
            Console.ReadLine();
          } else if(Ego.ArchTrac(Σ.rector).Nomen==Σ.rector){
            Console.WriteLine("\nYou have selected "+Σ.rector+".\n"+
            Ego.ArchTrac(Σ.rector).Depictium+
            "\nIt weights "+Ego.ArchTrac(Σ.rector).Pondus+"."+
            "\nYou have "+Ego.ArchTrac(Σ.rector).Quantitas+".");
            // type delete, 'probable use', and equip?
            Console.WriteLine("Anything else? Type to exit.");
            Σ.rector = Console.ReadLine();
            if(Ego.panaN[Σ.rector]>0){
              Ego.Arma = Arma.Ornare(Σ.rector);
              Ego.Arma.Index();
              Ego.Virtus();
            } else{
            Console.WriteLine("\nYou do not have that item.");
            }
            Console.ReadLine();
          }
          Console.WriteLine("Type to exit:");
          Σ.rector = Console.ReadLine().ToLower();
        }

        public static Forum Advenire(string forum){
            Forum Baazar = new Forum("Baazar", new Dictionary<string, int>{{"Emerald Village",1}});
            
            switch(forum){
                case "Baazar":
                    return Baazar;
                case "dex":
                    //call
                    break;
                case "con":
                    //call
                    break;
                case "int":
                    //call
                    break;
                case "wis":
                    //call
                    break;
                default:
                    
                    break;
            }
            return Baazar;
        }

        public static string scriptum = "\nThis is a shop."+
        "\nA shop is where you can buy, and sell, from equipment to commodities."+
        "\nUse 'look' and 'go' to move to new locations."+
        "\nUse 'shop' to browse wares.";

  }
}