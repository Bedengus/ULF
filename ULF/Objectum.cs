using System;

namespace ULF
{
  public class Objectum
  {
    public Materiae Materia = new Materiae();
    public string Nomen{get; set;}
    public string Forma{get; set;}
    public string Depictio{get; set;}
    public double Altitudo{get; set;}
		public double Latitudo{get; set;}
		public double Crassitudo{get; set;}
		public double Pondus{get; set;}
		public double Carnatio{get; set;}
    public double Superficiem{get; set;}

    public void Materiae(string mat=""){
      Materia = Materia.Tributare(mat);
    }
    public void Index(){
      if(this.Nomen==null){
        Console.WriteLine(Depictio);
      } else{
        Console.WriteLine($"This object, named {this.Nomen}, is made out of {this.Materia.Nomen}. With a volume of {this.Carnatio} cubic centimetres and a density of {this.Materia.Densitas}g/cm³ it weights {this.Pondus} grams over a surface area of {this.Superficiem}cm².");
      }
    }
  }
}