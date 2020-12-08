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
              Ego.ArchRec();
              Console.WriteLine("Type to exit:");
              Σ.rector = Console.ReadLine();
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
            case "help":
              Console.WriteLine(aux);
              Console.ReadLine();
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
      // Environment.Exit(0);
    }

    public static void Generalis(Persona Ego){
      switch(Σ.rector){
        case "look":
          Adventum.Verso(Ego);
          foreach (var u in Ego.Regio.Amplexus)
          { 
            if(Regio.Labor(u.Key).lumen<=Agrum.Centuria[8] && Regio.Labor(u.Key).nox>=Agrum.Centuria[8]){
              Console.WriteLine(u.Key);
            }
          }
          break;
        case "go":
          Console.WriteLine("Whither?");
          Σ.rector = Console.ReadLine();
          if(Ego.Regio.Amplexus.ContainsKey(Σ.rector)){
            if(Regio.Labor(Σ.rector).lumen<=Agrum.Centuria[8] && Regio.Labor(Σ.rector).nox>=Agrum.Centuria[8]){
              Ego.Regio.Iter(Σ.rector, Ego);
            } else{
              Console.WriteLine("That place is currently closed.");
            }
          } else{
            Console.WriteLine("That place does not exist or is not avaliable from here.");
          }
          break;
        case "save":
          Ego.Salvare();
          break;
        case "doc":
          Console.WriteLine(scriptum);
          Console.ReadLine();
          break;
        case "inventory":   
          do{
            Ego.ArchRec();
            Console.WriteLine("Type to exit:");
            Σ.rector = Console.ReadLine();
          } while (Σ.rector == "");       
        break;
        case "sheet":
          Ego.Epistola();
          break;
        case "help":
            Console.WriteLine(aux);
            Console.ReadLine();
          break;
        case "data":
          Console.WriteLine("Day "+Agrum.Centuria[3]+" at "+Agrum.Centuria[2]+":"+Agrum.Centuria[1]+":"+Agrum.Centuria[0]+".\n");
          break;
        case "pray":
          POG();
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


        case "mechanics":
          Mechanicae.Utor();
          break;
        case "aact":
          Actum(Ego);
          break;
        case "ashop":   
            do{
            Forum(Ego);
            } while (Σ.rector == "");         
          break;
        case "abattle":
          Mechanicae.Chronus(Ego);
          break;
        case "tokinonagare":
          Σ.rector = Console.ReadLine();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          Agrum.Centuria[0]+=Σ.unus;
          Agrum.Aeon();
          Console.WriteLine("Day "+Agrum.Centuria[3]+" at "+Agrum.Centuria[2]+":"+Agrum.Centuria[1]+":"+Agrum.Centuria[0]+".\n");
          Console.ReadLine();
          break;
        default:
          break;
      }
    }



    public static void Verso(Persona Ego){
      Agrum.Aeon();
      Inedia(Ego);

      if(Ego.PV[1]<1){
        Console.WriteLine("\n\nYou die; what is usually undesirible.");
        // clean inventory and force save? better than deleting the char e.e
      }
    }
    public static void POG(){
      do{
        Random being = new Random();
        string nomnom="";
        switch(being.Next(1,5)){
          case 1:
            nomnom="sapient animal";
            break;
          case 2:
            nomnom="minor lifeform";
            break;
          case 3:
            nomnom="lost soul";
            break;
          case 4:
            nomnom=Primor.homo.Nomen+" "+Primor.homo.Cognomen;
            break;
          case 5:
            nomnom="not-Chosen One";
            break;
          default:
            
            break;
        }
        Console.WriteLine("\nHello there, "+nomnom+"."+
        "\n\nWhat would you like to learn?"+
        "\n>Professions");

        Σ.rector = Console.ReadLine();
        switch(Σ.rector){
          case "Professions":
            Console.WriteLine("\nProfessions are a kind of knowledge which allows you to perform certain tasks."+
            "\nThey can be categorized within two simple focal points: harvesting and crafting."+
            "\nCrafting ones deal with creating any kind of item on public or private workbenches."+
            "\nHarvesting ones can gather ressources, and often craft simple materials, to be sold or used on crafts."+
            "\nWoodcutter is an example of gathering, in this case trees, and then processing the raw materials before more complex fletcher crafts."+
            "\nEach of those tasks has a chance of improving the overall profession level; and extra knowledges are needed, as to identify certain kinds of trees or different processing methods for woodcutter."+
            "\nHunter is an example of an unusual profession; which instead of gathering on the overworld allows special drops to be harvested from battles."+
            "\nAnd once again rather than accumulative 'experience points' there is instead a chance for overall improvement, which allows to learn new side knowledges and expand the profession's reach."+
            "\n\nYou can find workbenches and start learning professions on their respective guilds.");
            break;
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

        Console.WriteLine("\nThis knowledge suffices?");
        Σ.rector=Console.ReadLine();
      } while(Σ.rector=="n" || Σ.rector=="no");
    }


    public static void Inedia(Persona Ego){
      if(Ego.jeiunium[1]+30000<=Agrum.Centuria[9]&&Ego.jeiunium[0]==0){
        Console.WriteLine("You have some hunger eating away at your intestinal fabric.");
        Ego.jeiunium[0]++;
      } else if(Ego.jeiunium[1]+60000<=Agrum.Centuria[9]&&Ego.jeiunium[0]==1){
        Console.WriteLine("You feel weak and your life seeps away.");
        Ego.Virtus("inedia");
        Ego.PV[1]=Ego.PV[1]-(Ego.PV[1]/4);
        Ego.jeiunium[0]++;
      } else if(Ego.jeiunium[1]+90000<=Agrum.Centuria[9]&&Ego.jeiunium[0]==2){
        Console.WriteLine("You feel weaker and your life seeps away.");
        Ego.Virtus("inedia");
        Ego.PV[1]=Ego.PV[1]-(Ego.PV[1]/4);
        Ego.jeiunium[0]++;
      } else if(Ego.jeiunium[1]+120000<=Agrum.Centuria[9]&&Ego.jeiunium[0]==3){
        Console.WriteLine("You feel even weaker and your life seeps away.");
        Ego.Virtus("inedia");
        Ego.PV[1]=Ego.PV[1]-(Ego.PV[1]/4);
        Ego.jeiunium[0]++;
      } else if(Ego.jeiunium[1]+150000<=Agrum.Centuria[9]&&Ego.jeiunium[0]==4){
        Console.WriteLine("Your life seeps away.");
        Ego.Virtus("inedia");
        Ego.PV[1]=Ego.PV[1]-(Ego.PV[1]/4);
        Ego.jeiunium[0]++;
      } else if(Ego.jeiunium[1]+180000<=Agrum.Centuria[9]&&Ego.jeiunium[0]==5){
        Console.WriteLine("Your life seeps away.");
        Ego.Virtus("inedia");
        Ego.PV[1]=Ego.PV[1]-(Ego.PV[1]/4);
        Ego.jeiunium[0]++;
      } else if(Ego.jeiunium[1]+210000<=Agrum.Centuria[9]&&Ego.jeiunium[0]==6){
        Console.WriteLine("Your life seeps away.");
        Ego.Virtus("inedia");
        Ego.PV[1]=Ego.PV[1]-(Ego.PV[1]/4);
        Ego.jeiunium[0]++;
      } else if(Ego.jeiunium[1]+250000<=Agrum.Centuria[9]&&Ego.jeiunium[0]==7){
        Console.WriteLine("Your life seeps away.");
        Ego.Virtus("inedia");
        Ego.PV[1]=Ego.PV[1]-(Ego.PV[1]/2);
        Ego.jeiunium[0]++;
      } else if(Ego.jeiunium[1]+300000<=Agrum.Centuria[9]&&Ego.jeiunium[0]==8){
        Console.WriteLine("You autofagy yourself away.");
        Ego.Virtus("inedia");
        Ego.PV[1]=0;
        Ego.jeiunium[0]++;
      }

      if(Ego.sonmus[1]+72000<=Agrum.Centuria[9]&&Ego.sonmus[0]==0){
        Console.WriteLine("Drowsiness drowns upon you.");
        Ego.Virtus("inedia");
        Ego.sonmus[0]++;
      } else if(Ego.sonmus[1]+172800<=Agrum.Centuria[9]&&Ego.sonmus[0]==1){
        Console.WriteLine("So fucking tired... This amyloid plaque accumulation will last for life...");
        Ego.PV[1]=Ego.PV[1]-(Ego.PV[1]/2);
        Ego.Virtus("inedia");
        Ego.sonmus[0]++;
      } else if(Ego.sonmus[1]+262800<=Agrum.Centuria[9]&&Ego.sonmus[0]==2){
        Console.WriteLine("Your brain forcibly ceases function.");
        Ego.PV[1]=0;
        Ego.sonmus[0]++;
      }
    }

    public static void Bellum(Persona Ego, bool yuno=false, params Persona[] hostis){
      Mechanicae.Chronus(Ego, yuno, hostis);
      Mechanicae.Rapina(Ego, hostis); 
      Ego.Tempus=0;
      Agrum.Centuria[0]+=Agrum.Tempus;
      Agrum.Aeon();
      Agrum.Tempus=0;
      Σ.rector = "e";
    }
    public static void Forum(Persona Ego){
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

    public static string aux = "\nWelcome to your adventure.\n\n"+
        "See this almost at any time by typing 'help'.\n"+
        "Also remember the ubiquitous commands 'look', 'go', 'save' and 'doc'.\n"+
        "Less used, but also present, is 'inventory' and 'data'.\n"+
        "In battle use 'info' to analyse your enemies and 'look' to see surrounding map.\n"+
        "Be most careful to letter casing in names: I am unforgiving.\n"+
        "Use 'pray' to learn about specific mechanics."+
        "Use of 'exit' to end the game.\n\n";
  }
}