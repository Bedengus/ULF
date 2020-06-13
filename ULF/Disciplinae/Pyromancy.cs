using System;

namespace ULF
{
  public class Pyromancy
  {
    public int livel;
    static string[] renqueu=new string[1];
    public Ψ Fireball=new Ψ("Fireball", 40, 20, 0.6, 120, 12, 240, 2, "Explosion", new string[]{"Fire"}, new string[]{"Explosion"}, 0, 0, 5, 0, "Sphere", 200, 0.02, 500, 800, 4);
    public Pyromancy(int lv=0){
      this.livel=lv;

      renqueu[0]="Fireball";
    }
    
    public bool Discere(string incantatio){

      if(this.livel>0){
        if(Array.Exists(renqueu,i=>i==incantatio)){
          return true;
        }
      }
      return false;
    }
    public void Grimoire(){

      if(this.livel>0){
        for(int i=0;i<renqueu.Length;i++){
          if(renqueu[i]==null){

          } else{
            Console.WriteLine(renqueu[i]);
          }
        }
      }
    }
  }
}