using System;

namespace ULF
{
  public class Mana
  {
    public Iarmancy Iarmancy = new Iarmancy();
    public Aquamancy Aquamancy = new Aquamancy();
    public Pyromancy Pyromancy = new Pyromancy();
    public Taromancy Taromancy = new Taromancy();
    public Glacemancy Glacemancy = new Glacemancy();
    public Denkoumancy Denkoumancy = new Denkoumancy();
    public Yamimancy Yamimancy = new Yamimancy();
    public Almancy Almancy = new Almancy();
    public void Disciplinae(string dis, int lv=0){
      switch(dis){
        case "pyro":
          Pyromancy.livel=lv;
          break;
        case "iar":
          Iarmancy = new Iarmancy(lv);
          break;
        case "aqua":
          Aquamancy.livel=lv;
          break;
        case "taro":
          Taromancy = new Taromancy(lv);
          break;
        case "glace":
          Glacemancy = new Glacemancy(lv);
          break;
        case "denkou":
          Denkoumancy = new Denkoumancy(lv);
          break;
        case "al":
          Almancy = new Almancy(lv);
          break;
        case "yami":
          Yamimancy = new Yamimancy(lv);
          break;
        default:
          Console.WriteLine("A triffle done with magic; what greater foolishness is there!?");
          Console.ReadLine();
          Σ.rector="";
          break;
      }
    }
    public void Magus(string incantatio, Persona Ego){
      
      if(incantatio=="grimoire"){

        Pyromancy.Grimoire();
        Iarmancy.Grimoire();
        Aquamancy.Grimoire();
        Taromancy.Grimoire();
        Glacemancy.Grimoire();
        Denkoumancy.Grimoire();
        Yamimancy.Grimoire();
        Almancy.Grimoire();

        Console.WriteLine("\nChoose a spell.");
        incantatio=Console.ReadLine();
      }

      if(Pyromancy.Discere(incantatio)){
        Ego.Addicio("repertoire", incantatio);
      } else if(Iarmancy.Discere(incantatio)){
        Ego.Addicio("repertoire", incantatio);
      } else if(Aquamancy.Discere(incantatio)){
        Ego.Addicio("repertoire", incantatio);
      } else if(Taromancy.Discere(incantatio)){
        Ego.Addicio("repertoire", incantatio);
      } else if(Glacemancy.Discere(incantatio)){
        Ego.Addicio("repertoire", incantatio);
      } else if(Denkoumancy.Discere(incantatio)){
        Ego.Addicio("repertoire", incantatio);
      } else if(Yamimancy.Discere(incantatio)){
        Ego.Addicio("repertoire", incantatio);
      } else if(Almancy.Discere(incantatio)){
        Ego.Addicio("repertoire", incantatio);
      } else{
        Console.WriteLine("\nNaught was found.\nType 'grimoire' or the spell name to try again or leave it blank to exit.");
        incantatio=Console.ReadLine();
        if(incantatio!=""){
          Magus(incantatio, Ego);
        }
      }
    }
    public Ψ Spargo(string incantatio, Persona Ego){

      if(Array.Exists(Ego.Repertoire,i=>i==incantatio)){
        switch(incantatio){
          case "Fireball":
            return Pyromancy.Fireball;
          case "Icicle":
            return Glacemancy.Icicle;
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
            Console.WriteLine("\nThis spell went through the wrong dimentional plane of existence.");
            Console.ReadLine();
            break;
        }
      } else{
        Console.WriteLine("\nSpell not found within your repertoire.");
        Console.ReadLine();
      }
      return null;
    }
  }
}