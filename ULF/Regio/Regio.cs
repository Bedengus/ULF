using System;
using System.Collections.Generic;

namespace ULF
{
  public class Regio
  {
    public string Nomen{get; private set;}
    public Urbs praesenurbs = new ULF.Urbs("", new Dictionary<string, int>{{"",0}});
    public Forum praesenforum = new ULF.Forum("", new Dictionary<string, int>{{"",0}});
    public int regioid;
    public Dictionary<string, int> Amplexus = new Dictionary<string, int>();

    public void Iter(string reg, Persona Ego){
      if(Amplexus.ContainsKey(reg)){
        Iter(Amplexus[reg], reg, Ego);
      }else{
        Console.WriteLine("That place does not exist or is not avaliable from here.");
      }
    }

    public void Iter(int id, string reg, Persona Ego){
      switch(id){
        case 1:
          Urbs(reg, Ego);
          break;
        case 2:
          Forum(reg, Ego);
          break;
        default:
          
          break;
      }
    }
    public void Urbs(string reg, Persona Ego){
      praesenurbs = ULF.Urbs.Advenire(reg);
      this.Nomen=praesenurbs.Nomen;
      this.Amplexus=ULF.Urbs.Amplexus;
      this.regioid=1;
      ULF.Urbs.Utor(Ego);
    }
    public void Forum(string reg, Persona Ego){
      praesenforum = ULF.Forum.Advenire(reg);
      this.Nomen=praesenforum.Nomen;
      this.Amplexus=ULF.Forum.Amplexus;
      this.regioid=2;
      ULF.Forum.Utor(Ego);
    }
  }
}