using System;

namespace ULF
{
  public class Glacemancy
  {
    public int livel;
    static string[] renqueu=new string[1];
    public Ψ Icicle=new Ψ("Icicle", 0, 6, 0, 0, 2, 40, 0.1, "Physical", new string[]{"Aerodynamic", "Water", "Ice"}, new string[]{"Impetum"}, 0.4, 0);

    public Glacemancy(int lv=0){
      this.livel=lv;

      renqueu[0]="Icicle";
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