using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ULF
{
  public static class Mechanicae
  {
    static Dictionary<string, Objectum> Objectum = new Dictionary<string, Objectum>();
    static double[] res = new double[2058];
    static string[] acc = new string[2058];
    static string[] obj = new string[666];
    static int machQ = 2058;
    static int plurimas = 0;
    static int velo;


    public static void Utor(){
      
      Console.WriteLine(intro);
      Σ.rector = Console.ReadLine().ToLower();
      
      switch(Σ.rector){
        case "on":
          do{
            Promptus();
          } while (Σ.rector == "");
          Utor();
          break;
        case "doc":
          Console.WriteLine(scriptum);
          Console.ReadLine();
          Utor();
          break;
        case "calculate":
          Calculate();
          Utor();
          break;
        case "objects":
          Artificium();
          Utor();
          break;
        case "mob":
          Deux();
          Utor();
          break;
        case "roll4":
          Σ.rector = Console.ReadLine();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          Volvere(4, Σ.unus);
          Utor();
          break;
        case "roll6":
          Σ.rector = Console.ReadLine();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          Volvere(6, Σ.unus);
          Console.ReadLine();
          Utor();
          break;
        case "roll8":
          Σ.rector = Console.ReadLine();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          Volvere(8, Σ.unus);
          Console.ReadLine();
          Utor();
          break;
        case "roll10":
          Σ.rector = Console.ReadLine();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          Volvere(10, Σ.unus);
          Console.ReadLine();
          Utor();
          break;
        case "roll12":
          Σ.rector = Console.ReadLine();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          Volvere(12, Σ.unus);
          Console.ReadLine();
          Utor();
          break;
        case "roll20":
          Σ.rector = Console.ReadLine();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          Volvere(20, Σ.unus);
          Console.ReadLine();
          Utor();
          break;
        case "roll100":
          Σ.rector = Console.ReadLine();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          Volvere(1000, Σ.unus);
          Console.ReadLine();
          Utor();
          break;
        case "roll%":
          Σ.rector = Console.ReadLine();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          Volvere(100, Σ.unus);
          Console.ReadLine();
          Utor();
          break;
        case "froll":
          Σ.rector = Console.ReadLine();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          LVolvere(Σ.unus);
          Console.ReadLine();
          Utor();
          break;
        default:
          Console.WriteLine("Pass on to Adventum with whom?\nLeave empty to exit.\nUse 'ego' if you have come here as a character.");
          Σ.rector=Console.ReadLine();
          if(Σ.rector==""){
            Environment.Exit(0);
          } else{
            if(Σ.rector=="ego"){
              Adventum.Utor(Primor.homo);
            } else{
              Adventum.Utor(Primor.Hostis[Σ.rector]);
            }   
          }
          break;
      }
    }

    // Volvere Tesserae

    public static int Volvere(int pretium=20, int volutare=1, int mut=0, string nomen="The dice"){
      Random cybus = new Random();
      int tessera;
      int tesserae =0;

      for(int i=0; i < volutare;i++){
        if(pretium == 4 ||pretium == 6 ||pretium == 8 ||pretium == 10 ||pretium == 12 ||pretium == 20){
          tessera=cybus.Next(1, pretium+1);
          Console.WriteLine(nomen+" rolls "+tessera+" on a d"+pretium+"!");
          tesserae+=tessera+mut;
      } else if(pretium == 100){
          tessera=cybus.Next(0, pretium+1);
          Console.WriteLine(nomen+" rolls "+tessera+" on a 0-100 ULF percentile!");
          tesserae+=tessera+mut;
      } else if(pretium == 1000){
          tessera=cybus.Next(1, pretium-899);
          Console.WriteLine(nomen+" rolls "+tessera+" on a d"+pretium+"!");
          tesserae+=tessera+mut;
      } else if(pretium==1){
        tessera=1;
        Console.WriteLine("That is one.");
        tesserae+=tessera+mut;
      }else{
          LVolvere(pretium, 1, volutare, mut);
        }
      } 
      return tesserae;          
    }
    public static int LVolvere(int pretium=1, int radix=1, int volutare=1, int mut=0, string nomen="The dice"){
      Random cybus = new Random();
      int tessera;
      int tesserae=0;

      for(int i=0; i < volutare;i++){
        tessera = cybus.Next(radix, pretium+1);
        Console.WriteLine(nomen+" rolls "+tessera+" on a d"+radix+"-"+pretium+"!");
        tesserae+=tessera+mut;
      }
      return tesserae;
    }

    // Conputat Impetum 

    public static void PulsareJux(Persona Ego, Arma arma, Persona hostis, string dir="front", bool demi=false, int vis=-1, int dam=0, bool yuno=false){

      if(vis<0){
        vis=Ego.Capacitas;
      } else if(vis>Ego.Capacitas){
        vis=Ego.Capacitas;
      }

      demi=Peritia(arma.Peritia);
      if(Ego.Spatium[1]>=Calculus("hypod",Math.Abs(Ego.Lotus[0]-hostis.Lotus[0]),Math.Abs(Ego.Lotus[1]-hostis.Lotus[1]))){
        if(!yuno){
          Console.WriteLine("\nDo you wish to use your precision to 'hit' or to 'aim'?");
          Σ.rector = Console.ReadLine().ToLower();
        } else{
          Σ.rector = "hit";
        }
        
        if(Σ.rector=="aim"){
          Σ.num[0]=(11-((Ego.Dexteritate-Ego.Motus)-(hostis.Motus+hostis.Dexteritate)));

          Σ.unus = Volvere(20, nomen:Ego.Cognomen);
          Console.WriteLine(Ego.Cognomen+" rolls "+Σ.unus+" against "+Σ.num[0]+".");

          if (Σ.unus >= Σ.num[0]){

            if(dir=="front"){
              Console.WriteLine("\nWhat will you aim at?\nHead\nEye\nNeck\nHeart\nArm\nStomach\nLeg");
              Σ.rector = Console.ReadLine().ToLower();

              switch(Σ.rector){
                case "head":
                  Σ.num[1] = Praecisionem(Ego, hostis, hostis.Caput[2], typ: "fix");
                  Σ.notod = "the head";
                  break;
                case "eye":
                  Σ.num[1] = Praecisionem(Ego, hostis, hostis.Ocullus[2], typ: "fix");
                  Σ.notod = "an eye";
                  break;
                case "neck":
                  Σ.num[1] = Praecisionem(Ego, hostis, hostis.Collum[2], typ: "fix");
                  Σ.notod = "the neck";
                  break;
                case "heart":
                  Σ.num[1] = Praecisionem(Ego, hostis, hostis.Cor[2], typ: "fix");
                  Σ.notod = "the heart";
                  break;
                case "arm":
                  Σ.num[1] = Praecisionem(Ego, hostis, hostis.Bracchium[2], typ: "fix");
                  Σ.notod = "an arm";
                  break;
                case "stomach":
                  Σ.num[1] = Praecisionem(Ego, hostis, hostis.Stomachus[2], typ: "fix");
                  Σ.notod = "the stomach";
                  break;
                case "leg":
                  Σ.num[1] = Praecisionem(Ego, hostis, hostis.Crus[2], typ: "fix");
                  Σ.notod = "a leg";
                  break;
              }
            }
          
            if(demi){
              Σ.unus=Volvere(4, nomen:Ego.Cognomen);

              if(Σ.unus==1&&Primor.homo.Arma.Obtusus>0){
                Σ.unus=Primor.homo.Arma.Obtusus;
              } else if(Σ.unus==2&&Primor.homo.Arma.Acutus>0){
                Σ.unus=Primor.homo.Arma.Acutus;
              } else if(Σ.unus==3&&Primor.homo.Arma.Acutulus>0){
                Σ.unus=Primor.homo.Arma.Acutulus;
              } else{
                Σ.unus=Primor.homo.Arma.DamnumT;
              }
            } else{
              if(dam==1&&Primor.homo.Arma.Obtusus>0){
                Σ.unus=Primor.homo.Arma.Obtusus;
              } else if(dam==2&&Primor.homo.Arma.Acutus>0){
                Σ.unus=Primor.homo.Arma.Acutus;
              } else if(dam==3&&Primor.homo.Arma.Acutulus>0){
                Σ.unus=Primor.homo.Arma.Acutulus;
              } else{
                Σ.unus=Primor.homo.Arma.DamnumT;
              }
            }

            DanusPhysicus(Ego, vis, Σ.unus, arma.Pondus, pe:arma.Peritia, mut:arma.Deficio,gra:Ego.Liguritio);

            Crisimus(Ego, hostis, "aimed");
          } else{
            Console.WriteLine(Ego.Cognomen+" missed.");
          }
        } else{

          Σ.num[0]=(11-(((Ego.Dexteritate+Math.Round(Ego.Accuratio*1))-Ego.Motus)-(hostis.Motus+hostis.Dexteritate)));

          Σ.unus = Volvere(20, nomen:Ego.Cognomen);
          Console.WriteLine(Ego.Cognomen+" rolls "+Σ.unus+" against "+Σ.num[0]+".");

          if (Σ.unus >= Σ.num[0]){
            
            Battum(Ego);

            if(demi){
              Σ.unus=Volvere(4, nomen:Ego.Cognomen);

              if(Σ.unus==1&&Primor.homo.Arma.Obtusus>0){
                Σ.unus=Primor.homo.Arma.Obtusus;
              } else if(Σ.unus==2&&Primor.homo.Arma.Acutus>0){
                Σ.unus=Primor.homo.Arma.Acutus;
              } else if(Σ.unus==3&&Primor.homo.Arma.Acutulus>0){
                Σ.unus=Primor.homo.Arma.Acutulus;
              } else{
                Σ.unus=Primor.homo.Arma.DamnumT;
              }
            } else{
              if(dam==1&&Primor.homo.Arma.Obtusus>0){
                Σ.unus=Primor.homo.Arma.Obtusus;
              } else if(dam==2&&Primor.homo.Arma.Acutus>0){
                Σ.unus=Primor.homo.Arma.Acutus;
              } else if(dam==3&&Primor.homo.Arma.Acutulus>0){
                Σ.unus=Primor.homo.Arma.Acutulus;
              } else{
                Σ.unus=Primor.homo.Arma.DamnumT;
              }
            }
            
            DanusPhysicus(Ego, vis, Σ.unus, arma.Pondus, pe:arma.Peritia, mut:arma.Deficio,gra:Ego.Liguritio);

            Crisimus(Ego, hostis);
          } else{
            Console.WriteLine(Ego.Cognomen+" missed.");
          }
        }
      } else{
        Console.WriteLine(Ego.Cognomen+" cannot reach the target.");
      }
    }
    public static void PulsareLonge(Persona Ego, Persona hostis, int vis, int dan, double pon, int gra=1){
      Σ.num[0]=Praecisionem(Ego, hostis);
      Σ.unus=Volvere(100, nomen:Ego.Cognomen);
      Console.WriteLine(Ego.Cognomen+" rolls "+Σ.unus+" against "+Σ.num[0]+".");

      if(Σ.unus>=Σ.num[0]){
        
        Battum(Ego);
        DanusPhysicus(Ego, vis, dan, pon, gra:gra);
        Crisimus(Ego, hostis);
      } else{
        Console.WriteLine(Ego.Cognomen+" missed.");
      }
    }
    public static void DanusPhysicus(Persona Ego, int vis, int arm, double pon, bool demi=false, string pe="", int mut=0, int gra=1){
      demi=Peritia(pe);
      Σ.unus = Volvere(arm, mut: mut, nomen:Ego.Cognomen);
      Velocitas(vis, pon, gra);
      if(demi){
        Σ.num[0] = Math.Round((Σ.unus*(velo*0.1))/2);
      } else{
        Σ.num[0] = Math.Round(Σ.unus*(velo*0.1));
      }
    }
    public static void DanusMagicus(Persona Ego, Persona hostis, Ψ inc, int vis){
      Σ.unus=Volvere(Convert.ToInt32(inc.Danum[1]), nomen:Ego.Cognomen);
      Σ.num[10]=inc.Danum[0]+Σ.unus+(inc.Danum[2]*vis);
      Σ.num[10]=Σ.num[10]>inc.Danum[3]?inc.Danum[3]:Math.Round(Σ.num[10]);
      Σ.num[11]=inc.FormaM[0]+(inc.FormaM[1]*vis);
      Σ.num[11]=Σ.num[11]>inc.FormaM[2]?inc.FormaM[2]:Math.Round(Σ.num[11]);
      Σ.num[12]= Praecisionem(Ego, hostis, spa:Σ.num[11], typ:"explo");
      Σ.num[10]=Math.Floor(Σ.num[10]*Σ.num[12]);

      if(Σ.num[12]==1){
        Console.WriteLine("The target took a full hit with "+Σ.num[10]+" of damage.");
      } else if(Σ.num[12]==0){
        Console.WriteLine("The explosion does not reach the target.");
      } else{
        Σ.num[13]=Math.Round(Σ.num[12]*100);
        Console.WriteLine(Ego.Cognomen+" hits the ground and the target takes "+Σ.num[10]+" as "+Σ.num[13]+"% of damage.");
      }
      
      hostis.PV[1]-=Convert.ToInt32(Σ.num[10]);
    }
    public static void Battum(Persona Ego, string dir="front", int cem=0){
      cem = Volvere(100, nomen:Ego.Cognomen);
      
      if(dir=="front"){
        if(cem<26){
          Σ.notod="a leg";
        } else if(cem<36){
          Σ.notod="an arm";
        } else if(cem<96){
          cem=Volvere(100, nomen:Ego.Cognomen);
          if(cem>95){
            Σ.notod="the heart";
          } else if(cem>65){
            Σ.notod="the stomach";
          } else{
            Σ.notod="the torso";
          }
        } else if(cem<97){
          Σ.notod="the neck";
        } else if(cem<101){
          if(Volvere(10, nomen:Ego.Cognomen)==10){
            Σ.notod="an eye";
          } else{
            Σ.notod="the head";
          }
        }
      } else if(dir=="back"){
        if(cem<26){
          // legs
        } else if(cem<36){
          // arms
        } else if(cem<96){
          cem=Volvere(100, nomen:Ego.Cognomen);
          if(cem>80){
            // spine
          } else{
            // torso
          }
        } else if(cem<97){
          // neck
        } else if(cem<101){
            // head
        }
      } else if(dir=="side"){
        if(cem<26){
          // legs
        } else if(cem<89){
          // arms
        } else if(cem<90){
            // neck
        } else if(cem<101){
          // head
        }
      } else if(dir=="low"){
        if(cem<76){
          // legs
        } else if(cem<86){
          // arms
        } else if(cem<101){
            // stomach
          }
      } else if(dir=="high"){
        if(cem>50){
          // head
        } else{
          // miss
        }
      }
    }
    public static double Praecisionem(Persona Ego, Persona hostis, double ah=-1, double lh=-1, double spa=0, string typ="free"){
      double d = Calculus("hypod",Math.Abs(Ego.Lotus[0]-hostis.Lotus[0]),Math.Abs(Ego.Lotus[1]-hostis.Lotus[1]));
      if(ah==-1&&lh==-1){
        ah = hostis.Altitudo;
        lh = hostis.Latitudo;
      }
      
      if(typ=="free"){
        Σ.num[1] = d / Ego.Accuratio;
        Σ.num[2] = Math.Round(((Σ.num[1] / 2)*(Σ.num[1] / 2))*Math.PI);

        if(ah > Σ.num[1]){
          ah = Σ.num[1];
        }
        if(lh > Σ.num[1]){
          lh = Σ.num[1];
        }

        Σ.num[3] = ah * lh;
        Σ.num[4] = Math.Round((Σ.num[3] / Σ.num[2]) * 100);

        Σ.num[5] = 0;
        if(Σ.num[4]>100){
          Σ.num[5] = Σ.num[4] - 100;
          return 0;
        }

        return 100-Σ.num[4];
      } else if(typ=="fix"){
        // 'fix', when the passed 'ah' is already the surface area
        Σ.num[1] = d / Ego.Accuratio;
        Σ.num[2] = Math.Round(((Σ.num[1] / 2)*(Σ.num[1] / 2))*Math.PI);

        Σ.num[4] = Math.Round((ah / Σ.num[2]) * 100);

        Σ.num[5] = 0;
        if(Σ.num[4]>100){
          Σ.num[5] = Σ.num[4] - 100;
          return 0;
        }

        return 100-Σ.num[4];
      } else if(typ=="explo"){
        Σ.num[1] = d / Ego.Accuratio;
        Σ.num[2] = Math.Round(((Σ.num[1] / 2)*(Σ.num[1] / 2))*Math.PI);

        if(ah > Σ.num[1]){
          ah = Σ.num[1];
        }
        if(lh > Σ.num[1]){
          lh = Σ.num[1];
        }

        Σ.num[3] = ah * lh;

        Random area = new Random();
        double impa = area.Next(1,Convert.ToInt32(Σ.num[2])+1);
        Σ.num[4] = impa - Σ.num[3];
        spa = Math.Round(((spa / 4)*(spa / 4))*Math.PI);
        Σ.num[5] = Σ.num[4] / spa;
        Σ.num[6] = Math.Round(Math.Abs(((impa / Σ.num[2]) * 100)-100));
        Σ.num[7] = Math.Round((Σ.num[3] / Σ.num[2]) * 100);
        Console.WriteLine("You have rolled "+Σ.num[6]+" on a 0-100 ULF percentile against "+Σ.num[7]+"!");

        if(impa<=Σ.num[3]){
          return 1;
        }
        if(Σ.num[5]>=1){
          return 0;
        }

        return Math.Abs(Σ.num[5]-1);
      }
      return 0;
    }
    public static bool Peritia(string pe){
      switch(pe){
        case "Blade Proficiency":
          return Primor.homo.PeritiaLamina > 0;
        case "Bow Mastery":
          return Primor.homo.PeritiaDistantia > 0;
        default:
          return false;
      }
    }
    public static void Crisimus(Persona Ego, Persona hostis, string typ=""){
      if(typ=="aimed"){
        if(Volvere(100, nomen:Ego.Cognomen)>=Σ.num[1]){
          if(Volvere(100, nomen:Ego.Cognomen)>=100-Σ.num[5]){
            Σ.num[0] = Σ.num[0] * 2;
            Console.WriteLine(Ego.Cognomen+" hits "+Σ.notod+" with a critical hit of "+Σ.unus+" at "+velo+"m/s causing "+Σ.num[0]+" of damage.");
          } else{
            Console.WriteLine(Ego.Cognomen+" hits "+Σ.notod+" with a "+Σ.unus+" at "+velo+"m/s causing "+Σ.num[0]+" of damage.");
          }
        } else{
          Console.WriteLine(Ego.Cognomen+" missed "+Σ.notod+", but still hit with a "+Σ.unus+" at "+velo+"m/s causing "+Σ.num[0]+" of damage.");
        }
        hostis.PV[1]-=Convert.ToInt32(Σ.num[0]);
      } else{
        if(Volvere(100, nomen:Ego.Cognomen)>=100-Σ.num[5]){
          Σ.num[0] = Σ.num[0] * 2;
          Console.WriteLine(Ego.Cognomen+" hits "+Σ.notod+" with a critical hit of "+Σ.unus+" at "+velo+"m/s causing "+Σ.num[0]+" of damage.");
        } else{
          Console.WriteLine(Ego.Cognomen+" hits "+Σ.notod+" with a "+Σ.unus+" at "+velo+"m/s causing "+Σ.num[0]+" of damage.");
        }
        hostis.PV[1]-=Convert.ToInt32(Σ.num[0]);
      }
    }

    public static void Spargo(Ψ Incantatio, Persona Ego, Persona hostis, int pot=-1){

      if(pot<0){
        pot=Ego.Potentia;
      } else if(pot>Ego.Potentia){
        pot=Ego.Potentia;
      }

      switch(Incantatio.Typus){
        case "Physical":
          if(Array.Exists(Incantatio.Qualitas,i=>i=="Aerodynamic")){
              PulsareLonge(Ego, hostis, pot, Convert.ToInt32(Incantatio.Danum[1]), Incantatio.Pondus[0], gra:2);
            } else{
              PulsareLonge(Ego, hostis, pot, Convert.ToInt32(Incantatio.Danum[1]), Incantatio.Pondus[0]);
            }
          break;
        case "Explosion":
          DanusMagicus(Ego, hostis, Incantatio, pot);
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
      Ego.PM[1]-=Math.Round(Incantatio.ManaPretium[0]+(Incantatio.ManaPretium[1]*pot));


      /*this.Nomen=nomen;
      this.Danum=new double[4];
      this.Danum[0]=danum;
      this.Danum[1]=danumd;
      this.Danum[2]=danumr;
      this.Danum[3]=danumc;
      this.Incantatio=inc;
      this.ManaPretium=new double[2];
      this.ManaPretium[0]=mp;
      this.ManaPretium[1]=mpr;

      this.Velocitas=new double[2];
      this.Velocitas[0]=vel;
      this.Velocitas[1]=velr;
      this.Forma=forma;
      this.FormaM=new double[3];
      this.FormaM[0]=area;
      this.FormaM[1]=arear;
      this.FormaM[2]=areac;
      this.Thermo=new double[2];
      this.Thermo[0]=thermo;
      this.Thermo[1]=thermor;
      this.Qualitas=new string[1];
      this.Qualitas[0]=qual;*/
    }

    static void Promptus(){
      Console.WriteLine(">STR\n>Weight\nMechanical Conversion\nGracefulness");

      string input = Console.ReadLine();
      int vigor = String.IsNullOrEmpty(input) ? 1 : Convert.ToInt32(input);
      input = Console.ReadLine();
      double massa = String.IsNullOrEmpty(input) ? 1 : Convert.ToDouble(input);
      input = Console.ReadLine();
      int mec = String.IsNullOrEmpty(input) ? 1 : Convert.ToInt32(input);
      input = Console.ReadLine();
      int gra = String.IsNullOrEmpty(input) ? 1 : Convert.ToInt32(input);

      Console.WriteLine(Velocitas(vigor, massa, mec, gra));

      Console.WriteLine("Type to exit:");
      Σ.rector = Console.ReadLine().ToLower();
    }

    public static string Velocitas(int cap=1, double massa=1, int gra=1){ 
      Resistentiam(massa, gra);
    
      for(int i=0; i < res.Length; i++){
        if (cap > res[i]){
        } else{
          if(i>1){
            velo = i-1;
            return $"{res[i-1]}{acc[i-1]}";
          }
        }
      }
      return "0";
    }
    public static string Velocitas(int vis, double massa, int mec, int gra){
      int cap=Capacitas(vis,mec); 
      Resistentiam(massa,gra);
    
      for(int i=0; i < res.Length; i++){
        if (cap > res[i]){
        } else{
          velo = i-1;
          return $"{res[i-1]}{acc[i-1]}";
        }
      }
      return "0";
    }

    // Passivis

    public static int Capacitas(int vigor=1, int mec=1){
      if(mec == 1){
        return vigor * 6;
      } else if(mec == 2){
        return vigor * 7;
      } else if(mec == 3){
        return vigor * 8;
      } else if(mec == 4){
        return vigor * 10;
      } else if(mec == 5){
        return vigor * 15;
      } else if(mec == 6){
        return vigor * 16;
      } else if(mec == 7){
        return vigor * 22;
      } else if(mec == 8){
        return vigor * 24;
      } else if(mec == 9){
        return vigor * 17;
      } else if(mec == 10){
        return vigor * 30;
      }
      return 0;
    }
    public static int Potentia(int intelligentia=1, int enf=1){
      if(enf == 1){
        return intelligentia * 6;
      } else if(enf == 2){
        return intelligentia * 7;
      } else if(enf == 3){
        return intelligentia * 8;
      } else if(enf == 4){
        return intelligentia * 10;
      } else if(enf == 5){
        return intelligentia * 15;
      } else if(enf == 6){
        return intelligentia * 16;
      } else if(enf == 7){
        return intelligentia * 22;
      } else if(enf == 8){
        return intelligentia * 24;
      } else if(enf == 9){
        return intelligentia * 17;
      } else if(enf == 10){
        return intelligentia * 30;
      }
      return 0;
    }
    public static double Celeritas(int dexeteritate=1, int cel=3){
      if(cel == 2){
        return Math.Round(dexeteritate * 0.05, 1);
      } else if(cel == 3){
        return Math.Round(dexeteritate * 0.1, 1);
      } else if(cel == 4){
        return Math.Round(dexeteritate * 0.15, 1);
      }
      return 0;
    }
    public static double Accuratio(int dexeteritate=1, int acu=1){
      if(acu == 0){
        return Math.Round(dexeteritate * 0.1, 1);
      } else if(acu == 1){
        return Math.Round(dexeteritate * 0.5, 1);
      } else if(acu == 2){
        return Math.Round(dexeteritate * 0.7, 1);
      }
      return 0;
    }
    public static double Perceptio(int sapientia=1, int per=1){
      if(per == 0){
        return Math.Round(sapientia * 0.05, 1);
      } else if(per == 1){
        return Math.Round(sapientia * 0.1, 1);
      } else if(per == 2){
        return Math.Round(sapientia * 0.15, 1);
      }
      return 0;
    }
    public static double Lapsus(double att, bool inc=false){
      if(inc){
        att=att/10;
      }
      if(att>2.9){
        return 10;
      } else if(att>2.4){
        return 11;
      } else if(att>1.9){
        return 12.5;
      } else if(att>1.6){
        return 14.2;
      } else if(att>1.4){
        return 16.6;
      } else if(att>1.2){
        return 20;
      } else if(att>0.9){
        return 25;
      } else{
        return 50;
      }
    }

    public static void Chronus(Persona Ego, params Persona[] hostis){
      double dup;
      int hord=0;
      dup=-1;
      if(Primor.homo.PV[1]<=0){
        Console.WriteLine("\nYou have died.");
        Console.ReadLine();
        Environment.Exit(0);
      }

      do{
        if(Ego.sum>0 && !Ego.rec){
          if(dup!=Ego.Tempus){
            Console.WriteLine("\nIt is 00:"+Ego.Tempus+" at X: "+(Agrum.Latitudo-Ego.Lotus[0])+" and Y: "+(Agrum.Altitudo-Ego.Lotus[1])+", "+Ego.Cognomen+".");
            dup=Ego.Tempus;
          }
          Console.WriteLine("\nYou are busy.");
          Console.ReadLine();
        } else if(!Ego.rec){
          if(dup!=Ego.Tempus){
            Console.WriteLine("\nIt is 00:"+Ego.Tempus+" at X: "+(Agrum.Latitudo-Ego.Lotus[0])+" and Y: "+(Agrum.Altitudo-Ego.Lotus[1])+", "+Ego.Cognomen+".");
            dup=Ego.Tempus;
          }
          Console.WriteLine("\nWhat do you want to do, "+Ego.Cognomen+"?");
          Ego.verb = Console.ReadLine();
          if(Array.Exists(Ego.Actus,i=>i==Ego.verb)){
            Actus.Gestus(Ego.verb, Ego);
          }
        }

        

        if(Ego.sum>0){
          Ego.Tempus+=Ego.PerT;
          if(Ego.Tempus>98&&Ego.Tempus<100){
            Ego.Tempus=100;
          } else if(Ego.Tempus>198&&Ego.Tempus<200){
            Ego.Tempus=200;
          } else if(Ego.Tempus>298&&Ego.Tempus<300){
            Ego.Tempus=300;
          }
          if(Ego.mag){
            do{
              Ego.dix+=Ego.CasT;
              if(Ego.dix>98&&Ego.dix<100){
                Ego.dix=100;
              } else if(Ego.dix>198&&Ego.dix<200){
                Ego.dix=200;
              } else if(Ego.dix>298&&Ego.dix<300){
                Ego.dix=300;
              }
              Ego.sum--;
            } while(Ego.dix+Ego.CasT<Ego.Tempus);
          } else{
            do{
              Ego.dix+=Ego.AgiT;
              if(Ego.dix>98&&Ego.dix<100){
                Ego.dix=100;
              } else if(Ego.dix>198&&Ego.dix<200){
                Ego.dix=200;
              } else if(Ego.dix>298&&Ego.dix<300){
                Ego.dix=300;
              }
              Ego.sum--;
            } while(Ego.dix+Ego.AgiT<Ego.Tempus);
          }
        }

        if(!Σ.lop){
          hord=0;
          for(int u=0;u<hostis.Length;u++){
            if(hostis[u].Tempus<=Ego.Tempus){
              hord++;
              if(hostis[u].PV[1]<=0){
                hord--;
                if(!hostis[u].inferi){
                  hostis[u].inferi=true;
                  Console.WriteLine("\n"+hostis[u].Cognomen+" has perished.");
                }
              } else{
                Σ.lop=true;
                Chronus(hostis[u]);
              }
            }
          }
          if(hord<=0){
            Console.WriteLine("\n"+Ego.Cognomen+" has won.");
            Σ.rector="exit";
          }     
        }
        
        if(Ego.sum<1){
          if(Ego.ergo){
            if(dup!=Ego.Tempus){
              Console.WriteLine("\nIt is 00:"+Ego.Tempus+", "+Ego.Cognomen+".");
              dup=Ego.Tempus;
            }
            Actus.Ergo(Ego.verb, Ego);
          } else if(Ego.rec){
            if(dup!=Ego.Tempus){
              Console.WriteLine("\nIt is 00:"+Ego.Tempus+", "+Ego.Cognomen+".");
              dup=Ego.Tempus;
            }
            Actus.Recovery(Ego);
          } else{
            while(Ego.Tempus<Ego.dix){
              Ego.Tempus+=Ego.PerT;
              if(!Ego.rec){
                if(dup!=Ego.Tempus){
                  Console.WriteLine("\nIt is 00:"+Ego.Tempus+", "+Ego.Cognomen+".");
                  dup=Ego.Tempus;
                }
                Console.WriteLine("\nYou are busy.");
              } 
            }
          }
        }
        if(Σ.lop && Ego.Cognomen!=Primor.homo.Cognomen){
          if(Ego.Tempus>Agrum.Tempus){
            Σ.lop=false;
            Σ.rector="exit";
          }
        } else{
          Σ.lop=false;
          if(hord>0){
            Σ.rector="";
          }
        }
        if(Ego.Tempus>Agrum.Tempus){
          Agrum.Tempus=Ego.Tempus;
        }
      } while(Σ.rector!="exit");
    }

    public static void Chronus(Persona Ego, bool yuno=false, params Persona[] hostis){
      double dup;
      int hord=0;
      dup=-1;
      if(Primor.homo.PV[1]<=0){
        Console.WriteLine("\nYou have died.");
        Console.ReadLine();
        Environment.Exit(0);
      }

      do{
        if(Ego.sum>0 && !Ego.rec){
          if(dup!=Ego.Tempus){
            if(Ego.Cognomen==Primor.homo.Cognomen){
              Console.WriteLine("\nIt is 00:"+Ego.Tempus+" at X: "+(Agrum.Latitudo-Ego.Lotus[0])+" and Y: "+(Agrum.Altitudo-Ego.Lotus[1])+", "+Ego.Cognomen+".");
              Console.WriteLine("\nYou are busy.");
            } else {
              Console.WriteLine(Ego.Cognomen+" is at X: "+(Agrum.Latitudo-Ego.Lotus[0])+" and Y: "+(Agrum.Altitudo-Ego.Lotus[1])+".");
            }
            dup=Ego.Tempus;
          }
          Console.ReadLine();
        } else if(!Ego.rec && Ego.Cognomen!=Primor.homo.Cognomen){
          Ego.Yuno.Sensus(Ego.Sensus, Ego, Primor.homo);
          Actus.Gestus(Ego.verb, Ego, true);
          
        } else if(!Ego.rec){
          if(dup!=Ego.Tempus){
            Console.WriteLine("\nIt is 00:"+Ego.Tempus+" at X: "+(Agrum.Altitudo-Ego.Lotus[0])+" and Y: "+(Agrum.Latitudo-Ego.Lotus[1])+", "+Ego.Cognomen+".");
            dup=Ego.Tempus;
          }
          Console.WriteLine("\nWhat do you want to do, "+Ego.Cognomen+"?");
          Ego.verb = Console.ReadLine();
          if(Array.Exists(Ego.Actus,i=>i==Ego.verb)){
            Actus.Gestus(Ego.verb, Ego);
          }
        }

        

        if(Ego.sum>0){
          Ego.Tempus+=Ego.PerT;
          if(Ego.Tempus>98&&Ego.Tempus<100){
            Ego.Tempus=100;
          } else if(Ego.Tempus>198&&Ego.Tempus<200){
            Ego.Tempus=200;
          } else if(Ego.Tempus>298&&Ego.Tempus<300){
            Ego.Tempus=300;
          }
          if(Ego.mag){
            do{
              Ego.dix+=Ego.CasT;
              if(Ego.dix>98&&Ego.dix<100){
                Ego.dix=100;
              } else if(Ego.dix>198&&Ego.dix<200){
                Ego.dix=200;
              } else if(Ego.dix>298&&Ego.dix<300){
                Ego.dix=300;
              }
              Ego.sum--;
            } while(Ego.dix+Ego.CasT<Ego.Tempus);
          } else{
            do{
              Ego.dix+=Ego.AgiT;
              if(Ego.dix>98&&Ego.dix<100){
                Ego.dix=100;
              } else if(Ego.dix>198&&Ego.dix<200){
                Ego.dix=200;
              } else if(Ego.dix>298&&Ego.dix<300){
                Ego.dix=300;
              }
              Ego.sum--;
            } while(Ego.dix+Ego.AgiT<Ego.Tempus);
          }
        }

        if(!Σ.lop){
          hord=0;
          for(int u=0;u<hostis.Length;u++){
            if(hostis[u].Tempus<=Ego.Tempus){
              hord++;
              if(hostis[u].PV[1]<=0){
                hord--;
                if(!hostis[u].inferi){
                  hostis[u].inferi=true;
                  Console.WriteLine("\n"+hostis[u].Cognomen+" has perished.");
                }
              } else{
                Σ.lop=true;
                Chronus(hostis[u], true);
              }
            }
          }
          if(hord<=0){
            Console.WriteLine("\n"+Ego.Cognomen+" has won.");
            Σ.rector="exit";
          }     
        }
        
        if(Ego.sum<1){
          if(Ego.ergo){
            if(dup!=Ego.Tempus){
              if(Ego.Cognomen==Primor.homo.Cognomen){
                Console.WriteLine("\nIt is 00:"+Ego.Tempus+", "+Ego.Cognomen+".");
              }
              dup=Ego.Tempus;
            }
            if(Ego.Cognomen!=Primor.homo.Cognomen){
              Actus.Ergo(Ego.verb, Ego, true);
            } else{
              Actus.Ergo(Ego.verb, Ego);
            } 
          } else if(Ego.rec){
            if(dup!=Ego.Tempus){
              if(Ego.Cognomen==Primor.homo.Cognomen){
                Console.WriteLine("\nIt is 00:"+Ego.Tempus+", "+Ego.Cognomen+".");
              }
              dup=Ego.Tempus;
            }
            Actus.Recovery(Ego);
          } else{
            while(Ego.Tempus<Ego.dix){
              Ego.Tempus+=Ego.PerT;
              if(!Ego.rec){
                if(dup!=Ego.Tempus){
                  if(Ego.Cognomen==Primor.homo.Cognomen){
                    Console.WriteLine("\nIt is 00:"+Ego.Tempus+", "+Ego.Cognomen+".");
                  }
                  dup=Ego.Tempus;
                }
                if(Ego.Cognomen==Primor.homo.Cognomen){
                  Console.WriteLine("\nYou are busy.");
                }                
              } 
            }
          }
        }
        if(Σ.lop && Ego.Cognomen!=Primor.homo.Cognomen){
          if(Ego.Tempus>Agrum.Tempus){
            Σ.lop=false;
            Σ.rector="exit";
          }
        } else{
          Σ.lop=false;
          if(hord>0){
            Σ.rector="";
          }
        }
        if(Ego.Tempus>Agrum.Tempus){
          Agrum.Tempus=Ego.Tempus;
        }
      } while(Σ.rector!="exit");
    }

    public static double Calculus(string cybus="cube", double unus=1, double duo=1, double tribus=1){
      if(cybus=="cube"){
        unus = unus * duo * tribus;
      } else if(cybus=="sphere"){
        unus = (Math.PI * 1.5) * (Math.Pow(unus, 3));
      } else if(cybus=="cylinder"){
        unus = Math.PI * (unus*unus) * duo;
      } else if(cybus=="pyramid"){
        unus = ((unus*unus)/3)*duo;
      } else if(cybus=="cone"){
        unus = ((unus*unus)/3)*duo*Math.PI;
      } else if(cybus=="area"){
        unus = unus*duo;
      } else if(cybus=="areac"){
        unus = (unus*unus) * Math.PI;
      } else if(cybus=="surface"){
        unus = ((unus*duo)+(unus*tribus)+(duo*tribus))*2;
      } else if(cybus=="surfacec"){
        unus = (unus*unus) * (Math.PI*4);
      } else if(cybus=="surfacecy"){
        unus = (((unus*unus)*Math.PI)*2)*((unus*duo)*(Math.PI*2));
      } else if(cybus=="hypo"){
        unus = Math.Sqrt((unus*unus)/2);
      } else if(cybus=="hypod"){
        unus = Math.Sqrt(unus*unus+duo*duo);
      }
      return Math.Round(unus, 2);
    }
    public static void Calculate(){
      Console.WriteLine("Inform type:\n'cube'\n'sphere'\n'cylinder'\n'pyramid'\n'cone'\n'area'\n'areac'");
      Σ.rector = Console.ReadLine().ToLower();
      Console.WriteLine("Inform the value of radius or width.");
      Σ.notou = Console.ReadLine();
      Σ.unus = String.IsNullOrEmpty(Σ.notou) ? 1 : Convert.ToInt32(Σ.notou);
      Console.WriteLine("Inform the value of height, if any.");
      Σ.notod = Console.ReadLine();
      Σ.duo = String.IsNullOrEmpty(Σ.notod) ? 1 : Convert.ToInt32(Σ.notod);
      Console.WriteLine("Inform the value of depth, if any.");
      Σ.notot = Console.ReadLine();
      Σ.tribus = String.IsNullOrEmpty(Σ.notot) ? 1 : Convert.ToInt32(Σ.notot);
      Console.WriteLine(Calculus(Σ.rector, Σ.unus, Σ.duo, Σ.tribus));

      Console.ReadLine();
    }
    public static void Artificium(){
      obj[600] = "tsar";
      Objectum["tsar"] = new Objectum();
      Objectum["tsar"].Depictio="The Tsar Bomb was the greatest explosion the humans produced; with over 200 petajoules or 50 megatons of TNT. Enough to move twenty billion tonnes through one kilometre.";
      Objectum["tsar"].Pondus=1;
      Objectum["tsar"].Materiae();
      Objectum["tsar"].Materia.Calefacio=50000000000000;
      Objectum["tsar"].Materia.Calfacio="Not to be molten, but the energy released by it is:";
      obj[601] = "lightning";
      Objectum["lightning"] = new Objectum();
      Objectum["lightning"].Depictio="A lightning bolt in average has ten billion watts; 10 gigajoules which could lift a million tonnes one metre in the air.";
      Objectum["lightning"].Pondus=1;
      Objectum["lightning"].Materiae();
      Objectum["lightning"].Materia.Calefacio=2388458.96;
      Objectum["lightning"].Materia.Calfacio="Plasma has nothing to be molten, but the energy it contains is:";
      obj[602] = "little boy";
      Objectum["little boy"] = new Objectum();
      Objectum["little boy"].Depictio="From Gay to Hiroshima; the infamous nuclear bomb had 63.7 terajoules or 15 kilotons of TNT. Enough to move six billion tonnes for a metre.";
      Objectum["little boy"].Pondus=1;
      Objectum["little boy"].Materiae();
      Objectum["little boy"].Materia.Calefacio=15057361376;
      Objectum["little boy"].Materia.Calfacio="Not to be molten, but the energy released by it is:";
      obj[603] = "human";
      Objectum["human"] = new Objectum();
      Objectum["human"].Depictio="An average human has 2000 kilocalories of chemical energy; that is 8.3M joules - 96.8 watts nonstop. It can exactly boil 20L of water or lift 830 tonnes one meters, although the human muscles have a conversion of 20-25% so that the mechanical energy would be less than 200 tonnes and the rest released as heat.";
      Objectum["human"].Pondus=60;
      Objectum["human"].Materiae();
      Objectum["human"].Materia.Calefacio=33.33;
      Objectum["human"].Materia.Calfacio="Poor thing; its burning can generate only so much energy.";

      Console.WriteLine("\nWelcome to the object interface.");
      Console.WriteLine("Choose what type of interaction you want to perform:"+
      "\nType 'create' to create a new object."+
      "\nType 'move' to move an object."+
      "\nType 'melt' to simulate the heating of an object."+
      "\nType 'list' to list all existing objects."+
      "\nType 'compare' to compare two objects."
      );
      Σ.rector = Console.ReadLine().ToLower();

      switch(Σ.rector){
        case "create":
          Console.WriteLine("Name your new object.");
          Σ.notou = Console.ReadLine().ToLower();
          Objectum[Σ.notou] = new Objectum();
          Objectum[Σ.notou].Nomen = Σ.notou;
          Console.WriteLine("Inform a shape:\n'cube'\n'sphere'\n'cylinder'\n'pyramid'\n'cone'");
          Σ.rector = Console.ReadLine().ToLower();
          Objectum[Σ.notou].Forma = Σ.rector;
          Console.WriteLine("Inform the width or radius.");
          Σ.unus = Convert.ToInt32(Console.ReadLine());
          Objectum[Σ.notou].Latitudo = Σ.unus;
          Console.WriteLine("Inform the height, if any.");
          Σ.rector = Console.ReadLine().ToLower();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          Objectum[Σ.notou].Altitudo = Σ.unus;
          Console.WriteLine("Inform the depth, if any.");
          Σ.rector = Console.ReadLine().ToLower();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          Objectum[Σ.notou].Crassitudo = Σ.unus;
          Console.WriteLine("Inform a material:\n'limestone'\n'dirt'\n'iron'\n'gold'\n'lead'\n'osmium'\n'water'\n'oxygen'\n'oak'");
          Σ.rector = Console.ReadLine().ToLower();
          Objectum[Σ.notou].Materiae(Σ.rector);
          Objectum[Σ.notou].Carnatio = Calculus(Objectum[Σ.notou].Forma, Objectum[Σ.notou].Latitudo, Objectum[Σ.notou].Altitudo, Objectum[Σ.notou].Crassitudo);
          Objectum[Σ.notou].Pondus = Objectum[Σ.notou].Carnatio * Objectum[Σ.notou].Materia.Densitas;

          if(Objectum[Σ.notou].Forma=="cube"){
            Objectum[Σ.notou].Superficiem = Calculus("surface", Objectum[Σ.notou].Latitudo, Objectum[Σ.notou].Altitudo, Objectum[Σ.notou].Crassitudo);
          } else if(Objectum[Σ.notou].Forma=="sphere"){
            Objectum[Σ.notou].Superficiem = Calculus("surfacec", Objectum[Σ.notou].Latitudo, Objectum[Σ.notou].Altitudo, Objectum[Σ.notou].Crassitudo);
          } else if(Objectum[Σ.notou].Forma=="cylinder"){
            Objectum[Σ.notou].Superficiem = Calculus("surfacecy", Objectum[Σ.notou].Latitudo, Objectum[Σ.notou].Altitudo, Objectum[Σ.notou].Crassitudo);
          } else{
            Objectum[Σ.notou].Superficiem = -1;
          }
          obj[plurimas] = Objectum[Σ.notou].Nomen;
          plurimas++;

          Objectum[Σ.notou].Index();
          Console.ReadLine();
          Artificium();
          break;
        case "move":
          Console.WriteLine("Name the object to be moved.");
          Σ.notou = Console.ReadLine().ToLower();
          Objectum[Σ.notou].Index();
          Console.WriteLine("Choose how many meters you want to move it or how fast you want to accelerate it.");
          Σ.rector = Console.ReadLine().ToLower();
          Σ.unus = String.IsNullOrEmpty(Σ.rector) ? 1 : Convert.ToInt32(Σ.rector);
          Σ.num[0] = Math.Round(Objectum[Σ.notou].Pondus * Σ.unus, 2);
          Σ.num[1] = Math.Round(Σ.num[0] * 9.8, 2);
          Σ.num[2] = Math.Round(Σ.num[1] / 4184, 2);
          Σ.num[3] = Math.Round(Σ.num[2] / 1000, 2);
          Σ.num[4] = Math.Round(Σ.num[2] / 2000, 2);
          Σ.num[5] = Σ.num[0]/1000;
          Σ.num[6] = Σ.num[5]/1000;
          Console.WriteLine($"To move it for {Σ.unus}m is akin to {Σ.num[0]} grams ({Σ.num[5]} in kilos and {Σ.num[6]} in tonnes); that is {Σ.num[1]} joules of energy or {Σ.num[2]} kilocalories of pure perfect mechanical conversion with no resistance or drag opposing it.\n"+
          $"That is enough to heat up 1000L of water {Σ.num[3]} degrees; {Σ.num[4]} times the average daily calories of a normal human.");
          Σ.num[1] = Σ.num[2];
          Σ.num[2] = Math.Round(Σ.num[1]/1000, 2);
          Σ.num[3] = Math.Round(Σ.num[2]/1000, 2);
          Σ.num[4] = Math.Round(Σ.num[3]/1000, 2);
          Σ.num[5] = Math.Round(Σ.num[4]/1000, 2);
          Σ.num[6] = Math.Round(Σ.num[5]/1000, 2);
          Σ.num[7] = Math.Round(Σ.num[6]/1000, 2);
          Σ.num[8] = Math.Round(Σ.num[7]/1000, 2);
          Σ.num[9] = Math.Round(Σ.num[8]/1000, 2);
          if(Σ.num[2] > 1){
            Console.WriteLine(Σ.num[2]+" kilojoules.");
            if(Σ.num[3] > 1){
              Console.WriteLine(Σ.num[3]+" megajoules.");
              if(Σ.num[4] > 1){
                Console.WriteLine(Σ.num[4]+" gigajoules.");
                if(Σ.num[5] > 63){
                  Console.WriteLine(Σ.num[5]+" in terajoules; that is more than the 63TJ of Little Boy which wiped Hiroshima out.");
                  if(Σ.num[6] > 210){
                    Console.WriteLine(Σ.num[6]+" in petajoules; that is more than the 210PJ greatest nuclear bomb humankind has ever used.");
                    if(Σ.num[7] > 1){
                      Console.WriteLine(Σ.num[7]+" in exajoules; that is "+Σ.num[10]+" times the yearly USA electrical energy consumption. A magnitude nine earthquake releases little more than one EJ of energy.");
                      if(Σ.num[8] > 0.5){
                        Console.WriteLine(Σ.num[8]+" in zettajoules; that is "+Σ.num[11]+" times the yearly energy consumption of the entire humankind.");
                        if(Σ.num[9] > 1){
                          Console.WriteLine(Σ.num[9]+" in yottajoules; each YJ is enough to increase in one degree all the water on Earth. The energy required to melt this object compare as "+Σ.num[12]+" times the energy produced each second by the Sun.");
                        }
                      }
                    }
                  }
                }
              }
            }
          }
          Console.ReadLine();
          Artificium();
          break;
        case "list":
          for(int i=0;i<obj.Length;i++){
            if(obj[i]==null){

            } else{
              Console.WriteLine(obj[i]);
            }
          }
          Console.ReadLine();
          Artificium();
          break;
        case "melt":
          Console.WriteLine("Name the object to be molten.");
          Σ.notou = Console.ReadLine().ToLower();
          Console.WriteLine(Objectum[Σ.notou].Materia.Calfacio);
          Σ.num[0] = Math.Round(Objectum[Σ.notou].Pondus * Objectum[Σ.notou].Materia.Calefacio, 2);
          Σ.num[1] = Math.Round(Σ.num[0]*4184, 2);
          Σ.num[2] = Math.Round(Σ.num[1]/1000, 2);
          Σ.num[3] = Math.Round(Σ.num[2]/1000, 2);
          Σ.num[4] = Math.Round(Σ.num[3]/1000, 2);
          Σ.num[5] = Math.Round(Σ.num[4]/1000, 2);
          Σ.num[6] = Math.Round(Σ.num[5]/1000, 2);
          Σ.num[7] = Math.Round(Σ.num[6]/1000, 2);
          Σ.num[8] = Math.Round(Σ.num[7]/1000, 2);
          Σ.num[9] = Math.Round(Σ.num[8]/1000, 2);
          Σ.num[10] = Math.Round(Σ.num[7]/94, 2);
          Σ.num[11] = Math.Round(Σ.num[8]/0.5, 2);
          Σ.num[12] = Math.Round(Σ.num[9]/400, 2);
          Console.WriteLine(Σ.num[0]+" in kilocalories or TNT grams while "+Σ.num[1]+" in joules.");
          if(Σ.num[2] > 1){
            Console.WriteLine(Σ.num[2]+" kilojoules.");
            if(Σ.num[3] > 1){
              Console.WriteLine(Σ.num[3]+" megajoules.");
              if(Σ.num[4] > 1){
                Console.WriteLine(Σ.num[4]+" gigajoules.");
                if(Σ.num[5] > 63){
                  Console.WriteLine(Σ.num[5]+" in terajoules; that is more than the 63TJ of Little Boy which wiped Hiroshima out.");
                  if(Σ.num[6] > 210){
                    Console.WriteLine(Σ.num[6]+" in petajoules; that is more than the 210PJ greatest nuclear bomb humankind has ever used.");
                    if(Σ.num[7] > 1){
                      Console.WriteLine(Σ.num[7]+" in exajoules; that is "+Σ.num[10]+" times the yearly USA electrical energy consumption. A magnitude nine earthquake releases little more than one EJ of energy.");
                      if(Σ.num[8] > 0.5){
                        Console.WriteLine(Σ.num[8]+" in zettajoules; that is "+Σ.num[11]+" times the yearly energy consumption of the entire humankind.");
                        if(Σ.num[9] > 1){
                          Console.WriteLine(Σ.num[9]+" in yottajoules; each YJ is enough to increase in one degree all the water on Earth. The energy required to melt this object compare as "+Σ.num[12]+" times the energy produced each second by the Sun.");
                        }
                      }
                    }
                  }
                }
              }
            }
          }
          Console.ReadLine();
          Artificium();
          break;
        case "compare":
          Console.WriteLine("Name the first object.");
          Σ.notou = Console.ReadLine().ToLower();
          Console.WriteLine("Name the second object.");
          Σ.notod = Console.ReadLine().ToLower();
          Objectum[Σ.notou].Index();
          Objectum[Σ.notod].Index();
          Console.ReadLine();
          Artificium();
          break;
        default:
          break;
      }
    }
    public static void Deux(){
      Console.WriteLine("Creation or 'res'surection?");
      Σ.rector=Console.ReadLine().ToLower();
      if(Σ.rector=="res"){
        Console.WriteLine("Recollect his family name from the depths of your memory:");
        Σ.notou = Console.ReadLine();
        if (File.Exists(".\\Baratrum\\" + Σ.notou + ".jkk")){
          Primor.Hostis[Σ.notou] = new Persona();
          Primor.Hostis[Σ.notou].Porto(Σ.notou);

          Console.WriteLine("Show sheet?");
          Σ.rector = Console.ReadLine().ToLower();
          if(Σ.rector=="yes"||Σ.rector=="y"){
            Primor.Hostis[Σ.notou].Epistola();
          }

          Console.WriteLine("Print sheet to .txt?");
          Σ.rector = Console.ReadLine().ToLower();
          if(Σ.rector=="yes"||Σ.rector=="y"){
            Primor.Hostis[Σ.notou].Scribere(Σ.notou);
          }
        } else{
          Console.WriteLine("\nThat does not exist.");         
        }
      } else{
        Console.WriteLine("Cabal or auto?");
        Σ.rector=Console.ReadLine().ToLower();
        if(Σ.rector=="cabal"){
          Persona neo = new Persona();
          neo.Utor();
          Primor.Hostis[neo.Cognomen] = neo;
        } else{
          Console.WriteLine("\nName the new being.");
          Σ.notou=Console.ReadLine();

          Primor.Hostis[Σ.notou] = new Persona();
          Primor.Hostis[Σ.notou].Nomen = Σ.notou;
          Primor.Hostis[Σ.notou].Cognomen = Σ.notou;

          Console.WriteLine("\nChoose a race.");
          Σ.notod=Console.ReadLine().ToLower();

          Primor.Hostis[Σ.notou].Genus.Auto(Σ.notod, Primor.Hostis[Σ.notou].Nomen);
          Console.WriteLine("\nDo you wish to save the "+Σ.notod+" "+Σ.notou+"?");
          Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="save"){
            Primor.Hostis[Σ.notou].Salvare();
          }
        }
      }
    }
    public static void Mensula(int vigor=999, double massa=1, int mec=10, int gra=1, int from=100, int to=110){
      Console.WriteLine("Basic effect of Gracefulness comparison: \n");
      Velocitas(10, 1, 1, 1);
      Velocitas(15, 1, 1, 2);
      Velocitas(20, 1, 1, 1);
      Velocitas(20, 1, 1, 2);

      Console.WriteLine("The reach of a same Capacity over different Gracefulness levels.\n");
      Velocitas(20, 1, 10, 1);
      Velocitas(20, 0.1, 10, 1);
      Velocitas(20, 1, 10, 2);
      Velocitas(20, 0.1, 10, 2);
      Velocitas(20, 1, 10, 3);
      Velocitas(20, 0.1, 10, 3);
      Velocitas(20, 1, 10, 4);
      Velocitas(20, 0.1, 10, 4);
      Velocitas(20, 1, 10, 5);
      Velocitas(20, 0.1, 10, 5);
      
      Console.WriteLine("Your Query:\n");
      Velocitas(vigor, massa, mec, gra);
      Console.WriteLine("\n");
      for(int i=from; i < to; i++){
        Console.WriteLine(res[i] + acc[i]);
      }
      Console.WriteLine($"\nSTR: {vigor}\nWeight: {massa}\nMechanical Conversion Level: {mec}\nGracefulness: {gra}\nFrom {from} meters per second to {to} meters per second.\n");
    }

    static void Resistentiam(double massa, int gra){
      double rateu = 1.02;
      double rated = 1.01;
      double ratet = 1.005;
      double rateq = 1.002;
      double rateQ = 1.001;
      int leveld = 100;
      int levelt = 250;
      int levelq = 500;
      int levelQ = 1000;

      if (gra == 0){
        for(int i=0; i < (machQ-1); i++){
          if(i < 6){
            res[i] = i * massa;
            acc[i] = " in weight for "+i+"m/s";
          } else{
            res[i] = Math.Round((i*(Math.Pow(1.05, (i-5))))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          }
        }
      } else if (gra == 1){
        for(int i=0; i < (machQ-1); i++){
          if(i < 6){
            res[i] = i * massa;
            acc[i] = " in weight for "+i+"m/s";
          } else{
            res[i] = Math.Round((i*(Math.Pow(rateu, (i-5))))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          }
        }
      } else if(gra == 2){
        for(int i=0; i < (machQ-1); i++){
          if(i < 6){
            res[i] = i * massa;
            acc[i] = " in weight for "+i+"m/s.";
          } else if(i < (leveld+6)){
            res[i] = Math.Round(i*(Math.Pow(rated, (i-5)))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          } else{
            res[i] = Math.Round((i*(Math.Pow(rateu, (i-((leveld/2)+5)))))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          }
        }
      } else if(gra == 3){
        for(int i=0; i < (machQ-1); i++){
          if(i < 6){
            res[i] = i * massa;
            acc[i] = " in weight for "+i+"m/s.";
          } else if(i < (levelt+6)){
            res[i] = Math.Round(i*(Math.Pow(ratet, (i-5)))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          }else if(i < (levelt+leveld+6)){
            res[i] = Math.Round(i*(Math.Pow(rated, (i-((levelt/2)+5))))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          } else{
            res[i] = Math.Round((i*(Math.Pow(rateu, (i-(((leveld+levelt)/2)+5)))))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          }
        }
      } else if(gra == 4){
        for(int i=0; i < (machQ-1); i++){
          if(i < 6){
            res[i] = i * massa;
            acc[i] = " in weight for "+i+"m/s.";
          } else if(i < (levelq+6)){
            res[i] = Math.Round(i*(Math.Pow(rateq, (i-5)))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          } else if(i < (levelq+levelt+leveld+6)){
            res[i] = Math.Round(i*(Math.Pow(ratet, (i-((levelq/2)+5))))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          }else if(i < (levelq+levelt+leveld+6)){
            res[i] = Math.Round(i*(Math.Pow(rated, (i-(((levelq+levelt)/2)+5))))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          } else{
            res[i] = Math.Round((i*(Math.Pow(rateu, (i-(((levelq+levelt+leveld)/2)+5)))))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          }
        }
      } else if(gra == 5){
        for(int i=0; i < (machQ-1); i++){
          if(i < 6){
            res[i] = i * massa;
            acc[i] = " in weight for "+i+"m/s.";
          } else if(i < (levelQ+6)){
            res[i] = Math.Round(i*(Math.Pow(rateQ, (i-5)))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          } else if(i < (levelQ+levelq+6)){
            res[i] = Math.Round(i*(Math.Pow(rateq, (i-((levelQ/2)+5))))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          } else if(i < (levelQ+levelq+levelt+6)){
            res[i] = Math.Round(i*(Math.Pow(ratet, (i-(((levelQ+levelq)/2)+5))))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          }else if(i < (levelQ+levelq+levelt+leveld+6)){
            res[i] = Math.Round(i*(Math.Pow(rated, (i-(((levelQ+levelq+levelt)/2)+5))))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          } else{
            res[i] = Math.Round((i*(Math.Pow(rateu, (i-(((levelQ+levelq+levelt+leveld)/2)+5)))))*massa, 2);
            acc[i] = " in weight for "+i+"m/s.";
          }
        }
      }
    }
    public static string intro = "\nWelcome to the Mechanics menu.\n"+
        "Here you may easily calculate the physics of ULF.\n"+
        "Type 'on' to run the velocity formula.\n"+
        "Type 'roll20' or other value to roll a dice.\n"+
        "Type 'calculate' to find a volume or area.\n"+
        "Type 'objects' to create or interact with objects.\n"+
        "Type 'mob' to create a mob character.\n"+
        "Type 'doc' for further explanations on methods.";
    public static string scriptum = "\nDocumentation for the Mechanics Class.\n\n"+
        ".Utor() starts this interactive terminal.\n"+
        ".Velocitas(int vigor, double massa, int mec, int gra) directly calls the velocity calculation. Input STR status then Weight; optional Mechanical Conversion level and Gracefulness level.\n"+
        ".Capacitas(int vigor, int mec) asks for a STR status, and optional Mechanical Conversion level, and returns the Character's Capacity value.\n"+
        ".Potentia(int intelligentia, int enf) asks for a INT status, and optional Energy Flow level, and returns the Character's Potency value.\n"+
        ".Celeritas(int dexteritate, int cel) asks for a DEX status, and optional Fitness level, and returns the Character's Speed value.\n"+
        ".Accuratio(int dexteritate, int acu) asks for a DEX status, and optional Presicion level, and returns the Character's Precision value.\n"+
        ".Potentia(int sapientia, int per) asks for a WIS status, and optional Perception level, and returns the Character's Perception value.\n"+
        ".Calculus(string cybus, double unus, double duo, double tribus) asks for a string for calcule type; the first number is de radius or width, the second height and the third depth. The options are: 'cube' volume, 'sphere' volume, 'cylinder' volume, 'pyramid' volume, 'cone' volume, 'area', circle 'areac', rectangle 'surface', sphere 'surfacec' and cylinder 'surfacecy.\n"+
        ".Mensula(int vigor, double massa, int mec, int gra, int from, int to) calls the same parameters as velocity, all optional, plus 'int from' and 'int to' marking the weight of the meters per seconds passed at defined Gracefulness. Call with 'gra: value', 'from: value' and 'to:value' to create a table at specified speed.\n"+
        ".Volvere(int pretium, int volutare, int mut) rolls the called dice. Valid rolls are 4, 6, 8, 10, 12, 20, 100 and 1000. 100 will roll a ULF percentile, from 0 to 100; if you wish to roll a normal 100 dice use '1000' instead.Specify a second value to make the roll more than once. Use the third parameter to modify the dice result.\n"+
        "LVolvere(int pretium, int radix, int volutare, int mut) rolls a free dice of any value; specify the first value to roll from 1 to there or specify a second value as the minimum roll. Specify 'volutare:' or a third value to make the roll more than once. Use the forth parameter to modify the dice result.\n\n\n"+
        "On the terminal use 'doc' to reach this page or 'on' to turn on the automatic velocity calculation loop. Press enter at the end to repeat or anything else to leave the application.\n"+
        "Use 'roll' plus a value to roll a dice; the values are 4, 6, 8, 10, 12, 20, % and 100. % rolls a common percentile; 100 rolls a ULF one. Then insert how many throws; leave empty if one. Use 'froll' for a free dice roll.\n"+
        "Use 'calculate' and follow the instructions to calculate a volume or area.\n"+
        "Use 'create' and follow the instructions to instantiate a new object.\n"+
        "Use 'use' to get the necessary totol energy for some interaction with said object.";
        // "Enter a command after each completed task, like right now, or press enter to leave the application."
  }
}