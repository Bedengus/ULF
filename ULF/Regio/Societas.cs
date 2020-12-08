using System;
using System.Collections.Generic;

namespace ULF
{
	public class Societas : Regio
	{
    public string type;
		public Societas(string nomen, string typ, string[] prae, int lum=0, int noc=86400, Dictionary<string, string> ample=null) : base(nomen, prae, lum, noc, ample){
      this.type=typ;
    }

    public void Utor(Persona Ego){
      if(!Ego.Charta.ContainsKey(this.Nomen))Ego.Charta.Add(this.Nomen, this.praesto);
      do{
        this.Paridor();
				Ego.Charta[this.Nomen]=this.praesto;
        Console.WriteLine("\nYou are in "+Primor.homo.Regio.Nomen+".\n");
        Σ.rector = Console.ReadLine().ToLower();

        switch (Σ.rector){
          case "study":
              Discare(Ego);
            break;
          case "work":
          Opera(Ego);
            break;
          case "quest":
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

    public void Discare(Persona Ego){
      if(this.type=="Mage"){
        Console.WriteLine("Welcome to the "+this.Nomen+" of Emerald Village.");
        Console.WriteLine("We have courses availables for:");
        for(int u=0;u<this.praesto.Length;u++){
          Console.WriteLine("Buff: "+this.praesto[u]);
        }
        Console.WriteLine("\nWhat would you like to learn?");
        Σ.rector=Console.ReadLine();

        if(Array.Exists(this.praesto,u=>u==Σ.rector)){
          Console.WriteLine("\n"+β.Buff(Σ.rector).Nomen);
          foreach(var u in β.Buff(Σ.rector).Difficultas){
            Console.WriteLine("Difficulty: "+u.Value+" "+u.Key);
          }
          int hor=β.Buff(Σ.rector).hora/3600;
          Console.WriteLine("Time: "+hor+"h"+
          "\nCost: "+β.Buff(Σ.rector).Pretium);

          Console.WriteLine("\nWould you like to train it?");
          Σ.notou=Console.ReadLine();
          if(Σ.notou=="y" || Σ.notou=="yes"){
            if(Ego.RepertoireB.ContainsKey(Σ.rector)){
              Console.WriteLine("\nYou have already learnt that, man!");
            } else if(β.Buff(Σ.rector).requiritare!="" && !Ego.RepertoireB.ContainsKey(β.Buff(Σ.rector).requiritare)){
              Console.WriteLine("\nYour incapable self is devoid of the minimal "+β.Buff(Σ.rector).requiritare+".");
            } else {
              Console.WriteLine("\nFor how long?");
              Σ.notou=Console.ReadLine();
              Σ.unus=String.IsNullOrEmpty(Σ.notou) ? 0 : Convert.ToInt32(Σ.notou);
              if(hor==β.Buff(Σ.rector).discunt[0]){
                Σ.unus=1;
              } else if(Σ.unus+β.Buff(Σ.rector).discunt[0] > hor){
                Σ.unus=hor-β.Buff(Σ.rector).discunt[0];
              }
              if(Ego.Credits>=β.Buff(Σ.rector).Pretium*Σ.unus){
                Agrum.Centuria[2]+=Σ.unus;
                Adventum.Verso(Ego);
                Ego.Credits-=β.Buff(Σ.rector).Pretium*Σ.unus;
                Console.WriteLine("You have: "+Ego.Credits);
                Console.WriteLine("It is "+Agrum.Centuria[2]+":"+Agrum.Centuria[1]+":"+Agrum.Centuria[0]+".\n");
                β.Buff(Σ.rector).discunt[0]+=Σ.unus;
                if(β.Buff(Σ.rector).discunt[0]>hor){
                  β.Buff(Σ.rector).discunt[0]=hor;
                }
                if(β.Buff(Σ.rector).discunt[1]<1){
                  β.Buff(Σ.rector).discunt[1]=1;
                }
                Petitio(Ego);
                Σ.num[1]=Mechanicae.Volvere(100, nomen:Ego.Cognomen);
                Console.WriteLine(Ego.Cognomen+" rolls "+Σ.num[1]+" against "+Σ.num[0]+".");
                if(Σ.num[1]>Σ.num[0]){
                  Ego.AddicioB(β.Buff(Σ.rector).Nomen, "E");
                } else{
                  Console.WriteLine("\nYou have not truly grasped the way of the spell.");
                  if(β.Buff(Σ.rector).discunt[0]==hor){
                    β.Buff(Σ.rector).discunt[1]+=1;
                    Console.WriteLine("But you feel closer to mastering it!");
                  }
                } 
              }
            }
          }
        }
      }
    
    }
    public void Opera(Persona Ego){
      if(this.type=="Woodcutter"){
        Console.WriteLine("Do you want to find a part-time 'job' or use a guild 'workbench'?");
        Σ.rector=Console.ReadLine().ToLower();
        if(Σ.rector=="workbench"){
        Console.WriteLine("Here on the Hipster Guild we have:");
        for(int u=0;u<this.praesto.Length;u++){
          Console.WriteLine(this.praesto[u]);
        }

        Console.WriteLine("\nWhat would you like to use?");
        Σ.rector=Console.ReadLine();
        foreach(string u in this.praesto){
          if(Σ.rector==u){
            switch(Σ.rector){
              case "Saw":
              do{
                Console.WriteLine("\nWhat do you want to saw?");
                Σ.notou=Console.ReadLine();
                if(Ego.ArchTrac(Σ.notou)!=null){
                  Console.WriteLine("\nInto how many planks of 100x3?");
                  Σ.notod=Console.ReadLine();
                  Σ.unus = String.IsNullOrEmpty(Σ.notod) ? 1 : Convert.ToInt32(Σ.notod);
                  if(Σ.unus>10)Σ.unus=10;
                  if(Σ.unus<1)Σ.unus=1;
                  Ego.ArchDel(Ego.ArchTrac(Σ.notou));

                  int split = (36 - (Σ.unus*3))*10;

                  switch(Σ.notou){
                    case "Teak Log":
                      Ego.ArchAdd(Caussae.Acquirere("Teak Plank", Σ.unus));
                      Ego.ArchAdd(Caussae.Acquirere("Teak Splinter", split));
                      break;
                    case "Chestnut Log":
                      Ego.ArchAdd(Caussae.Acquirere("Chestnut Plank", Σ.unus));
                      Ego.ArchAdd(Caussae.Acquirere("Chestnut Splinter", split));
                      break;
                    case "Maple Log":
                      Ego.ArchAdd(Caussae.Acquirere("Maple Plank", Σ.unus));
                      Ego.ArchAdd(Caussae.Acquirere("Maple Splinter", split));
                      break;
                  }
                }
                // add a recipe list somewhere; confirms if there is items on inventory and then delete wood as it turns into items
                Console.WriteLine("\nSaw more??");
                Σ.rector=Console.ReadLine().ToLower();
              } while(Σ.rector=="y" || Σ.rector=="yes");
                
                break;
              case "dex":
                //call
                break;
              default:
                
                break;
              }
          }
        }

        } else{
          Console.WriteLine("We have avaliable today:"+
          "\nWoodcutter: 0.15C/h *PER 10STR*"+
          "\nWoodCUTTERRRR: 0.25C/h *PER 10STR*"+
          "\nWoodpecker: 0.05C/h");
        }

        
      }
    }

    public static void Petitio(Persona Ego){
      if(β.Buff(Σ.rector).Difficultas.ContainsKey("STR")){
        Σ.num[0]=β.Buff(Σ.rector).Difficultas["STR"]*(β.Buff(Σ.rector).hora/3600);
        Σ.num[1]=Ego.Vigor[0];
        Σ.num[2]=β.Buff(Σ.rector).Difficultas["STR"];
        Σ.num[0]=Math.Floor(100/(Σ.num[0]/((Σ.num[1]*β.Buff(Σ.rector).discunt[0])*β.Buff(Σ.rector).discunt[1])));
      } else if(β.Buff(Σ.rector).Difficultas.ContainsKey("DEX")){
        Σ.num[0]=β.Buff(Σ.rector).Difficultas["DEX"]*(β.Buff(Σ.rector).hora/3600);
        Σ.num[1]=Ego.Dexteritate[0];
        Σ.num[2]=β.Buff(Σ.rector).Difficultas["DEX"];
        Σ.num[0]=Math.Floor(100/(Σ.num[0]/((Σ.num[1]*β.Buff(Σ.rector).discunt[0])*β.Buff(Σ.rector).discunt[1])));
      } else if(β.Buff(Σ.rector).Difficultas.ContainsKey("CON")){
        Σ.num[0]=β.Buff(Σ.rector).Difficultas["CON"]*(β.Buff(Σ.rector).hora/3600);
        Σ.num[1]=Ego.Conditio[0];
        Σ.num[2]=β.Buff(Σ.rector).Difficultas["CON"];
        Σ.num[0]=Math.Floor(100/(Σ.num[0]/((Σ.num[1]*β.Buff(Σ.rector).discunt[0])*β.Buff(Σ.rector).discunt[1])));
      } else if(β.Buff(Σ.rector).Difficultas.ContainsKey("INT")){
        Σ.num[0]=β.Buff(Σ.rector).Difficultas["INT"]*(β.Buff(Σ.rector).hora/3600);
        Σ.num[1]=Ego.Intelligentia[0];
        Σ.num[2]=β.Buff(Σ.rector).Difficultas["INT"];
        Σ.num[0]=Math.Floor(100/(Σ.num[0]/((Σ.num[1]*β.Buff(Σ.rector).discunt[0])*β.Buff(Σ.rector).discunt[1])));
      } else if(β.Buff(Σ.rector).Difficultas.ContainsKey("WIS")){
        Σ.num[0]=β.Buff(Σ.rector).Difficultas["WIS"]*(β.Buff(Σ.rector).hora/3600);
        Console.WriteLine(Σ.num[0]);
        Σ.num[1]=Ego.Sapientia[0];
        Σ.num[2]=β.Buff(Σ.rector).Difficultas["WIS"];
        Σ.num[0]=Math.Floor(100/(Σ.num[0]/((Σ.num[1]*β.Buff(Σ.rector).discunt[0])*β.Buff(Σ.rector).discunt[1])));
      }
      if(Σ.num[0]>=100 && Σ.num[1]>Σ.num[2]){
        Σ.num[0]=0;
      } else if (Σ.num[0]>50){
        Σ.num[0]=50;
      } else{
        Σ.num[0]=Math.Abs(Σ.num[0]-100);
      }
    }

    public static Societas Advenire(string soc){

      switch (soc)
      {
        case "Mage Guild":return MageGuild;
        case "Beardy Nerd":return BeardyGuild;
        default:return null;
      }
    }

    static Societas MageGuild = new Societas("Mage Guild", "Mage", new string[]{
      "Strength I", "Strength II", "Strength III",
      "Agility I", "Agility II", "Agility III",
      "Endurance I", "Endurance II", "Endurance III",
      "Potency I", "Potency II", "Potency III", 
      "Focus I", "Focus II", "Focus III"},
      18000, 75600,
      new Dictionary<string, string>{{"Emerald Village","100300"}});
    static Societas BeardyGuild = new Societas("Beardy Nerd", "Woodcutter",new string[]{"Saw"}, 14400, 64800,
    new Dictionary<string, string>{{"Emerald Village","100100"}});


    public static string scriptum = "\nThis is a guild." +
    "\nA guild is a place of knowledge; a society of those who dedicate to master one art." +
    "\nUse 'study' to seek a course to learn." +
		"\nUse 'work' to gain money with your skills or learn in practice on a job." +
		"\nUse 'quest' to see if there is any special work or event avaliable." +
    "\nUse 'look' and 'go' to move to new locations.";
	}
}