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
			this.Vigor=vigor;
			this.Dexteritate=dexteritate;
			this.Conditio=conditio;
			this.Intelligentia=intelligentia;
			this.Sapientia=sapientia;

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

      this.PeritiaLamina=0;
      this.PeritiaDistantia=0;
      this.MagisteriumGladium=0;
      this.MagisteriumLongumGladium=0;
      this.MagisteriumBaculum=0;
      this.MagisteriumArcum=0;
      this.MagisteriumSicarum=0;

      this.VigorB=new string[11];
      this.ConditioB=new string[11];
      this.DexteritateB=new string[11];
      this.IntelligentiaB=new string[11];
      this.SapientiaB=new string[11];

      Virtus();
      Genus.Renovamen(genus);

      this.Repertoire=new string[20];
      this.Actus=new string[20];
      this.Actus[0]="Step";
      this.Actus[1]="Wait";

      this.Motus=0;
      this.Tempus=0;
      this.Lotus=new double[2];
      this.Lotus[0]=0;
      this.Lotus[1]=0;
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
					for(int i=1; i < 6; i++){
						cybus[i]=Mechanicae.Volvere(4)+10;
						if(i==5){
							PersonaV(cybus[1], cybus[2], cybus[3], cybus[4], cybus[5]);
							}
						}           
				} else if(Σ.rector=="wild"){
						int[] cybus = new int[6];
						for(int i=1; i < 6; i++){
							cybus[i]=Mechanicae.Volvere(20);
							if(i==5){
								PersonaV(cybus[1], cybus[2], cybus[3], cybus[4], cybus[5]);
							}
						}
				} else{
						Σ.rector ="virtus";
				}
			}while(Σ.rector=="virtus");
			
			do{
				Console.WriteLine("\nChoose your race.\nTheir details are found on the ULF TRPG documentation; which you should have read before coming here.");
				Console.WriteLine("All basic races are available; 'human', 'orc', 'vampire', 'dwarf', 'elf' and 'werewolf'.");

				Genus.Linea(Console.ReadLine().ToLower());
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
      if(Σ.rector=="sheet"){
        Epistola();
      }

      Console.WriteLine("Do you wish to 'save' this character?");
			Σ.rector=Console.ReadLine().ToLower();
      if(Σ.rector=="save"){
        Salvare();
      }

      Console.WriteLine("Print sheet to .txt?");
      Σ.rector = Console.ReadLine();
      if(Σ.rector=="yes"){
        Scribere(Cognomen);
      }
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
              for(int i=1; i < 6; i++){
                cybus[i]=Mechanicae.Volvere(4)+10;
                if(i==5){
                  PersonaV(cybus[1], cybus[2], cybus[3], cybus[4], cybus[5]);
                  }
                }           
            } else if(Σ.rector=="wild"){
                int[] cybus = new int[6];
                for(int i=1; i < 6; i++){
                  cybus[i]=Mechanicae.Volvere(20);
                  if(i==5){
                    PersonaV(cybus[1], cybus[2], cybus[3], cybus[4], cybus[5]);
                  }
                }
            } else{
                Σ.rector ="virtus";
            }
          }while(Σ.rector=="virtus");
      } else if(insectum=="genus"){
          do{
            Console.WriteLine("Choose your race.\nTheir details are found on the ULF TRPG documentation; which you should have read before coming here.");
            Console.WriteLine("All basic races are available; 'human', 'orc', 'vampire', 'dwarf', 'elf' and 'werewolf'.");
            Index();
            this.Genus.typus = Console.ReadLine().ToLower();

            Console.WriteLine(">Integrum\n>Cisterna\n>Mensura.");
            Σ.rector = Console.ReadLine().ToLower();
            if(Σ.rector=="cisterna"){
              Genus.Cisterna(this.Genus.typus);
            } else if(Σ.rector=="mensura"){
              Genus.Mensura(this.Genus.typus);
            } else{
              Genus.Linea(this.Genus.typus);
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
			this.Vigor=vigor;
			this.Dexteritate=dexteritate;
			this.Conditio=conditio;
			this.Intelligentia=intelligentia;
			this.Sapientia=sapientia;
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
		public void Virtus(){
			this.Capacitas=Mechanicae.Capacitas(this.Vigor, this.ConvertioMechanica);
			this.Potentia=Mechanicae.Capacitas(this.Intelligentia, this.FluentaAnima);
			this.Celeritas=Mechanicae.Celeritas(this.Dexteritate, this.CorpusAptus);
			this.Accuratio=Mechanicae.Accuratio(this.Dexteritate, this.AccuratioP);
			this.Perceptio=Mechanicae.Perceptio(this.Sapientia, this.PerceptioP);

      this.AgiT=Mechanicae.Lapsus(Celeritas);
      this.PerT=Mechanicae.Lapsus(Perceptio);
      this.CasT=Mechanicae.Lapsus(Intelligentia);

      this.Spatium[1] = this.Spatium[0] + Arma.Spatium;
		}
    public void InitusOrdo(string ordo=""){
      
      switch(ordo){
        case "swordsman":
          this.Ordo["Swordsman"]=true;

          Discere("PL");
          Discere("VB");
          Discere("DB");
          Discere("CB");
          this.Addicio("actus", "Slash", "Thrust");
          // Goat Leather Armour

          Console.WriteLine("Do you wish for 'Sword' Mastery or 'Long' Sword Mastery?");
			    Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="long"||Σ.rector=="long sword"){
            Discere("MLG");
            this.ArchAdd(Caussae.Acquirere("Steel Long Sword"));
            this.Arma=Arma.Ornare("Steel Long Sword");
          } else{
            Discere("MG");
            this.ArchAdd(Caussae.Acquirere("Steel Sword"));
            this.Arma=Arma.Ornare("Steel Sword");
          }
          Console.WriteLine("\nYou are a Swordsman; a progressive agressive class of the melee tree.");
			    Console.ReadLine();
          break;
        case "elementalist":
          this.Ordo["Elementalist"]=true;

          Discere("MB");//mastery and spell
          Discere("IB");//resistance I E
          this.Addicio("actus", "Cast", "Strike");

          this.ArchAdd(Caussae.Acquirere("Chestnut Staff")); //Simple Robe Set
          this.Arma=Arma.Ornare("Chestnut Staff");

          do{
            Console.WriteLine("\nWhich elementar discipline do you wish to follow?");
            Console.WriteLine("\n*****pyromancy with Fireball and glacemancy with Icicle are the only choices for now*****");
			      Σ.rector=Console.ReadLine().ToLower();

            switch(Σ.rector){
              case "pyromancy":
                Mana.Disciplinae("pyro", 1);
                break;
              case "aermancy":
                Mana.Disciplinae("aer", 1);
                break;
              case "aquamancy":
                Mana.Disciplinae("aqua", 1);
                break;
              case "taromancy":
                Mana.Disciplinae("taro", 1);
                break;
              case "glacemancy":
                Mana.Disciplinae("glace", 1);
                break;
              case "denkoumancy":
                Mana.Disciplinae("denkou", 1);
                break;
              case "almancy":
                Mana.Disciplinae("al", 1);
                break;
              case "yamimancy":
                Mana.Disciplinae("yami", 1);
                break;
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

          Console.WriteLine("\nYou are an Elementalist; a sorcerer class of the mage tree.");
			    Console.ReadLine();
          break;
        case "archer":
          this.Ordo["Archer"]=true;

          Discere("PD");
          Discere("MA");
          Discere("DB");
          Discere("SB");
          this.ArchAdd(Caussae.Acquirere("Maple Bow"));
          this.Arma=Arma.Ornare("Maple Bow");

          Console.WriteLine("Do you want 30 'Light' Arrows or 20 'Heavy' Arrows?");
			    Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="heavy"||Σ.rector=="heavy arrows"){
            this.ArchAdd(Caussae.Acquirere("Heavy Arrow", 20));
          } else{
            this.ArchAdd(Caussae.Acquirere("Light Arrow", 30));
          }
          Console.WriteLine("\nYou are an Archer; a hunter class of the ranged tree.");
			    Console.ReadLine();
          break;
        case "rogue":
          this.Ordo["Rogue"]=true;

          Discere("PL");
          Discere("MS");
          Discere("DB");
          Discere("SB");
          this.Addicio("actus", "Slash", "Thrust");
          this.ArchAdd(Caussae.Acquirere("Steel Dagger"));//Goat Leather Armour
          this.Arma=Arma.Ornare("Steel Dagger");

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
    public void Discere(string dis, int livel=1, string sco="E"/*Ego Autrem Duo*/){

      switch(dis){
        case "MLG":
          switch(livel){
            case 5:
              //call
              break;
            case 4:
              //call
              break;
            case 3:
              //call
              break;
            case 2:
              //call
              break;
            case 1:
              this.MagisteriumLongumGladium=1;
              this.Vigor++;
              break;
          }
          break;
        case "MG":
          switch(livel){
            case 5:
              //call
              break;
            case 4:
              //call
              break;
            case 3:
              //call
              break;
            case 2:
              //call
              break;
            case 1:
              this.MagisteriumGladium=1;
              this.Dexteritate++;
              break;
          }
          break;
        case "MS":
          switch(livel){
            case 5:
              //call
              break;
            case 4:
              //call
              break;
            case 3:
              //call
              break;
            case 2:
              //call
              break;
            case 1:
              this.MagisteriumSicarum=1;
              this.Dexteritate++;
              break;
          }
          break;
        case "MA":
          switch(livel){
            case 5:
              //call
              break;
            case 4:
              //call
              break;
            case 3:
              //call
              break;
            case 2:
              //call
              break;
            case 1:
              this.MagisteriumArcum=1;
              this.Dexteritate++;
              break;
          }
          break;
        case "MB":
          switch(livel){
            case 5:
              //call
              break;
            case 4:
              //call
              break;
            case 3:
              //call
              break;
            case 2:
              //call
              break;
            case 1:
              this.MagisteriumBaculum=1;
              this.Intelligentia++;
              break;
          }
          break;
        case "PD":
          switch(livel){
            case 5:
              //call
              break;
            case 4:
              //call
              break;
            case 3:
              //call
              break;
            case 2:
              //call
              break;
            case 1:
              this.PeritiaDistantia=1;
              break;
          }
          break;
        case "PL":
          switch(livel){
            case 5:
              //call
              break;
            case 4:
              //call
              break;
            case 3:
              //call
              break;
            case 2:
              //call
              break;
            case 1:
              this.PeritiaLamina=1;
              break;
          }
          break;
        case "VB":
          switch(livel){
            case 5:
              //call
              break;
            case 4:
              //call
              break;
            case 3:
              this.VigorB[3]=sco;
              break;
            case 2:
              this.VigorB[2]=sco;
              break;
            case 1:
              this.VigorB[1]=sco;
              break;
          }
          break;
        case "DB":
          switch(livel){
            case 5:
              //call
              break;
            case 4:
              //call
              break;
            case 3:
              this.DexteritateB[3]=sco;
              break;
            case 2:
              this.DexteritateB[2]=sco;
              break;
            case 1:
              this.DexteritateB[1]=sco;
              break;
          }
          break;
        case "CB":
          switch(livel){
            case 5:
              //call
              break;
            case 4:
              //call
              break;
            case 3:
              this.ConditioB[3]=sco;
              break;
            case 2:
              this.ConditioB[2]=sco;
              break;
            case 1:
              this.ConditioB[1]=sco;
              break;
          }
          break;
        case "IB":
          switch(livel){
            case 5:
              //call
              break;
            case 4:
              //call
              break;
            case 3:
              this.IntelligentiaB[3]=sco;
              break;
            case 2:
              this.IntelligentiaB[2]=sco;
              break;
            case 1:
              this.IntelligentiaB[1]=sco;
              break;
          }
          break;
        case "SB":
          switch(livel){
            case 5:
              //call
              break;
            case 4:
              //call
              break;
            case 3:
              this.SapientiaB[3]=sco;
              break;
            case 2:
              this.SapientiaB[2]=sco;
              break;
            case 1:
              this.SapientiaB[1]=sco;
              break;
          }
          break;
        default:
          Console.WriteLine("A mispelling error must have occured.");
          Console.Read();
          break;
      }
    }

		public void Index(string petitio="attributes"){
			switch(petitio){
				case "attributes":
					Console.WriteLine("STR: "+this.Vigor+"\n"+"DEX: "+this.Dexteritate+"\n"+"CON: "+this.Conditio+"\n"+"INT: "+this.Intelligentia+"\n"+"WIS: "+this.Sapientia);
					break;
				case "parameters":
					Console.WriteLine("Capacity: "+this.Capacitas+"\n"+"Potency: "+this.Potentia+"\n"+"Speed: "+this.Celeritas+"\n"+"Precision: "+this.Accuratio+"\n"+"Perception: "+this.Perceptio);
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
        for(int u=0;u<this.Archivum.Length;u++){
          if(this.Archivum[u]==null){

          } else{
            Console.WriteLine(this.Archivum[u].Nomen+" x"+this.Archivum[u].Quantitas);
          }
        }
      } else if(verbum=="repertoire"){
        for(int u=0;u<this.Repertoire.Length;u++){
          if(this.Repertoire[u]==null){

          } else{
            Console.WriteLine(this.Repertoire[u]);
          }
        }
      } else if(verbum=="actus"){
        for(int u=0;u<this.Actus.Length;u++){
          if(this.Actus[u]==null){

          } else{
            Console.WriteLine(this.Actus[u]);
          }
        }
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

    public void ArchAdd(params Caussae[] mers){
      for(int u=0;u<mers.Length;u++){
        for(int d=0;d<this.Archivum.Length;d++){
          if(this.Archivum[d]==null){
            this.Archivum[d]=mers[u];
            this.panaN[mers[u].Nomen]=mers[u].Quantitas;
            if(mers[u].Quantitas>1){
              Console.WriteLine("\nYou have acquired "+mers[u].Nomen+" x"+mers[u].Quantitas+"!");
            } else{
              Console.WriteLine("\nYou have acquired "+mers[u].Nomen+"!");
            }
            break;
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
      
    }

    public void Dominatus(){
      foreach (var u in this.Ordo){
        Console.WriteLine(u.Key);
      }
    }
    public void Laevo(){
      string romanus="";
      for(int i=0;i<this.VigorB.Length;i++){
        switch(i){
          case 1:
            romanus="I";
            break;
          case 2:
            romanus="II";
            break;
          case 3:
            romanus="III";
            break;
        }
        if(this.VigorB[i]==null){

        } else{
          Console.WriteLine("Strength "+romanus+"("+this.VigorB[i]+")");
        }
      }
      for(int i=0;i<this.DexteritateB.Length;i++){
        switch(i){
          case 1:
            romanus="I";
            break;
          case 2:
            romanus="II";
            break;
          case 3:
            romanus="III";
            break;
        }
        if(this.DexteritateB[i]==null){

        } else{
          Console.WriteLine("Agility "+romanus+"("+this.DexteritateB[i]+")");
        }
      }
      for(int i=0;i<this.ConditioB.Length;i++){
        switch(i){
          case 1:
            romanus="I";
            break;
          case 2:
            romanus="II";
            break;
          case 3:
            romanus="III";
            break;
        }
        if(this.ConditioB[i]==null){

        } else{
          Console.WriteLine("Endurance "+romanus+"("+this.ConditioB[i]+")");
        }
      }
      for(int i=0;i<this.IntelligentiaB.Length;i++){
        switch(i){
          case 1:
            romanus="I";
            break;
          case 2:
            romanus="II";
            break;
          case 3:
            romanus="III";
            break;
        }
        if(this.IntelligentiaB[i]==null){

        } else{
          Console.WriteLine("Potency "+romanus+"("+this.IntelligentiaB[i]+")");
        }
      }
      for(int i=0;i<this.SapientiaB.Length;i++){
        switch(i){
          case 1:
            romanus="I";
            break;
          case 2:
            romanus="II";
            break;
          case 3:
            romanus="III";
            break;
        }
        if(this.SapientiaB[i]==null){

        } else{
          Console.WriteLine("Focus "+romanus+"("+this.SapientiaB[i]+")");
        }
      }
    }
    public void Peritia(){
      if(this.PeritiaLamina>0){
        Console.WriteLine("Blade Proficiency: "+this.PeritiaLamina);
      }
      if(this.PeritiaDistantia>0){
        Console.WriteLine("Ranged Proficiency: "+this.PeritiaDistantia);
      }
      if(this.MagisteriumSicarum>0){
        Console.WriteLine("Dagger Mastery: "+this.MagisteriumSicarum);
      }
      if(this.MagisteriumGladium>0){
        Console.WriteLine("Sword Mastery: "+this.MagisteriumGladium);
      }
      if(this.MagisteriumLongumGladium>0){
        Console.WriteLine("Long Sword Mastery: "+this.MagisteriumLongumGladium);
      }
      if(this.MagisteriumBaculum>0){
        Console.WriteLine("Staff Mastery: "+this.MagisteriumBaculum);
      }
      if(this.MagisteriumArcum>0){
        Console.WriteLine("Bow Mastery: "+this.MagisteriumArcum);
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
			Dominatus();
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
      Laevo();
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
      Peritia();
      Console.ReadLine();
			Console.WriteLine("Knowledge--> ");
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
      
      if(Σ.rector!="old"){
        Utor();
      } else {
        Console.WriteLine("Recollect his family name from the depths of your memory:");
        Σ.rector = Console.ReadLine();
        if (File.Exists(".\\Baratrum\\" + Σ.rector + ".jkk")){
          Porto(Σ.rector);

          Console.WriteLine("Welcome back, "+this.Cognomen+"-boy.");

          Console.WriteLine("Show character sheet?");
          Σ.rector = Console.ReadLine().ToLower();
          if(Σ.rector=="yes"||Σ.rector=="y"){
            Epistola();
          }

          Console.WriteLine("Print sheet to .txt?");
          Σ.rector = Console.ReadLine().ToLower();
          if(Σ.rector=="yes"||Σ.rector=="y"){
            Scribere(this.Cognomen);
          }
        } else{
          Console.WriteLine("\nThat does not exist.");
          Console.WriteLine("Type 'new' to make a character or anything else to exit.");
			    Σ.rector = Console.ReadLine().ToLower();
          if(Σ.rector=="new"){
            Utor();
          } else{
            Environment.Exit(0);
          }         
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
      data.actus = this.Actus;

      data.vigor = this.Vigor;
      data.dexteritate = this.Dexteritate;
      data.conditio = this.Conditio;
      data.intelligentia = this.Intelligentia;
      data.sapientia = this.Sapientia;

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

      data.PeritiaLamina = this.PeritiaLamina;
      data.PeritiaDistantia = this.PeritiaDistantia;
      data.MagisteriumGladium = this.MagisteriumGladium;
      data.MagisteriumLongumGladium = this.MagisteriumLongumGladium;
      data.MagisteriumBaculum = this.MagisteriumBaculum;
      data.MagisteriumArcum = this.MagisteriumArcum;
      data.MagisteriumSicarum = this.MagisteriumSicarum;

      data.VigorB = this.VigorB;
      data.ConditioB = this.ConditioB;
      data.DexteritateB = this.DexteritateB;
      data.IntelligentiaB = this.IntelligentiaB;
      data.SapientiaB = this.SapientiaB;

      data.armaN = this.Arma.Nomen;
      for(int u=0;u<this.Archivum.Length;u++){
        if(this.Archivum[u]!=null){
          data.panaN[this.Archivum[u].Nomen]=this.Archivum[u].Quantitas;
        }
      }
      data.lotus = this.Lotus;

      bi.Serialize(file, data);
      file.Close();
    }
    public void Porto(string cog){
      if (File.Exists(".\\Baratrum\\" + cog + ".jkk"))
      {
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
      this.Actus = data.actus;

      this.Vigor = data.vigor; 
      this.Dexteritate = data.dexteritate; 
      this.Conditio = data.conditio; 
      this.Intelligentia = data.intelligentia; 
      this.Sapientia = data.sapientia; 

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

      this.PeritiaLamina = data.PeritiaLamina;
      this.PeritiaDistantia = data.PeritiaDistantia;
      this.MagisteriumGladium = data.MagisteriumGladium;
      this.MagisteriumLongumGladium = data.MagisteriumLongumGladium;
      this.MagisteriumBaculum = data.MagisteriumBaculum;
      this.MagisteriumArcum = data.MagisteriumArcum;
      this.MagisteriumSicarum = data.MagisteriumSicarum;

      this.VigorB = data.VigorB;
      this.ConditioB = data.ConditioB;
      this.DexteritateB = data.DexteritateB;
      this.IntelligentiaB = data.IntelligentiaB;
      this.SapientiaB = data.SapientiaB;
      
      foreach(var u in data.panaN){
        for(int d=0;d<this.Archivum.Length;d++){
          if(this.Archivum[d]==null){
            this.Archivum[d]=Caussae.Acquirere(u.Key, u.Value);
            break;
          }
        }
      }
      this.Lotus = data.lotus;

      this.Genus.Renovamen(this.Genus.typus);
      this.Arma = Arma.Ornare(data.armaN.ToLower());
      
      }
    }
    public void Scribere(string cog){
      using (FileStream text = new FileStream(".\\Baratrum\\" + cog + ".txt", FileMode.Create))
      {
        using (StreamWriter writer = new StreamWriter(text))
        {
          writer.WriteLine("******************************************************************************************\n");
          writer.WriteLine(this.Nomen+" "+this.Cognomen);
          writer.WriteLine(this.Genus.typus);
          writer.WriteLine("PV: "+this.PV[1]+"/"+this.PV[0]);
          writer.WriteLine("MP: "+this.PM[1]+"/"+this.PM[0]);
          writer.WriteLine("Credits: "+this.Credits);
          writer.WriteLine("Classes--> ");
          foreach (var u in this.Ordo){
            writer.WriteLine(u.Key);
          }
          writer.WriteLine("");
          writer.WriteLine("Attributes--> ");
          writer.WriteLine("STR: "+this.Vigor);
          writer.WriteLine("DEX: "+this.Dexteritate);
          writer.WriteLine("CON: "+this.Conditio);
          writer.WriteLine("INT: "+this.Intelligentia);
          writer.WriteLine("WIS: "+this.Sapientia);
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
          for(int i=0;i<this.Actus.Length;i++){
            if(this.Actus[i]==null){

            } else{
              writer.WriteLine(this.Actus[i]);
            }
          }
          writer.WriteLine("");
          writer.WriteLine("Buffs--> ");
          string romanus="";
          for(int i=0;i<this.VigorB.Length;i++){
            switch(i){
              case 1:
                romanus="I";
                break;
              case 2:
                romanus="II";
                break;
              case 3:
                romanus="III";
                break;
            }
            if(this.VigorB[i]==null){

            } else{
              writer.WriteLine("Strength "+romanus+"("+this.VigorB[i]+")");
            }
          }
          for(int i=0;i<this.DexteritateB.Length;i++){
            switch(i){
              case 1:
                romanus="I";
                break;
              case 2:
                romanus="II";
                break;
              case 3:
                romanus="III";
                break;
            }
            if(this.DexteritateB[i]==null){

            } else{
              writer.WriteLine("Agility "+romanus+"("+this.DexteritateB[i]+")");
            }
          }
          for(int i=0;i<this.ConditioB.Length;i++){
            switch(i){
              case 1:
                romanus="I";
                break;
              case 2:
                romanus="II";
                break;
              case 3:
                romanus="III";
                break;
            }
            if(this.ConditioB[i]==null){

            } else{
              writer.WriteLine("Endurance "+romanus+"("+this.ConditioB[i]+")");
            }
          }
          for(int i=0;i<this.IntelligentiaB.Length;i++){
            switch(i){
              case 1:
                romanus="I";
                break;
              case 2:
                romanus="II";
                break;
              case 3:
                romanus="III";
                break;
            }
            if(this.IntelligentiaB[i]==null){

            } else{
              writer.WriteLine("Potency "+romanus+"("+this.IntelligentiaB[i]+")");
            }
          }
          for(int i=0;i<this.SapientiaB.Length;i++){
            switch(i){
              case 1:
                romanus="I";
                break;
              case 2:
                romanus="II";
                break;
              case 3:
                romanus="III";
                break;
            }
            if(this.SapientiaB[i]==null){

            } else{
              writer.WriteLine("Focus "+romanus+"("+this.SapientiaB[i]+")");
            }
          }
          writer.WriteLine("");
          writer.WriteLine("Spells--> ");
          for(int i=0;i<this.Repertoire.Length;i++){
            if(this.Repertoire[i]==null){

            } else{
              writer.WriteLine(this.Repertoire[i]);
            }
          }
          writer.WriteLine("");
          writer.WriteLine("Passives--> ");
          writer.WriteLine("Mechanical Conversion: "+this.ConvertioMechanica);
          writer.WriteLine("Gracefulness: "+this.Liguritio);
          writer.WriteLine("Energy Flow: "+this.FluentaAnima);
          writer.WriteLine("Fitness: "+this.CorpusAptus);
          writer.WriteLine("");
          writer.WriteLine("Mastery--> ");
          if(this.PeritiaLamina>0){
            writer.WriteLine("Blade Proficiency: "+this.PeritiaLamina);
          }
          if(this.PeritiaDistantia>0){
            writer.WriteLine("Ranged Proficiency: "+this.PeritiaDistantia);
          }
          if(this.MagisteriumSicarum>0){
            writer.WriteLine("Dagger Mastery: "+this.MagisteriumSicarum);
          }
          if(this.MagisteriumGladium>0){
            writer.WriteLine("Sword Mastery: "+this.MagisteriumGladium);
          }
          if(this.MagisteriumLongumGladium>0){
            writer.WriteLine("Long Sword Mastery: "+this.MagisteriumLongumGladium);
          }
          if(this.MagisteriumBaculum>0){
            writer.WriteLine("Staff Mastery: "+this.MagisteriumBaculum);
          }
          if(this.MagisteriumArcum>0){
            writer.WriteLine("Bow Mastery: "+this.MagisteriumArcum);
          }
          writer.WriteLine("");
          writer.WriteLine("Knowledge--> ");
          writer.WriteLine("");
          writer.WriteLine("Moves--> ");
          writer.WriteLine("");
          writer.WriteLine("Inventory--> ");
          foreach(var u in panaN){
            writer.WriteLine(u.Key+" x"+u.Value);
          }
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
    public string[] Repertoire{get; set;}
    public string[] Actus{get; set;}
    
		public int Vigor{get; set;}
		public int Dexteritate{get; set;}
		public int Conditio{get; set;}
		public int Intelligentia{get; set;}
		public int Sapientia{get; set;}

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

    public int PeritiaLamina{get; set;}
    public int PeritiaDistantia{get; set;}
    public int MagisteriumGladium{get; set;}
    public int MagisteriumLongumGladium{get; set;}
    public int MagisteriumBaculum{get; set;}
    public int MagisteriumArcum{get; set;}
    public int MagisteriumSicarum{get; set;}

    public string[] VigorB{get; set;}
    public string[] ConditioB{get; set;}
    public string[] DexteritateB{get; set;}
    public string[] IntelligentiaB{get; set;}
    public string[] SapientiaB{get; set;}

    public Arma Arma = new Arma();
    public Dictionary<string, int> panaN = new Dictionary<string, int>();
    public Caussae[] Archivum = new Caussae[20];

    public double Motus{get; set;}
    public double Tempus{get; set;}
    public double[] Lotus{get; set;}

    public string verb;
    public int sum=0;
    public double dix=0;
    public bool rec=false;
    public bool ergo=false;
    public bool mag=false;
    public bool inferi=false;

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