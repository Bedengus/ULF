using System;

namespace ULF
{
  public class Adventum
  {
    public static void Utor(Persona Ego){
      do{
        Console.WriteLine(intro);
        Σ.rector = Console.ReadLine().ToLower();
        
        switch(Σ.rector){
          case "save":
            Ego.Salvare();
            break;
          case "doc":
            Console.WriteLine(scriptum);
            Console.ReadLine();
            break;
          case "mechanics":
            Mechanicae.Utor();
            break;
          case "act":
            Actum(Ego);
            break;
          case "inventory":   
              do{
              Panoplia(Ego);
              } while (Σ.rector == "");       
            break;
          case "shop":   
              do{
              Forum(Ego);
              } while (Σ.rector == "");         
            break;
          case "battle":
            Mechanicae.Chronus(Ego);
            break;
          case "roll4":
            Σ.rector = Console.ReadLine();
            Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
            Mechanicae.Volvere(4, Σ.unus);
            Console.ReadLine();
            break;
          case "roll6":
            Σ.rector = Console.ReadLine();
            Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
            Mechanicae.Volvere(6, Σ.unus);
            Console.ReadLine();
            break;
          case "roll8":
            Σ.rector = Console.ReadLine();
            Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
            Mechanicae.Volvere(8, Σ.unus);
            Console.ReadLine();
            break;
          case "roll10":
            Σ.rector = Console.ReadLine();
            Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
            Mechanicae.Volvere(10, Σ.unus);
            Console.ReadLine();
            break;
          case "roll12":
            Σ.rector = Console.ReadLine();
            Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
            Mechanicae.Volvere(12, Σ.unus);
            Console.ReadLine();
            break;
          case "roll20":
            Σ.rector = Console.ReadLine();
            Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
            Mechanicae.Volvere(20, Σ.unus);
            Console.ReadLine();
            break;
          case "roll100":
            Σ.rector = Console.ReadLine();
            Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
            Mechanicae.Volvere(1000, Σ.unus);
            Console.ReadLine();
            break;
          case "roll%":
            Σ.rector = Console.ReadLine();
            Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
            Mechanicae.Volvere(100, Σ.unus);
            Console.ReadLine();
            break;
          case "froll":
            Σ.rector = Console.ReadLine();
            Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
            Mechanicae.LVolvere(Σ.unus);
            Console.ReadLine();
            break;
          default:
            break;
        }
      } while(Σ.rector!="exit");
      Environment.Exit(0);
    }

    public static void Panoplia(Persona Ego){
      Console.WriteLine("\nWhat do you want to do with your inventory?\n'look'\n'equip'");
      Σ.rector = Console.ReadLine().ToLower();
      if(Σ.rector=="look"){
        Ego.Spectare();
        Console.ReadLine();
      } else if(Σ.rector=="equip"){
        Console.WriteLine("\nWhat do you want to equip?");
        Σ.rector = Console.ReadLine();
        if(Array.Exists(Ego.panoN,i=>i==Σ.rector)){
          Ego.Arma = Ego.Arma.Ornare(Σ.rector.ToLower());
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
    public static void Forum(Persona Ego){
      Console.WriteLine("Welcome to the NAME GENERATOR Shop.");
      Console.WriteLine("\nWe have here for sale: *rolls random dices*"+
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
      }
      Console.WriteLine("Anything else? Type to exit.");
      Σ.rector = Console.ReadLine().ToLower();
    }
    public static void Actum(Persona Ego){
      Console.WriteLine("\nChoose an action");
      Σ.rector=Console.ReadLine();

      if(Array.Exists(Ego.Actus,i=>i==Σ.rector)){
        switch(Σ.rector){
          case "Step":
            Actus.Step(Ego);
            break;
          case "Strike":
            Actus.Strike(Ego);
            break;
          case "Slash":
            Actus.Slash(Ego);
            break;
          case "Thrust":
            Actus.Thrust(Ego);
            break;
          case "Cast":
            Actus.Gestus(Σ.rector, Ego);
            Actus.Ergo(Σ.rector, Ego);
            break;
          default:
            Console.WriteLine("Unknown Action; your stupidity waste your time");
            Ego.sum+=1;
            break;
        }
      }
  
      /*switch(Σ.rector){
        case "attack":
            do{
              Console.WriteLine("Inform the target.");
              Σ.notou = Console.ReadLine();
              Console.WriteLine("Inform how much Capacity to use.\nYou have "+Primor.homo.Capacitas+" Capacity.\nLeave empty for full; insert '0' to use naught.");
              Σ.notod = Console.ReadLine();
              Mechanicae.PulsareJux(Primor.homo, Primor.homo.Arma, Primor.Hostis[Σ.notou], vis:String.IsNullOrEmpty(Σ.notod) ? -1 : Convert.ToInt32(Σ.notod));
              Console.WriteLine("Type to exit:");
              Σ.rector = Console.ReadLine().ToLower();
              } while (Σ.rector == "");
            Utor();
            break;
          case "shoot":
            do{
              Console.WriteLine("Inform the target.");
              Σ.rector = Console.ReadLine();
              Mechanicae.PulsareLonge(Primor.homo, Primor.Hostis[Σ.rector], 7, 4, 0.04, 2);
              Console.WriteLine("Type to exit:");
              Σ.rector = Console.ReadLine().ToLower();
              } while (Σ.rector == "");
            Utor();
            break;
          case "cast":
            do{
              Console.WriteLine("Inform the target.");
              Σ.notou = Console.ReadLine();
              Console.WriteLine("Inform the spell.");
              Σ.notod = Console.ReadLine();
              Console.WriteLine("Inform how much Potency to use.\nYou have "+Primor.homo.Potentia+" Potency.\nLeave empty for full; insert '0' to use naught.");
              Σ.notot = Console.ReadLine();
              Mechanicae.Spargo(Primor.homo.Mana.Spargo(Σ.notod),Primor.homo, Primor.Hostis[Σ.notou], String.IsNullOrEmpty(Σ.notot) ? -1 : Convert.ToInt32(Σ.notot));
              Console.WriteLine("Type to exit:");
              Σ.rector = Console.ReadLine().ToLower();
              } while (Σ.rector == "");
            Utor();
            break;
      }*/
    }
    public static string intro = "\nWelcome to your adventure.\n"+
        "Use this to assist your TRPG of ULF.\n"+
        "Type 'roll20' or other value to roll a dice.\n"+
        "Type 'act' to perform an Action.\n"+
        "Type 'battle' to enter combat mode.\n"+
        "Type 'inventory' to interact with your possessions.\n"+
        "Type 'shop' to see the still-template store.\n"+
        "Type 'save' to save your character's state.\n"+
        "Type 'doc' for further explanations on methods.\n"+
        "Type 'exit' to leave.";
    public static string scriptum = "\nDocumentation for the Adventum Class.\n\n"+
        "This calculates based on your characters parameters. Use 'mechanics' to get directly to the mechanics menu.";
  }
}