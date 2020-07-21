using System;

namespace ULF
{
  public struct Lotus
  {
    public double X, Y, Z;
  }
  public static class Agrum
  {
    public static double Tempus{get; set;}
    public static double Altitudo = 0;
    public static double Latitudo = 0;

    public static double[] Centuria = new double[10];

    public static void Aeon(){
      do{
        Centuria[9]=(Centuria[2]*3600)+(Centuria[1]*150)+Centuria[0];
        if(Centuria[0]>=150){
          Centuria[0]-=150;
          Centuria[1]+=1;
        }
        if(Centuria[1]>=24){
          Centuria[1]-=24;
          Centuria[2]+=1;
        }
        if(Centuria[2]>=24){
          Centuria[2]-=24;
          Centuria[3]+=1;
        }
        if(Centuria[3]>=7){
          Centuria[4]=Math.Round(Centuria[3]/7);
        }
      } while(Centuria[0]>=150 || Centuria[1]>=24 || Centuria[2]>=24);
    }
  }
}