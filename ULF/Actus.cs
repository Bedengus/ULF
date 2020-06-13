using System;

namespace ULF
{
  public static class Actus
  {

    public static void Gestus(string ges, Persona Ego){
      switch(ges){
        case "Step":
          Ego.sum+=1;
          break;
        case "Strike":
          Ego.sum+=2;
          break;
        case "Slash":
          Ego.sum+=2;
          break;
        case "Thrust":
          Ego.sum+=2;
          break;
        case "Cast":
          Console.WriteLine("Inform the target.");
          Σ.notoo = Console.ReadLine();
          Console.WriteLine("Inform the spell.");
          Σ.noton = Console.ReadLine();
          for(int u=0;u<Ego.Mana.Spargo(Σ.noton, Ego).Malleabile.Length;u++){
          if(Ego.Mana.Spargo(Σ.noton, Ego).Malleabile[u]==null){

          } else{
            Console.WriteLine("Inform how much Potency to use as "+Ego.Mana.Spargo(Σ.noton, Ego).Malleabile[u].ToLower()+".\nYou have "+Ego.Potentia+" Potency.\nLeave empty for full; insert '0' to use naught.");
            Σ.noto[u] = Console.ReadLine();
            Σ.decem += String.IsNullOrEmpty(Σ.noto[u]) ? -1 : Convert.ToInt32(Σ.noto[u]);
          }
        }
          Console.WriteLine("Inform how much Potency to use.\nYou have "+Ego.Potentia+" Potency.\nLeave empty for full; insert '0' to use naught.");
          
          Ego.sum+=Ego.Mana.Spargo(Σ.noton, Ego).Incantatio;
          break;
        default:
          Console.WriteLine("Unknown Action; your stupidity waste your time");
          Ego.sum+=1;
          break;
      }
      Ego.ergo=true;
    }
    public static void Ergo(string ges, Persona Ego){
      switch(ges){
        case "Step":
          Step(Ego);
          break;
        case "Strike":
          Strike(Ego);
          Ego.rec=true;
          Ego.sum+=1;
          break;
        case "Slash":
          Slash(Ego);
          Ego.rec=true;
          Ego.sum+=1;
          break;
        case "Thrust":
          Thrust(Ego);
          Ego.rec=true;
          Ego.sum+=1;
          break;
        case "Cast":
          Cast(Ego);
          break;
        default:
          Console.WriteLine("Unknown Action; your stupidity waste your time");
          Ego.sum+=1;
          break;
      }
      Ego.ergo=false;
    }

    public static void Step(Persona Ego){
      double dis;
      string dir;
      Console.WriteLine("\nHow long?");
      Σ.rector=Console.ReadLine();
      dis=String.IsNullOrEmpty(Σ.rector) ? 50 : Convert.ToInt32(Σ.rector);
      if(dis>50){
        dis=50;
      } else if(dis<1){
        dis=1;
      }
      Console.WriteLine("Whither?");
      dir=Console.ReadLine();

      if(dir=="n"||dir=="north"){
        Ego.Lotus[1]+=dis;
      } else if(dir=="w"||dir=="west"){
        Ego.Lotus[0]-=dis;
      } else if(dir=="s"||dir=="south"){
        Ego.Lotus[1]-=dis;
      } else if(dir=="e"||dir=="east"){
        Ego.Lotus[0]+=dis;
      } else if(dir=="nw"||dir=="northwest"){
        dis=Mechanicae.Calculus("hypo", dis);
        Ego.Lotus[0]+=dis;
        Ego.Lotus[1]-=dis;
      } else if(dir=="sw"||dir=="southwest"){
        dis=Mechanicae.Calculus("hypo", dis);
        Ego.Lotus[0]-=dis;
        Ego.Lotus[1]-=dis;
      } else if(dir=="se"||dir=="southeast"){
        dis=Mechanicae.Calculus("hypo", dis);
        Ego.Lotus[0]-=dis;
        Ego.Lotus[1]+=dis;
      } else if(dir=="ne"||dir=="northeast"){
        dis=Mechanicae.Calculus("hypo", dis);
        Ego.Lotus[0]+=dis;
        Ego.Lotus[1]+=dis;
      } else{
        Ego.Lotus[1]+=dis;
      }
      Console.WriteLine("You are at x:"+Ego.Lotus[0]+" y:"+Ego.Lotus[1]+" no dosu he.");
    }

    public static void Strike(Persona Ego){
      Console.WriteLine("\nInform the target.");
      Σ.notou = Console.ReadLine();
      Console.WriteLine("Inform how much Capacity to use.\nYou have "+Ego.Capacitas+" Capacity.\nLeave empty for full; insert '0' to use naught.");
      Σ.notod = Console.ReadLine();
      Mechanicae.PulsareJux(Ego, Ego.Arma, Primor.Hostis[Σ.notou], vis:String.IsNullOrEmpty(Σ.notod) ? -1 : Convert.ToInt32(Σ.notod), dam:1);
      Console.WriteLine(Σ.notou+" has "+Primor.Hostis[Σ.notou].PV[1]+" out of "+Primor.Hostis[Σ.notou].PV[0]+".");
    }
    public static void Slash(Persona Ego){
      Console.WriteLine("Inform the target.");
      Σ.notou = Console.ReadLine();
      Console.WriteLine("Inform how much Capacity to use.\nYou have "+Ego.Capacitas+" Capacity.\nLeave empty for full; insert '0' to use naught.");
      Σ.notod = Console.ReadLine();
      Mechanicae.PulsareJux(Ego, Ego.Arma, Primor.Hostis[Σ.notou], vis:String.IsNullOrEmpty(Σ.notod) ? -1 : Convert.ToInt32(Σ.notod), dam:2);
      Console.WriteLine(Σ.notou+" has "+Primor.Hostis[Σ.notou].PV[1]+" out of "+Primor.Hostis[Σ.notou].PV[0]+".");
    }
    public static void Thrust(Persona Ego){
      Console.WriteLine("Inform the target.");
      Σ.notou = Console.ReadLine();
      Console.WriteLine("Inform how much Capacity to use.\nYou have "+Ego.Capacitas+" Capacity.\nLeave empty for full; insert '0' to use naught.");
      Σ.notod = Console.ReadLine();
      Mechanicae.PulsareJux(Ego, Ego.Arma, Primor.Hostis[Σ.notou], vis:String.IsNullOrEmpty(Σ.notod) ? -1 : Convert.ToInt32(Σ.notod), dam:3);
      Console.WriteLine(Σ.notou+" has "+Primor.Hostis[Σ.notou].PV[1]+" out of "+Primor.Hostis[Σ.notou].PV[0]+".");
    }
    
    public static void Cast(Persona Ego){
      Mechanicae.Spargo(Ego.Mana.Spargo(Σ.noton, Ego),Ego, Primor.Hostis[Σ.notoo], Σ.decem);
      Console.WriteLine(Σ.notoo+" has "+Primor.Hostis[Σ.notoo].PV[1]+" out of "+Primor.Hostis[Σ.notoo].PV[0]+" Points de Vie.");
      Console.WriteLine("You have "+Ego.PM[1]+" out of "+Ego.PM[0]+" Points de Mana.");
    }

    // Reaction

    public static void Recovery(Persona Ego){
      Ego.rec=false;
      Console.WriteLine("You recover.");
    }
  }
}