using System;
using System.Collections.Generic;

namespace ULF
{
  public class Regio
  {
    public string Nomen;
    public int regioid;
    public int lumen;
    public int nox;
    public Dictionary<string, string> Amplexus = new Dictionary<string, string>();

    public string[] praesto = new string[20];
    public string[] praestawn = new string[20];
    public int[] spawawn = new int[20];
    public double[] spawawnd = new double[20];

    public Regio(string nomen, string[] prae, int lum=0, int noc=86400, Dictionary<string, string> ample=null){
      this.Nomen=nomen;
      this.Amplexus=ample; 
      this.lumen=lum;
      this.nox=noc;
      this.praesto=prae;
      this.praestawn=prae;
    }

    public void Iter(string reg, Persona Ego){
      if(this.Amplexus.ContainsKey(reg)){
        Iter(this.Amplexus[reg], reg, Ego);
      }else{
        Console.WriteLine("That place does not exist or is not avaliable from here.");
      }
    }

    public void Iter(string id, string reg, Persona Ego){
      switch(id.Substring(0,1)){
        case "1":
          Urbs(id, reg, Ego);
          break;
        case "2":
          Forum(id, reg, Ego);
          break;
        case "3":
          Societas(id, reg, Ego);
          break;
        case "4":
          Taberna(id, reg, Ego);
          break;
        case "5":
          Exterius(id, reg, Ego);
          break;
      }
    }
    public static Regio Labor(string reg){
      if(ULF.Urbs.Advenire(reg)!=null){
        return ULF.Urbs.Advenire(reg);
      } else if(ULF.Forum.Advenire(reg)!=null){
        return ULF.Forum.Advenire(reg);
      } else if(ULF.Societas.Advenire(reg)!=null){
        return ULF.Societas.Advenire(reg);
      } else if(ULF.Taberna.Advenire(reg)!=null){
        return ULF.Taberna.Advenire(reg);
      } else if(ULF.Exterius.Advenire(reg)!=null){
        return ULF.Exterius.Advenire(reg);
      } else{
        return null;
      }
    }
    public void Urbs(string id, string reg, Persona Ego){ 
      this.Nomen=ULF.Urbs.Advenire(reg).Nomen;
      this.Amplexus=ULF.Urbs.Advenire(reg).Amplexus;
      this.regioid=1;
      Agrum.Centuria[0]+=Convert.ToInt32(id.Substring(1,5));
      Adventum.Verso(Ego);
      ULF.Urbs.Advenire(reg).Utor(Ego);
    }
    public void Forum(string id, string reg, Persona Ego){
      this.Nomen=ULF.Forum.Advenire(reg).Nomen;
      this.Amplexus=ULF.Forum.Advenire(reg).Amplexus;
      this.regioid=2;
      Agrum.Centuria[0]+=Convert.ToInt32(id.Substring(1,5));
      Adventum.Verso(Ego);
      ULF.Forum.Advenire(reg).Utor(Ego);
    }
    public void Societas(string id, string reg, Persona Ego){
      this.Nomen=ULF.Societas.Advenire(reg).Nomen;
      this.Amplexus=ULF.Societas.Advenire(reg).Amplexus;
      this.regioid=3;
      Agrum.Centuria[0]+=Convert.ToInt32(id.Substring(1,5));
      Adventum.Verso(Ego);
      ULF.Societas.Advenire(reg).Utor(Ego);
    }
    public void Taberna(string id, string reg, Persona Ego){
      this.Nomen=ULF.Taberna.Advenire(reg).Nomen;
      this.Amplexus=ULF.Taberna.Advenire(reg).Amplexus;
      this.regioid=4;
      Agrum.Centuria[0]+=Convert.ToInt32(id.Substring(1,5));
      Adventum.Verso(Ego);
      ULF.Taberna.Advenire(reg).Utor(Ego);
    }
    public void Exterius(string id, string reg, Persona Ego){ 
      this.Nomen=ULF.Exterius.Advenire(reg).Nomen;
      this.Amplexus=ULF.Exterius.Advenire(reg).Amplexus;
      this.regioid=5;
      Agrum.Centuria[0]+=Convert.ToInt32(id.Substring(1,5));
      Adventum.Verso(Ego);
      ULF.Exterius.Advenire(reg).Utor(Ego);
    }

    public void Paridor(){
      if(this.praesto!=this.praestawn){
        for(int u=0;u<this.spawawn.Length;u++){
          if(this.spawawn[u]>0){
            if(this.spawawn[u]+this.spawawnd[u]<=Agrum.Centuria[9]){
              this.praesto[u]=this.praestawn[u];
              this.spawawn[u]=0;
              this.spawawnd[u]=0;
            }
          }
        }
      }
    }
  }
}