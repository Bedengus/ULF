using System;
using System.Collections.Generic;

namespace ULF
{
  public class Exterius : Regio
  {
    public Exterius(string nomen, string[] prae, int lum=0, int noc=86400,Dictionary<string, string> ample=null) : base(nomen, prae, lum, noc, ample){

    }

    public void Utor(Persona Ego){
			if(!Ego.Charta.ContainsKey(this.Nomen))Ego.Charta.Add(this.Nomen, this.praesto);
      do{
				this.Paridor();
				Ego.Charta[this.Nomen]=this.praesto;
        Console.WriteLine("\nYou are in "+Primor.homo.Regio.Nomen+".\n");
        Σ.rector = Console.ReadLine().ToLower();
        
        switch(Σ.rector){
					case "observe":
						Opes(Ego);
						break;
						case "harvest":
						Auctumnum(Ego);
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

		public void Opes(Persona Ego){
			Console.WriteLine("Amid the wilderness... ");
			for(int u=0;u<this.praesto.Length;u++){
				if(this.praesto[u]!=null){
					if(Mechanicae.Conditio(Ego, ULF.Opes.Origo(this.praesto[u]).conditio)){
					Console.WriteLine("You recognize... "+ULF.Opes.Origo(this.praesto[u]).Depictium);
					}
				}	
			}
			Console.WriteLine("\nAnd that is about it.");
			Agrum.Centuria[0]+=600;
			Adventum.Verso(Ego);
		}

		public void Auctumnum(Persona Ego){
			Console.WriteLine("Harvest how?");
			Σ.notou=Console.ReadLine();

			switch(Σ.notou){
				case "Cut":
					do{
						Console.WriteLine("Unto what?");
						Σ.notod=Console.ReadLine();
						for(int u=0;u<this.praesto.Length;u++){
							if(this.praesto[u]!=null){
								if(this.praesto[u]==Σ.notod){
									if(Mechanicae.Conditio(Ego, ULF.Opes.Origo(this.praesto[u]).conditio)){
										Ego.ArchAdd(ULF.Opes.Origo(this.praesto[u]).Auctumnum());	
										Agrum.Centuria[0]+=ULF.Opes.Origo(this.praesto[u]).chronus;
										Adventum.Verso(Ego);

										this.spawawn[u]=ULF.Opes.Origo(this.praesto[u]).chronus*10;
										this.spawawnd[u]=Agrum.Centuria[9];

										this.praesto[u]=null;	
									} else{
										Console.WriteLine("As you heard somewhere the ressource is there, but you lack the skills to harvest it.");
									}
									break;
								}
							}
						}
						Console.WriteLine("Cut More?");
						Σ.notod=Console.ReadLine();
					} while (Σ.notod.ToLower()=="y"||Σ.notod.ToLower()=="yes");
					break;
				case "Mine":
					//call
					break;
				default:
					Console.WriteLine("That action is, like, not even real.");
					break;
			}
		}

		public static Exterius Advenire(string exterius){
			
			switch(exterius){
				case "Plain Plain":return Plain;
				default:return null;
			}
		}

		static Exterius Plain = new Exterius("Plain Plain", new string[]{
				"Teak", "Maple", "Chestnut", "Teak", "Teak"},
				0, 86400,
				new Dictionary<string, string>{{"Emerald Village","100500"}});

		public static string scriptum = "\nThis is a natural trove."+
		"\nNature covers most of the world; travels or any activity outside towns happen, well, outside!"+
		"\nUse 'look' and 'go' to move to new locations."+
		"\nUse 'observe' to browse around for any natural resource you know of."+
		"\nUse 'harvest' to collect ressources.";

  }
}