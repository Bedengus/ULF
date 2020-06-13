using System;

namespace ULF
{
  public class Denkoumancy
  {
    public int livel;
    static string[] renqueu=new string[1];
    public Denkoumancy(int lv=0){
      this.livel=lv;
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