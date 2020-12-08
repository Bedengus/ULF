using System;

namespace ULF
{
  public static class Actus
  {

    public static void Gestus(string ges, Persona Ego, bool yuno=false){
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
        case "Shoot":
          if(Ego.Arma.Typus!="bow"){
            Console.WriteLine("You cannot shoot with that.");
          } else{
            Ego.sum+=2;
          }
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
          // Console.WriteLine("Inform how much Potency to use.\nYou have "+Ego.Potentia+" Potency.\nLeave empty for full; insert '0' to use naught.");
          
          Ego.sum+=Ego.Mana.Spargo(Σ.noton, Ego).Incantatio;
        break;
        case "Buff":
        if(Ego.leavo){
          Console.WriteLine("You body cannot take further buffs, motherfucker.");
        } else{
          Buff(Ego);
        } 
        break;
        case "Wait":
          Console.WriteLine("Inform for how long.");
          Σ.noto[70]=Console.ReadLine();
          Ego.sum+= String.IsNullOrEmpty(Σ.noto[70]) ? 1 : Convert.ToInt32(Σ.noto[70]);
        break;
        default:
          Console.WriteLine("Unknown Action; your stupidity waste your time");
          Ego.sum+=1;
          break;
      }
      Ego.ergo=true;
    }
    public static void Ergo(string ges, Persona Ego, bool yuno=false){
      switch(ges){
        case "Step":
          Step(Ego, yuno);
          break;
        case "Strike":
          Strike(Ego, yuno);
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
        case "Shoot":
          Shoot(Ego);
          break;
        case "Cast":
          Cast(Ego);
          break;
        case "Buff":
          break;
        case "Wait":
        break;
        default:
          Console.WriteLine("Unknown Action; your stupidity waste your time");
          Ego.sum+=1;
          break;
      }
      Ego.ergo=false;
    }

    public static void Step(Persona Ego, bool yuno=false){
      double dis=0;
      string dir="";
      if(!yuno){
        Console.WriteLine("\nHow long?");
        Σ.rector=Console.ReadLine();
        dis=String.IsNullOrEmpty(Σ.rector) ? 50 : Convert.ToInt32(Σ.rector);
        if(dis>50)dis=50;
        else if(dis<1)dis=1;

        Console.WriteLine("Whither?");
        dir=Console.ReadLine();
      } else{
        dis=50;
        if(Primor.homo.Lotus.Y>Ego.Lotus.Y&&Primor.homo.Lotus.X>Ego.Lotus.X)dir="ne";
        else if(Primor.homo.Lotus.Y>Ego.Lotus.Y&&Primor.homo.Lotus.X<Ego.Lotus.X)dir="nw";
        else if(Primor.homo.Lotus.Y<Ego.Lotus.Y&&Primor.homo.Lotus.X>Ego.Lotus.X)dir="se";
        else if(Primor.homo.Lotus.Y<Ego.Lotus.Y&&Primor.homo.Lotus.X<Ego.Lotus.X)dir="sw";
        else if(Primor.homo.Lotus.Y>Ego.Lotus.Y)dir="n";
        else if(Primor.homo.Lotus.X>Ego.Lotus.X)dir="w";
        else if(Primor.homo.Lotus.Y<Ego.Lotus.Y)dir="s";
        else if(Primor.homo.Lotus.X<Ego.Lotus.X)dir="e";
      }

      if(dir=="n"||dir=="north")Mechanicae.Momentum(Ego, y:dis);
      else if(dir=="w"||dir=="west")Mechanicae.Momentum(Ego, x:-dis);
      else if(dir=="s"||dir=="south")Mechanicae.Momentum(Ego, y:-dis);
      else if(dir=="e"||dir=="east")Mechanicae.Momentum(Ego, x:dis);
      else dis=Mechanicae.Calculus("hypo", dis);

      if(dir=="nw"||dir=="northwest")Mechanicae.Momentum(Ego, dis, -dis);
      else if(dir=="sw"||dir=="southwest")Mechanicae.Momentum(Ego, -dis, -dis);
      else if(dir=="se"||dir=="southeast")Mechanicae.Momentum(Ego, -dis, +dis);
      else if(dir=="ne"||dir=="northeast")Mechanicae.Momentum(Ego, dis, dis);
    }

    public static void Strike(Persona Ego, bool yuno=false){
      Σ.dt=0;
      if(!yuno){
        Console.WriteLine("\nInform the target.");
        Σ.notou = Console.ReadLine();
        Console.WriteLine("Inform how much Capacity to use.\nYou have "+Ego.Capacitas+" Capacity.\nLeave empty for full; insert '0' to use naught.");
        Σ.notod = Console.ReadLine();
        Mechanicae.PulsareJux(Ego, Ego.Arma, Primor.Hostis[Σ.notou], vis:String.IsNullOrEmpty(Σ.notod) ? -1 : Convert.ToInt32(Σ.notod));
        Console.WriteLine(Σ.notou+" has "+Primor.Hostis[Σ.notou].PV[1]+" out of "+Primor.Hostis[Σ.notou].PV[0]+".");
      } else{
        Mechanicae.PulsareJux(Ego, Ego.Arma, Primor.homo, yuno:true);
        Console.WriteLine(Primor.homo.Cognomen+" has "+Primor.homo.PV[1]+" out of "+Primor.homo.PV[0]+".");
      }   
    }
    public static void Slash(Persona Ego){
      Σ.dt=1;
      Console.WriteLine("Inform the target.");
      Σ.notou = Console.ReadLine();
      Console.WriteLine("Inform how much Capacity to use.\nYou have "+Ego.Capacitas+" Capacity.\nLeave empty for full; insert '0' to use naught.");
      Σ.notod = Console.ReadLine();
      Mechanicae.PulsareJux(Ego, Ego.Arma, Primor.Hostis[Σ.notou], vis:String.IsNullOrEmpty(Σ.notod) ? -1 : Convert.ToInt32(Σ.notod));
      Console.WriteLine(Σ.notou+" has "+Primor.Hostis[Σ.notou].PV[1]+" out of "+Primor.Hostis[Σ.notou].PV[0]+".");
    }
    public static void Thrust(Persona Ego){
      Σ.dt=2;
      Console.WriteLine("Inform the target.");
      Σ.notou = Console.ReadLine();
      Console.WriteLine("Inform how much Capacity to use.\nYou have "+Ego.Capacitas+" Capacity.\nLeave empty for full; insert '0' to use naught.");
      Σ.notod = Console.ReadLine();
      Mechanicae.PulsareJux(Ego, Ego.Arma, Primor.Hostis[Σ.notou], vis:String.IsNullOrEmpty(Σ.notod) ? -1 : Convert.ToInt32(Σ.notod));
      Console.WriteLine(Σ.notou+" has "+Primor.Hostis[Σ.notou].PV[1]+" out of "+Primor.Hostis[Σ.notou].PV[0]+".");
    }

    public static void Shoot(Persona Ego){
      Console.WriteLine("Inform the target.");
      Σ.notou = Console.ReadLine();
      Console.WriteLine("Inform the missile type.");
      Σ.notod = Console.ReadLine();
      if(Ego.ArchTrac(Σ.notod)!=null){
        Ego.ArchTrac(Σ.notod).Quantitas--;
        Console.WriteLine("You have "+Ego.ArchTrac(Σ.notod).Quantitas+" "+Ego.ArchTrac(Σ.notod).Nomen+" left.");
        Mechanicae.PulsareLonge(Ego, Primor.Hostis[Σ.notou], Ego.Arma.DamnumT, Ego.ArchTrac(Σ.notod).Value, Ego.ArchTrac(Σ.notod).Pondus, 2);
        Console.WriteLine(Σ.notou+" has "+Primor.Hostis[Σ.notou].PV[1]+" out of "+Primor.Hostis[Σ.notou].PV[0]+".");
      } else{
        Console.WriteLine("You cannot shoot with that.");
      }
    } 
    public static void Cast(Persona Ego){
      Mechanicae.Spargo(Ego.Mana.Spargo(Σ.noton, Ego),Ego, Primor.Hostis[Σ.notoo], Σ.decem);
      Console.WriteLine(Σ.notoo+" has "+Primor.Hostis[Σ.notoo].PV[1]+" out of "+Primor.Hostis[Σ.notoo].PV[0]+" Points de Vie.");
      Console.WriteLine("You have "+Ego.PM[1]+" out of "+Ego.PM[0]+" Points de Mana.");
    }

    public static void Buff(Persona Ego){
      Console.WriteLine("Inform the buff.");
      Σ.notoo = Console.ReadLine();
      if(β.Buff(Σ.notoo)!=null){
        if(Ego.RepertoireB.ContainsKey(Σ.notoo)){
          if(Ego.RepertoireB[Σ.notoo]!="E"){
            Console.WriteLine("Inform the target.");
            Σ.noton = Console.ReadLine();
          } else{
            Σ.noton = "E";
          }
        } else{
          Console.WriteLine("You do not have that buff yet.");
        }
      } else{
        Console.WriteLine("That buff does not exist.");
      }
      Mechanicae.Laevo(Ego, β.Buff(Σ.notoo));
    }
    // Reaction

    public static void Recovery(Persona Ego){
      Ego.rec=false;
      Console.WriteLine(Ego.Cognomen+" recovers.");
    }
  }
}