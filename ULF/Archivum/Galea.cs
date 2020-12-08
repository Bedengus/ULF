using System;

namespace ULF
{
	public class Galea : Caussae
	{
		public double Toleratio{get; private set;}

		public double[] Acutus = new double[2];
    public double[] Acutulus = new double[2];
    public double[] Obtusus = new double[2];
		public double[] Flamma = new double[2];
    public double[] Flumen = new double[2];

		/*the five doubles for damage is the reduced percentage from that source;
		the second number the outcome 0 for false and 1 for true if it can be broken by that damage
		then if burnt by fire and how it deals with energy (or lightning), where a 2 means it ignites and burns with energy too*/
		public Galea(string nom="", string mat="", double pon=1, double pre=1, double tol=1,
		double tus=1, double tus1=1, double lus=1, double lus1=1, double sus=1, double sus1=1,
		double fla=1, double fla1=1, double flu=1, double flu1=1, string fra=""):base(fra:fra){
			this.Materia=Materia.Tributare(mat);

			this.Nomen=nom;
			this.Pondus=pon;
			this.Pretium=pre;
			this.Toleratio = this.Materia.Toleratio * tol;
			this.Acutus[0]=tus;
			this.Acutulus[0]=lus;
			this.Obtusus[0]=sus;
			this.Flamma[0]=fla;
			this.Flumen[0]=flu;
			this.Acutus[1]=tus1;
			this.Acutulus[1]=lus1;
			this.Obtusus[1]=sus1;
			this.Flamma[1]=fla1;
			this.Flumen[1]=flu1;
		}

		public static Galea Ornare(string mat=""){
			Galea GoatLeatherHemelt = new Galea("Goat Leather Helmet", "Leather", 0.5, 2, 4, 33.3, 1, 33.3, 1, 50, 0, 50, 1, 50, 0, "Damaged Goat Leather Helmet");

			mat=mat.ToLower();
      switch(mat){
        case "goat leather helmet":return GoatLeatherHemelt;
        case "steel long sword":return null;
        case "steel dagger":return null;
        case "chestnut staff":return null;
        case "maple bow":return null;
        default:return null;
      }
		}

		public void Resistere(){
			double orig=Σ.num[0];
			string dunu="";
			Σ.fractus=false;
			switch(Σ.dt){
				case 0:
					if(Σ.num[0]*(this.Obtusus[0]/100)>this.Toleratio){
						Σ.num[0]-=this.Toleratio;
					} else Σ.num[0]-=Math.Floor(Σ.num[0]*(this.Obtusus[0]/100));
					dunu="crushed";
					if(this.Obtusus[1]==1){
						if(orig>this.Toleratio){
							Console.WriteLine(this.Nomen+" has been "+dunu+"!");
							Σ.fractus=true;
							}
						}
					break;
				case 1:
					if(Σ.num[0]*(this.Acutus[0]/100)>this.Toleratio){
						Σ.num[0]-=this.Toleratio;
					} else Σ.num[0]-=Math.Floor(Σ.num[0]*(this.Acutus[0]/100));
					dunu="cut";
					if(this.Acutus[1]==1){
						if(orig>this.Toleratio){
							Console.WriteLine(this.Nomen+" has been "+dunu+"!");
							Σ.fractus=true;
							}
						}
					break;
				case 2:
					if(Σ.num[0]*(this.Acutulus[0]/100)>this.Toleratio){
						Σ.num[0]-=this.Toleratio;
					} else Σ.num[0]-=Math.Floor(Σ.num[0]*(this.Acutulus[0]/100));
					dunu="penetrated";
					if(this.Acutulus[1]==1){
						if(orig>this.Toleratio){
							Console.WriteLine(this.Nomen+" has been "+dunu+"!");
							Σ.fractus=true;
							}
						}
					break;
			}
			orig-=Σ.num[0];
			Console.WriteLine("Damage reduced by "+orig+"!");
		}
	}
}