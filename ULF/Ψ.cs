using System;

namespace ULF
{
  public class Ψ
  {
    public string Nomen{get; private set;}
    public string Typus{get; private set;}
    public double[] Danum{get; private set;}
    public double[] Pondus{get; private set;}
    public int Incantatio{get; private set;}
    public double[] ManaPretium{get; private set;}

    public double[] Velocitas{get; private set;}
    public string Forma{get; private set;}
    public double[] FormaM{get; private set;}
    public double[] Thermo{get; private set;}
    public string[] Qualitas{get; private set;}
    public string[] Malleabile{get; private set;} // 'Explosion' for damage and area, 'Impetum' for speed
    public Ψ(string nomen, int danum, int danumd, double danumr, int danumc, int inc, int mp, double mpr, string typ, string[] qual, string[] mall, double pon=0, double ponr=0, double vel=0, double velr=0, string forma=null, double area=0, double arear=0, double areac=0, double thermo=0, double thermor=0){
      this.Nomen=nomen;
      this.Danum=new double[4];
      this.Danum[0]=danum;
      this.Danum[1]=danumd;
      this.Danum[2]=danumr;
      this.Danum[3]=danumc;
      this.Incantatio=inc;
      this.ManaPretium=new double[2];
      this.ManaPretium[0]=mp;
      this.ManaPretium[1]=mpr;
      this.Typus=typ;
      this.Pondus=new double[2];
      this.Pondus[0]=pon;
      this.Pondus[1]=ponr;

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
      this.Qualitas=new string[10];
      for(int u=0;u<qual.Length;u++){
        this.Qualitas[u]=qual[u];
      }
      this.Malleabile=new string[10];
      for(int u=0;u<mall.Length;u++){
        this.Malleabile[u]=mall[u];
      } 
    }
  }
}