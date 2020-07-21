using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ULF
{
	public class Persona
	{
		public Persona(string nomen="Paulum", string cognomen="Vagabundus", string genus="Human", int vigor=10, int dexteritate=10, int conditio=10, int intelligentia=10, int sapientia=10, double alt=170, double lat=50, double cra=12, double crd=7, int mec=1, int gra=1, int enf=1, int cel=3, int acc=1, int per=1, double pon=61, double spa=80, int nil=0){
			this.Nomen=nomen;
			this.Cognomen=cognomen;
      this.Genus.typus=genus;
      this.PV=new int[2];
      this.PM=new double[2];
			this.Vigor[0]=vigor;
			this.Dexteritate[0]=dexteritate;
			this.Conditio[0]=conditio;
			this.Intelligentia[0]=intelligentia;
			this.Sapientia[0]=sapientia;

			this.Altitudo=alt;
			this.Latitudo=lat;
			this.Crassitudo=new double[2]{cra, crd};
			this.Pondus=pon;
			this.Spatium=new double[2]{spa, spa};
      this.Planitia=new double[3];
      this.Caput=new double[3];
      this.Ocullus=new double[3];
      this.Collum=new double[3];
      this.Cor=new double[3];
      this.Tergum=new double[3];
      this.Bracchium=new double[3];
      this.Stomachus=new double[3];
      this.Crus=new double[3];

			this.CorpusAptus=cel;
			this.AccuratioP=acc;
			this.PerceptioP=per;
			this.ConvertioMechanica=mec;
			this.Liguritio=gra;
			this.FluentaAnima=enf;

      Virtus();

      this.Actus[0]="Step";
      this.Actus[1]="Wait";

      this.Lotus = new Lotus();
      this.Motus=0;
      this.Tempus=0;
		}

		public void Utor(){
			do{
				Console.WriteLine("\nWelcome to the character creation. Insert your first name, return and then your surname.");
				Σ.notou = Console.ReadLine();
				Σ.notod = Console.ReadLine();
				PersonaN(Σ.notou, Σ.notod);
			}while(Σ.notou==null);
			
			do{
				Console.WriteLine("\nChoose your roll type: 'balanced' for 10+1d4 or 'wild' for 1d20.");
				Σ.rector = Console.ReadLine().ToLower();

				if(Σ.rector=="balanced"){
					int[] cybus = new int[6];
					for(int u=1;u<6;u++){
						cybus[u]=Mechanicae.Volvere(4)+10;
						if(u==5)PersonaV(cybus[1], cybus[2], cybus[3], cybus[4], cybus[5]);
					}           
				} else if(Σ.rector=="wild"){
						int[] cybus = new int[6];
						for(int u=1;u<6;u++){
							cybus[u]=Mechanicae.Volvere(20);
							if(u==5)PersonaV(cybus[1], cybus[2], cybus[3], cybus[4], cybus[5]);
						}
				} else Σ.rector ="virtus";
			}while(Σ.rector=="virtus");
			
			do{
				Console.WriteLine("\nChoose your race.\nTheir details are found on the ULF TRPG documentation; which you should have read before coming here.");
				Console.WriteLine("All basic races are available; 'human', 'orc', 'vampire', 'dwarf', 'elf' and 'werewolf'.");

				Genus.Linea(Console.ReadLine(), this);
			}while(Σ.rector=="ex");

      Console.WriteLine("\nWhat starting class do you wish?");
      Console.WriteLine("The recommendation is either 'swordsman', 'elementalist', 'archer' or 'rogue'.");
      Console.WriteLine("Type 'free' to start with 100 Credits instead.");
			Σ.rector=Console.ReadLine().ToLower();

      InitusOrdo(Σ.rector);

			Console.WriteLine("\nGenerating Sheet...");
      Virtus();
			Console.ReadLine();
      Console.WriteLine("Type 'sheet' to see complete character sheet; type anything else to skip.");
      Σ.rector=Console.ReadLine().ToLower();
      if(Σ.rector=="sheet")Epistola();

      Console.WriteLine("Do you wish to 'save' this character?");
			Σ.rector=Console.ReadLine().ToLower();
      if(Σ.rector=="save")Salvare();

      Console.WriteLine("Print sheet to .txt?");
      Σ.rector = Console.ReadLine();
      if(Σ.rector=="yes")Scribere(Cognomen);
		}


		public void Purgo(string insectum){
      if(insectum=="nomen"){
        Console.WriteLine("Welcome to the character creation. Inser your first name, return and then your surname.");
				Σ.notou = Console.ReadLine();
				Σ.notod = Console.ReadLine();
				PersonaN(Σ.notou, Σ.notod);
      } else if(insectum=="virtues"){
          do{
            Console.WriteLine("Choose your roll type: 'balanced' for 10+1d4 or 'wild' for 1d20.");
            Σ.rector = Console.ReadLine().ToLower();

            if(Σ.rector=="balanced"){
              int[] cybus = new int[6];
              for(int u=1;u<6;u++){
                cybus[u]=Mechanicae.Volvere(4)+10;
                if(u==5)PersonaV(cybus[1], cybus[2], cybus[3], cybus[4], cybus[5]);
                }           
            } else if(Σ.rector=="wild"){
                int[] cybus = new int[6];
                for(int u=1;u<6;u++){
                  cybus[u]=Mechanicae.Volvere(20);
                  if(u==5)PersonaV(cybus[1], cybus[2], cybus[3], cybus[4], cybus[5]);
                }
            } else Σ.rector ="virtus";
          }while(Σ.rector=="virtus");
      } else if(insectum=="genus"){
          do{
            Console.WriteLine("Choose your race.\nTheir details are found on the ULF TRPG documentation; which you should have read before coming here.");
            Console.WriteLine("All basic races are available; 'human', 'orc', 'vampire', 'dwarf', 'elf' and 'werewolf'.");
            Index();
            this.Genus.typus = Console.ReadLine();

            Console.WriteLine(">Integrum\n>Cisterna\n>Mensura.");
            Σ.rector = Console.ReadLine().ToLower();
            if(Σ.rector=="cisterna"){
              Genus.Cisterna(this.Genus.typus, this);
            } else if(Σ.rector=="mensura"){
              Genus.Mensura(this.Genus.typus, this);
            } else{
              Genus.Linea(this.Genus.typus, this);
            }
          }while(Σ.rector=="ex");
      } else if(insectum=="orgo"){
        Console.WriteLine("\nWhat starting class do you wish?");
        Console.WriteLine("The recommendation is either 'swordsman', 'elementalist', 'archer' or 'rogue'.");
        Console.WriteLine("Type 'free' to start with 100 Credits instead.");
        Σ.rector=Console.ReadLine().ToLower();

        InitusOrdo(Σ.rector);
      }
			
		}
		public void PersonaN(string nomen, string cognomen="Vagabundus"){
			this.Nomen=nomen;
			this.Cognomen=cognomen;
			Console.WriteLine("\nWelcome into existence, "+this.Cognomen+"-boy.");
		}
		public void PersonaV(int vigor, int dexteritate, int conditio, int intelligentia, int sapientia){
			this.Vigor[0]=vigor;
			this.Dexteritate[0]=dexteritate;
			this.Conditio[0]=conditio;
			this.Intelligentia[0]=intelligentia;
			this.Sapientia[0]=sapientia;
			Index();
		}
		public void PersonaD(int mec=1, int gra=1, int enf=1, int cel=3, int acc=1, int per=1){
			this.ConvertioMechanica=mec;
			this.Liguritio=gra;
			this.FluentaAnima=enf;
      this.CorpusAptus=cel;
      this.AccuratioP=acc;
      this.PerceptioP=per;
		}
		public void Virtus(string ret="reset"){
      switch(ret){
        case "reset":
          this.Vigor[1]=this.Vigor[0];
          this.Dexteritate[1]=this.Dexteritate[0];
          this.Conditio[1]=this.Conditio[0];
          this.Intelligentia[1]=this.Intelligentia[0];
          this.Sapientia[1]=this.Sapientia[0];
          this.leavo=false;
          goto case "att";
        case "att":
          this.Capacitas=Mechanicae.Capacitas(this.Vigor[1], this.ConvertioMechanica);
          this.Potentia=Mechanicae.Capacitas(this.Intelligentia[1], this.FluentaAnima);
          this.Celeritas=Mechanicae.Celeritas(this.Dexteritate[1], this.CorpusAptus);
          this.Accuratio=Mechanicae.Accuratio(this.Dexteritate[1], this.AccuratioP);
          this.Perceptio=Mechanicae.Perceptio(this.Sapientia[1], this.PerceptioP);

          this.AgiT=Mechanicae.Lapsus(Celeritas);
          this.PerT=Mechanicae.Lapsus(Perceptio);
          this.CasT=Mechanicae.Lapsus(Intelligentia[1]);

          this.Spatium[1] = this.Spatium[0] + this.Arma.Spatium;
          break;
      }
		}
    public void InitusOrdo(string ordo=""){
      
      switch(ordo){
        case "swordsman":
          this.Ordo["Swordsman"]=true;

          AddicioM("Blade Proficiency", 1, "peritia");
          AddicioB("Strength I", "E");
          AddicioB("Agility I", "E");
          AddicioB("Endurance I", "E");
          this.Addicio("actus", "Slash", "Thrust", "Buff");
          // Goat Leather Armour

          Console.WriteLine("Do you wish for 'Sword' Mastery or 'Long' Sword Mastery?");
			    Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="long"||Σ.rector=="long sword"){
            AddicioM("Long Sword Mastery", 1, "peritia");
            this.ArchAdd(Caussae.Acquirere("Steel Long Sword"));
            this.Arma=Arma.Ornare("Steel Long Sword");
          } else{
            AddicioM("Sword Mastery", 1, "peritia");
            this.ArchAdd(Caussae.Acquirere("Steel Sword"));
            this.Arma=Arma.Ornare("Steel Sword");
          }
          this.Credits=5;
          
          Console.WriteLine("\nYou are a Swordsman; a progressive agressive class of the melee tree.");
			    Console.ReadLine();
          break;
        case "elementalist":
          this.Ordo["Elementalist"]=true;

          AddicioM("Staff Mastery", 1, "peritia");
          AddicioB("Potentia I", "E");//resistance I E
          this.Addicio("actus", "Cast", "Strike", "Buff");

          this.ArchAdd(Caussae.Acquirere("Chestnut Staff")); //Simple Robe Set
          this.Arma=Arma.Ornare("Chestnut Staff");

          do{
            Console.WriteLine("\nWhich elementar discipline do you wish to follow?");
            Console.WriteLine("\n*****pyromancy with Fireball and glacemancy with Icicle are the only choices for now*****");
			      Σ.rector=Console.ReadLine().ToLower();

            switch(Σ.rector){
              case "pyromancy":Mana.Disciplinae("pyro", 1);break;
              case "aermancy":Mana.Disciplinae("aer", 1);break;
              case "aquamancy":Mana.Disciplinae("aqua", 1);break;
              case "taromancy":Mana.Disciplinae("taro", 1);break;
              case "glacemancy":Mana.Disciplinae("glace", 1);break;
              case "denkoumancy":Mana.Disciplinae("denkou", 1);break;
              case "almancy":Mana.Disciplinae("al", 1);break;
              case "yamimancy":Mana.Disciplinae("yami", 1);break;
              default:
                Console.WriteLine("You should know better; that is invalid.");
                Console.ReadLine();
                Σ.rector="";
                break;
            }
          } while(Σ.rector=="");

          Console.WriteLine("\nType 'grimoire' to see a list of spells avaliable to you or directly type the spell you wish to learn.");
          Console.WriteLine("Be meticulous on the study of magic and properly capitalize the spells' names.");
			    Σ.rector=Console.ReadLine();
          Mana.Magus(Σ.rector, this);
          this.Credits=10;

          Console.WriteLine("\nYou are an Elementalist; a sorcerer class of the mage tree.");
			    Console.ReadLine();
          break;
        case "archer":
          this.Ordo["Archer"]=true;

          AddicioM("Ranged Proficiency", 1, "peritia");
          AddicioM("Bow Mastery", 1, "peritia");
          AddicioB("Agility I", "E");
          AddicioB("Focus I", "E");
          this.ArchAdd(Caussae.Acquirere("Maple Bow"));
          this.Arma=Arma.Ornare("Maple Bow");
          this.Addicio("actus", "Shoot", "Buff");

          Console.WriteLine("Do you want 30 'Light' Arrows or 20 'Heavy' Arrows?");
			    Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="heavy"||Σ.rector=="heavy arrows")this.ArchAdd(Caussae.Acquirere("Heavy Arrow", 20));
            else this.ArchAdd(Caussae.Acquirere("Light Arrow", 30));
          this.Credits=5;

          Console.WriteLine("\nYou are an Archer; a hunter class of the ranged tree.");
			    Console.ReadLine();
          break;
        case "rogue":
          this.Ordo["Rogue"]=true;

          AddicioM("Blade Proficiency", 1, "peritia");
          AddicioM("Dagger Mastery", 1, "peritia");
          AddicioB("Agility I", "E");
          AddicioB("Focus I", "E");
          this.Addicio("actus", "Slash", "Thrust", "Buff");
          this.ArchAdd(Caussae.Acquirere("Steel Dagger"));//Goat Leather Armour
          this.Arma=Arma.Ornare("Steel Dagger");
          this.Credits=5;

          Console.WriteLine("\nYou are a Rogue; a instant agressive class of the melee tree.");
			    Console.ReadLine();
          break;
        default:
          Console.WriteLine("\nYou are a free unskilled man with 100 Credits.\nGet a class certificate at the guild once you fufill the requirements.");
			    Console.ReadLine();
          this.Credits=100;
          break;
      }
    }

		public void Index(string petitio="attributes"){
			switch(petitio){
				case "attributes":
					Console.WriteLine("STR: "+this.Vigor[0]+"\n"+
          "DEX: "+this.Dexteritate[0]+
          "\n"+"CON: "+this.Conditio[0]+
          "\n"+"INT: "+this.Intelligentia[0]+
          "\n"+"WIS: "+this.Sapientia[0]);
					break;
				case "parameters":
					Console.WriteLine("Capacity: "+this.Capacitas+
          "\n"+"Potency: "+this.Potentia+
          "\n"+"Speed: "+this.Celeritas+
          "\n"+"Precision: "+this.Accuratio+
          "\n"+"Perception: "+this.Perceptio);
					break;
				case "proportions":
					Console.WriteLine("Height: "+this.Altitudo+"\n"+"Width: "+this.Latitudo+"\n"+"Thickness: "+this.Crassitudo[0]+"\n"+"Reach: "+this.Spatium[1]+"\n"+"Weight: "+this.Pondus+"\n"+"Volume: "+this.Carnatio+"\n"+"Front: "+this.Planitia[0]+"\n"+"Side: "+this.Planitia[1]);
					Console.WriteLine("Head: "+this.Caput[2]+"cm²\nEyes: "+this.Ocullus[2]+"cm²\nNeck: "+this.Collum[2]+"cm²\nHeart: "+this.Cor[2]+"cm²\nSpine: "+this.Tergum[2]+"cm²\nArms: "+this.Bracchium[2]+"cm²\nStomach: "+this.Stomachus[2]+"cm²\nLegs: "+this.Crus[2]+"cm²");
          break;
				default:
					break;
			}
			
		}
    public void Spectare(string verbum="panoplia"){
      if(verbum=="panoplia"){
        for(int u=0;u<this.Archivum.Length;u++)if(this.Archivum[u]!=null)Console.WriteLine(this.Archivum[u].Nomen+" x"+this.Archivum[u].Quantitas);
      } else if(verbum=="repertoire"){
        for(int u=0;u<this.Repertoire.Length;u++)if(this.Repertoire[u]!=null)Console.WriteLine(this.Repertoire[u]);
      } else if(verbum=="actus"){
        for(int u=0;u<this.Actus.Length;u++)if(this.Actus[u]!=null)Console.WriteLine(this.Actus[u]);
      } else if(verbum=="ordo"){
        foreach (var u in this.Ordo)Console.WriteLine(u.Key);
      } else if(verbum=="laevo"){
        foreach (var u in this.RepertoireB)Console.WriteLine(u.Key);
      } else if(verbum=="metier"){
        foreach (var u in this.Metier)Console.WriteLine(u.Key+" "+u.Value);
      } else if(verbum=="peritia"){
        foreach (var u in this.Peritia)Console.WriteLine(u.Key+" "+u.Value);
      }
    }
    public void Addicio(string verbum="actus", params string[] mers){
      if(verbum=="repertoire"){
        for(int u=0;u<mers.Length;u++){
          for(int d=0;d<this.Repertoire.Length;d++){
            if(this.Repertoire[d]==null){
              this.Repertoire[d]=mers[u];
              Console.WriteLine("\nYou have learnt "+this.Repertoire[d]+"!");
              break;
            }
          }
        } 
      } else if(verbum=="actus"){
        for(int u=0;u<mers.Length;u++){
          for(int d=0;d<this.Actus.Length;d++){
            if(this.Actus[d]==null){
              this.Actus[d]=mers[u];
              Console.WriteLine("\nYou have developed "+this.Actus[d]+"!");
              break;
            }
          }
        } 
      }
    }

    public void AddicioB(string mers, string sco="E" /*Ego Autrem Duo*/){
      if(!this.RepertoireB.ContainsKey(mers)){
        this.RepertoireB[mers]=sco;
        if(sco=="D")Console.WriteLine("\nYou have learnt "+mers+"!");
        else Console.WriteLine("\nYou have learnt "+mers+" "+this.RepertoireB[mers]+"!");
      }
    }

    public void AddicioM(string met, int lev=1, string verbum="metier"){
        // Hunter
      if(verbum=="metier")this.Metier[met]=lev;
      else if(verbum=="peritia")this.Peritia[met]=lev;
        // Blade Proficiency
        // Ranged Proficiency
        // Sword Mastery dex?
        // Long Sword Mastery str?
        // Dagger Mastery dex?
        // Bow Mastery dex?
        // Staff Mastery int?
        
      Console.WriteLine("\nYou have learnt "+met+" "+lev+"!");
    }

    public void ArchAdd(params Caussae[] mers){
      bool est;
      if(Σ.unus<1)Σ.unus=1;

      for(int u=0;u<mers.Length;u++){
        est=false;
        foreach(var d in this.Archivum){
          if(d!=null){
            if(d.Nomen==mers[u].Nomen){
              d.Quantitas+=Σ.unus;
              Console.WriteLine("\nYou have acquired more "+Σ.unus+" "+mers[u].Nomen+"!");
              est=true;
            }
          }
        } 
        if(!est){
          for(int d=0;d<this.Archivum.Length;d++){
            if(this.Archivum[d]==null){
              Σ.unus=mers[u].Quantitas;
              this.Archivum[d]=mers[u];
              this.Archivum[d].Quantitas=Σ.unus;
              this.panaN[mers[u].Nomen]=Σ.unus;
              if(mers[u].Quantitas>1)Console.WriteLine("\nYou have acquired "+mers[u].Nomen+" x"+mers[u].Quantitas+"!");
              else Console.WriteLine("\nYou have acquired "+mers[u].Nomen+"!");
              break;
            }
          }
        } 
      }
      
    }
    public Caussae ArchTrac(string mers){
      foreach(var c in this.Archivum){
        if(c!=null){
          if(c.Nomen==mers){
            return c;
          }
        }
      }
      return null;
    }
    public void ArchRec(){
      Console.WriteLine("\nWhat do you want to do with your inventory?\nUse 'look', name a slot or name an item to select it.");
      Σ.rector = Console.ReadLine();

      if(Σ.rector=="look"){
        Spectare();
        Console.ReadLine();
      } else if(Σ.rector=="hands"){
        if(this.Arma==null)Console.WriteLine("\nEmpty hands, boy.");
        else this.Arma.Index();
      } else if(Σ.rector==""){

      } else if(ArchTrac(Σ.rector).Nomen==Σ.rector){
        Console.WriteLine("\nYou have selected "+Σ.rector+".\n"+
        ArchTrac(Σ.rector).Depictium+
        "\nIt weights "+ArchTrac(Σ.rector).Pondus+"."+
        "\nYou have "+ArchTrac(Σ.rector).Quantitas+".");
        if(Arma.Ornare(Σ.rector)!=null)Arma.Ornare(Σ.rector).Index();
        
        Console.WriteLine("\nType 'delete' to destroy it.");
        if(Arma.Ornare(Σ.rector)!=null)Console.WriteLine("Type 'equip' to use it.");
        Σ.notou = Console.ReadLine();

        if(Σ.notou=="delete"){
          Array.Clear(Archivum, Array.IndexOf(Archivum, ArchTrac(Σ.rector)), 1);
          panaN.Remove(Σ.rector);
          if(this.Arma.Nomen==Σ.rector)this.Arma=null;
          Console.WriteLine("You have gotten rid of "+Σ.rector+".");
        } else if(Σ.notou=="equip"){
          this.Arma=ULF.Arma.Ornare(Σ.rector);
          this.Arma.Index();
          Virtus();
        }
      }
    }

		public void Epistola(){
      Console.WriteLine("******************************************************************************************\n");
			Console.WriteLine(this.Nomen+" "+this.Cognomen);
			Console.WriteLine(this.Genus.typus);
			Console.WriteLine("PV: "+this.PV[1]+"/"+this.PV[0]);
			Console.WriteLine("MP: "+this.PM[1]+"/"+this.PM[0]);
      Console.WriteLine("Credits: "+this.Credits);
      Console.WriteLine("Classes--> ");
			Spectare("ordo");
			Console.ReadLine();
      Console.WriteLine("Attributes--> ");
			Index();
			Console.ReadLine();
      Console.WriteLine("Parameters--> ");
      Index("parameters");
			Console.ReadLine();
      Console.WriteLine("Proportions--> ");
      Index("proportions");
			Console.ReadLine();
			Console.WriteLine("Actions--> ");
      Spectare("actus");
      Console.ReadLine();
			Console.WriteLine("Buffs--> ");
      Spectare("laevo");
      Console.ReadLine();
			Console.WriteLine("Spells--> ");
      Spectare("repertoire");
      Console.ReadLine();
			Console.WriteLine("Passives--> ");
			Console.WriteLine("Mechanical Conversion: "+this.ConvertioMechanica);
			Console.WriteLine("Gracefulness: "+this.Liguritio);
			Console.WriteLine("Energy Flow: "+this.FluentaAnima);
			Console.WriteLine("Fitness: "+this.CorpusAptus);
      Console.ReadLine();
			Console.WriteLine("Mastery--> ");
      Spectare("peritia");
      Console.ReadLine();
			Console.WriteLine("Knowledge--> ");
      Spectare("metier");
      Console.ReadLine();
			Console.WriteLine("Moves--> ");
      Console.ReadLine();
			Console.WriteLine("Inventory--> ");
      Spectare("panoplia");
      Console.WriteLine("\n******************************************************************************************");
      Console.ReadLine();
		}

    public void Intro(){
      Console.WriteLine("Do you wish to create a 'new' being or reanimate an 'old' one?");
			Σ.rector = Console.ReadLine().ToLower();
      
      if(Σ.rector!="old")Utor();
      else {
        Console.WriteLine("Recollect his family name from the depths of your memory:");
        Σ.rector = Console.ReadLine();
        if (File.Exists(".\\Baratrum\\" + Σ.rector + ".jkk")){
          Porto(Σ.rector);

          Console.WriteLine("Welcome back, "+this.Cognomen+"-boy.");

          Console.WriteLine("Show character sheet?");
          Σ.rector = Console.ReadLine().ToLower();
          if(Σ.rector=="yes"||Σ.rector=="y")Epistola();

          Console.WriteLine("Print sheet to .txt?");
          Σ.rector = Console.ReadLine().ToLower();
          if(Σ.rector=="yes"||Σ.rector=="y")Scribere(this.Cognomen);
          
        } else{
          Console.WriteLine("\nThat does not exist.");
          Console.WriteLine("Type 'new' to make a character or anything else to exit.");
			    Σ.rector = Console.ReadLine().ToLower();
          if(Σ.rector=="new")Utor();
          else Environment.Exit(0);
        }
      }
    }

    
    // WAP XAML
    
    public string UtOCr(int n, string v=""){
      if(n==0){
        return "Welcome to the character creation. Insert your first name, return and then your surname."; 
      } else if(n==1){
        Σ.notou = v;
      } else if(n==2){
				Σ.notod = v;
				PersonaN(Σ.notou, Σ.notod);
        return "Welcome into existence, "+this.Cognomen+"-boy.";
      } else if(n==3){
        int[] cybus = new int[6];
				for(int i=1; i < 6; i++){
					cybus[i]=Mechanicae.Volvere(4)+10;
					if(i==5){
						PersonaV(cybus[1], cybus[2], cybus[3], cybus[4], cybus[5]);
					}
				}
        return "STR: "+this.Vigor+"\n"+"DEX: "+this.Dexteritate+"\n"+"CON: "+this.Conditio+"\n"+"INT: "+this.Intelligentia+"\n"+"WIS: "+this.Sapientia;
      } else if(n==4){
        int[] cybus = new int[6];
				for(int i=1; i < 6; i++){
					cybus[i]=Mechanicae.Volvere(20);
					if(i==5){
						PersonaV(cybus[1], cybus[2], cybus[3], cybus[4], cybus[5]);
					}
				}
        return "STR: "+this.Vigor+"\n"+"DEX: "+this.Dexteritate+"\n"+"CON: "+this.Conditio+"\n"+"INT: "+this.Intelligentia+"\n"+"WIS: "+this.Sapientia;
      }
      return ""; 
    }
    public string PortOC(int n, string v=""){
      if(n==0){
        return "Recollect his family name from the depths of your memory:";
      } else if(n==1){
        if (File.Exists(".\\Baratrum\\" + v + ".jkk")){
          this.Porto(v);

          return "Welcome back, "+this.Cognomen+"-boy.";
        } else{
          return "That does not exist.";     
        }
      }
      return "";
    }


    // Jigoku Kara Kita

    public void Salvare(){
      if(!Directory.Exists(".\\Baratrum\\"))Directory.CreateDirectory(".\\Baratrum\\");

      BinaryFormatter bi = new BinaryFormatter();
      FileStream file = File.Create(".\\Baratrum\\" + this.Cognomen + ".jkk");

      Herctum data = new Herctum();

      data.nomen = this.Nomen;
      data.cognomen = this.Cognomen;

      data.Gtypus = this.Genus.typus;
      data.ordo = this.Ordo;
      data.pv = this.PV;
      data.pm = this.PM;
      data.credits = this.Credits;
      data.repertoire = this.Repertoire;
      data.repertoireB = this.RepertoireB;
      data.actus = this.Actus;
      data.metier = this.Metier;
      data.peritia = this.Peritia;

      data.Vigor = this.Vigor;
      data.Dexteritate = this.Dexteritate;
      data.Conditio = this.Conditio;
      data.Intelligentia = this.Intelligentia;
      data.Sapientia = this.Sapientia;

      data.altitudo = this.Altitudo;
      data.latitudo = this.Latitudo;
      data.crassitudo = this.Crassitudo;
      data.pondus = this.Pondus;
      data.spatium = this.Spatium;
      data.carnatio = this.Carnatio;
      data.planitia = this.Planitia;
      data.caput = this.Caput;
      data.ocullus = this.Ocullus;
      data.collum = this.Collum;
      data.cor = this.Cor;
      data.tergum = this.Tergum;
      data.bracchium = this.Bracchium;
      data.stomachus = this.Stomachus;
      data.crus = this.Crus;
      
      data.capacitas = this.Capacitas;
      data.potentia = this.Potentia;
      data.celeritas = this.Celeritas;
      data.accuratio = this.Accuratio;
      data.perceptio = this.Perceptio;

      data.agilitas = this.Agilitas;
      data.accuratioP = this.AccuratioP;
      data.perceptioP = this.PerceptioP;
      data.agiT = this.AgiT;
      data.perT = this.PerT;
      data.casT = this.CasT;

      data.convertioMechanica = this.ConvertioMechanica;
      data.liguritio = this.Liguritio;
      data.fluentaAnima = this.FluentaAnima;
      data.corpusAptus = this.CorpusAptus;

      data.armaN = this.Arma.Nomen;
      for(int u=0;u<this.Archivum.Length;u++)if(this.Archivum[u]!=null)data.panaN[this.Archivum[u].Nomen]=this.Archivum[u].Quantitas;

      bi.Serialize(file, data);
      file.Close();
    }
    public void Porto(string cog){
      if (File.Exists(".\\Baratrum\\" + cog + ".jkk")){
        BinaryFormatter bi = new BinaryFormatter();
        FileStream file = File.Open(".\\Baratrum\\" + cog + ".jkk", FileMode.Open);

        Herctum data = (Herctum)bi.Deserialize(file);
        file.Close();

        this.Nomen = data.nomen; 
        this.Cognomen = data.cognomen; 

        this.Genus.typus = data.Gtypus; 
        this.Ordo = data.ordo;
        this.PV = data.pv; 
        this.PM = data.pm; 
        this.Credits = data.credits;
        this.Repertoire = data.repertoire;
        this.RepertoireB = data.repertoireB;
        this.Actus = data.actus;
        this.Metier = data.metier;
        this.Peritia = data.peritia;

        this.Vigor = data.Vigor; 
        this.Dexteritate = data.Dexteritate; 
        this.Conditio = data.Conditio; 
        this.Intelligentia = data.Intelligentia; 
        this.Sapientia = data.Sapientia; 

        this.Altitudo = data.altitudo; 
        this.Latitudo = data.latitudo; 
        this.Crassitudo = data.crassitudo; 
        this.Pondus = data.pondus; 
        this.Spatium = data.spatium; 
        this.Carnatio = data.carnatio; 
        this.Planitia = data.planitia; 
        this.Caput = data.caput; 
        this.Ocullus = data.ocullus; 
        this.Collum = data.collum; 
        this.Cor = data.cor; 
        this.Tergum = data.tergum; 
        this.Bracchium = data.bracchium; 
        this.Stomachus = data.stomachus; 
        this.Crus = data.crus; 
        
        this.Capacitas = data.capacitas; 
        this.Potentia = data.potentia; 
        this.Celeritas = data.celeritas; 
        this.Accuratio = data.accuratio; 
        this.Perceptio = data.perceptio; 

        this.Agilitas = data.agilitas; 
        this.AccuratioP = data.accuratioP; 
        this.PerceptioP = data.perceptioP;
        this.AgiT = data.agiT; 
        this.PerT = data.perT; 
        this.CasT = data.casT; 

        this.ConvertioMechanica = data.convertioMechanica; 
        this.Liguritio = data.liguritio; 
        this.FluentaAnima = data.fluentaAnima; 
        this.CorpusAptus = data.corpusAptus;
        
        this.panaN = data.panaN;
        foreach(var u in data.panaN){
          for(int d=0;d<this.Archivum.Length;d++){
            if(this.Archivum[d]==null){
              this.Archivum[d]=Caussae.Acquirere(u.Key, u.Value);
              break;
            }
          }
        }

        this.Arma = Arma.Ornare(data.armaN.ToLower());
        this.Virtus();
      }
    }
    public void Scribere(string cog){
      using (FileStream text = new FileStream(".\\Baratrum\\" + cog + ".txt", FileMode.Create)){
        using (StreamWriter writer = new StreamWriter(text)){
          writer.WriteLine("******************************************************************************************\n");
          writer.WriteLine(this.Nomen+" "+this.Cognomen);
          writer.WriteLine(this.Genus.typus);
          writer.WriteLine("PV: "+this.PV[1]+"/"+this.PV[0]);
          writer.WriteLine("MP: "+this.PM[1]+"/"+this.PM[0]);
          writer.WriteLine("Credits: "+this.Credits);
          writer.WriteLine("Classes--> ");
          foreach(var u in this.Ordo)writer.WriteLine(u.Key);
          writer.WriteLine("");
          writer.WriteLine("Attributes--> ");
          writer.WriteLine("STR: "+this.Vigor[0]);
          writer.WriteLine("DEX: "+this.Dexteritate[0]);
          writer.WriteLine("CON: "+this.Conditio[0]);
          writer.WriteLine("INT: "+this.Intelligentia[0]);
          writer.WriteLine("WIS: "+this.Sapientia[0]);
          writer.WriteLine("");
          writer.WriteLine("Parameters--> ");
          writer.WriteLine("Capacity: "+this.Capacitas);
          writer.WriteLine("Potency: "+this.Potentia);
          writer.WriteLine("Speed: "+this.Celeritas);
          writer.WriteLine("Precision: "+this.Accuratio);
          writer.WriteLine("Perception: "+this.Perceptio);
          writer.WriteLine("");
          writer.WriteLine("Proportions--> ");
          writer.WriteLine("Height: "+this.Altitudo);
          writer.WriteLine("Width: "+this.Latitudo);
          writer.WriteLine("Thickness: "+this.Crassitudo[0]);
          writer.WriteLine("Reach: "+this.Spatium[1]);
          writer.WriteLine("Weight: "+this.Pondus);
          writer.WriteLine("Volume: "+this.Carnatio);
          writer.WriteLine("Front: "+this.Planitia[0]);
          writer.WriteLine("Side: "+this.Planitia[1]);
					writer.WriteLine("Head: "+this.Caput[2]+"cm²");
          writer.WriteLine("Eyes: "+this.Ocullus[2]+"cm²");
          writer.WriteLine("Neck: "+this.Collum[2]+"cm²");
          writer.WriteLine("Heart: "+this.Cor[2]+"cm²");
          writer.WriteLine("Spine: "+this.Tergum[2]+"cm²");
          writer.WriteLine("Arms: "+this.Bracchium[2]+"cm²");
          writer.WriteLine("Stomach: "+this.Stomachus[2]+"cm²");
          writer.WriteLine("Legs: "+this.Crus[2]+"cm²");
          writer.WriteLine("");
          writer.WriteLine("Actions--> ");
          for(int u=0;u<this.Actus.Length;u++){if(this.Actus[u]!=null)writer.WriteLine(this.Actus[u]);}
          writer.WriteLine("");
          writer.WriteLine("Buffs--> ");
          foreach(var u in this.RepertoireB)writer.WriteLine(u.Key);
          writer.WriteLine("");
          writer.WriteLine("Spells--> ");
          for(int u=0;u<this.Repertoire.Length;u++){if(this.Repertoire[u]!=null)writer.WriteLine(this.Repertoire[u]);}
          writer.WriteLine("");
          writer.WriteLine("Passives--> ");
          writer.WriteLine("Mechanical Conversion: "+this.ConvertioMechanica);
          writer.WriteLine("Gracefulness: "+this.Liguritio);
          writer.WriteLine("Energy Flow: "+this.FluentaAnima);
          writer.WriteLine("Fitness: "+this.CorpusAptus);
          writer.WriteLine("");
          writer.WriteLine("Mastery--> ");
          foreach (var u in this.Peritia)writer.WriteLine(u.Key+" "+u.Value);
          writer.WriteLine("");
          writer.WriteLine("Knowledge--> ");
          foreach (var u in this.Metier)writer.WriteLine(u.Key+" "+u.Value);
          writer.WriteLine("");
          writer.WriteLine("Moves--> ");
          writer.WriteLine("");
          writer.WriteLine("Inventory--> ");
          foreach(var u in this.panaN)writer.WriteLine(u.Key+" x"+u.Value);
          writer.WriteLine("\n******************************************************************************************");
        }
      }
    }
    
    // Variabilis

		public string Nomen{get; set;}
		public string Cognomen{get; set;}
		public Genus Genus = new Genus();
		public int[] PV{get; set;}
		public double[] PM{get; set;}
    public double Credits{get; set;}
    public Dictionary<string, bool> Ordo = new Dictionary<string, bool>();
    public Mana Mana = new Mana();
    public string[] Repertoire=new string[20];
    public Dictionary<string, string> RepertoireB = new Dictionary<string, string>();
    public string[] Actus = new string[20];
    public Dictionary<string, int> Metier = new Dictionary<string, int>();
    public Dictionary<string, int> Peritia = new Dictionary<string, int>();
    
		public int[] Vigor = new int[2];
		public int[] Dexteritate = new int[2];
		public int[] Conditio = new int[2];
		public int[] Intelligentia = new int[2];
		public int[] Sapientia = new int[2];

		public double Altitudo{get; set;}
		public double Latitudo{get; set;}
		public double[] Crassitudo{get; set;}
		public double Pondus{get; set;}
		public double[] Spatium{get; set;}
		public double Carnatio{get; set;}
    public double[] Planitia{get; set;}
    public double[] Caput{get; set;}
    public double[] Ocullus{get; set;}
    public double[] Collum{get; set;}
    public double[] Cor{get; set;}
    public double[] Tergum{get; set;}
    public double[] Bracchium{get; set;}
    public double[] Stomachus{get; set;}
    public double[] Crus{get; set;}
		
		public int Capacitas{get; private set;}
		public int Potentia{get; private set;}
		public double Celeritas{get; private set;}
		public double Accuratio{get; private set;}
		public double Perceptio{get; private set;}

		public int Agilitas{get; private set;}
		public int AccuratioP{get; private set;}
		public int PerceptioP{get; private set;}
    public double AgiT{get; private set;}
    public double PerT{get; private set;}
    public double CasT{get; private set;}

		public int ConvertioMechanica{get; private set;}
		public int Liguritio{get; private set;}
		public int FluentaAnima{get; private set;}
		public int CorpusAptus{get; private set;}

    public Arma Arma = new Arma();
    public Dictionary<string, int> panaN = new Dictionary<string, int>();
    public Caussae[] Archivum = new Caussae[20];

    public double Motus{get; set;}
    public double Tempus{get; set;}
    // public double[] Lotus{get; set;}
    public Lotus Lotus;

    public string verb;
    public int sum=0;
    public double dix=0;
    public bool rec=false;
    public bool ergo=false;
    public bool mag=false;
    public bool inferi=false;
    public bool leavo=false;

    public Yuno Yuno = new Yuno();
    public string Sensus="Mulus";

    public Regio Regio = new Regio();
  }
}
    /*  Use Purgo for debugging to skip to name, roll or race phase.
        It is possible to call the constructor with name, race, attributes, proportions and passives, but it lacks the actual race creator.
        Those can also be called apart with PesonaN, V and D with Virtus for parameters.
        Index calls either attributes, parameters or proportions.
        Epistola lists the entire sheet.*/