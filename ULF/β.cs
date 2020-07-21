using System;
using System.Collections.Generic;

namespace ULF
{
	public class β
	{
		public string Nomen;
		public int Potentia;
		public string Virtus;
		public double Pretium;
		public int hora;
		public int[] discunt = new int[2];
		public Dictionary<string, int> Difficultas = new Dictionary<string, int>();
		public string requiritare;
		public static β VigorI = new β("Strength I", 4, "STR", 0.25, 10800, new Dictionary<string, int>{{"STR", 10}});
		public static β VigorII = new β("Strength II", 6, "STR", 0.5, 21600, new Dictionary<string, int>{{"STR", 20}}, "Strength I");
		public static β VigorIII = new β("Strength III", 8, "STR", 1, 90000, new Dictionary<string, int>{{"STR", 24}}, "Strength II");
		public static β AgilitasI = new β("Agility I", 4, "DEX", 0.25, 10800, new Dictionary<string, int>{{"DEX", 10}});
		public static β AgilitasII = new β("Agility II", 6, "DEX", 0.5, 21600, new Dictionary<string, int>{{"DEX", 20}}, "Agility I");
		public static β AgilitasIII = new β("Agility III", 8, "DEX", 1, 90000, new Dictionary<string, int>{{"DEX", 24}}, "Agility II");
		public static β EnduranceI = new β("Endurance I", 4, "CON", 0.25, 10800, new Dictionary<string, int>{{"CON", 10}});
		public static β EnduranceII = new β("Endurance II", 6, "CON", 0.5, 21600, new Dictionary<string, int>{{"CON", 20}}, "Endurance I");
		public static β EnduranceIII = new β("Endurance III", 8, "CON", 1, 90000, new Dictionary<string, int>{{"CON", 24}}, "Endurance II");
		public static β PuissanceI = new β("Potency I", 4, "INT", 0.25, 10800, new Dictionary<string, int>{{"INT", 10}});
		public static β PuissanceII = new β("Potency II", 6, "INT", 0.5, 21600, new Dictionary<string, int>{{"INT", 20}}, "Potency I");
		public static β PuissanceIII = new β("Potency III", 8, "INT", 1, 90000, new Dictionary<string, int>{{"INT", 24}}, "Potency II");
		public static β FocusI = new β("Focus I", 4, "WIS", 0.25, 10800, new Dictionary<string, int>{{"WIS", 10}});
		public static β FocusII = new β("Focus II", 6, "WIS", 0.5, 21600, new Dictionary<string, int>{{"WIS", 20}}, "Focus I");
		public static β FocusIII = new β("Focus III", 8, "WIS", 1, 90000, new Dictionary<string, int>{{"INT", 24}}, "Focus II");


		public β(string nom, int pot, string vir, double pre, int hor, Dictionary<string, int> dif, string req=""){
			this.Nomen=nom;
			this.Potentia=pot;
			this.Virtus=vir;
			this.Pretium=pre;
			this.hora=hor;
			this.Difficultas=dif;
			this.requiritare=req;
		}

		public static β Buff(string b){
		
			switch(b){
				case "Strength I":
					return VigorI;
				case "Strength II":
					return VigorII;
				case "Strength III":
					return VigorIII;
				case "Agility I":
					return AgilitasI;
				case "Agility II":
					return AgilitasII;
				case "Agility III":
					return AgilitasIII;
				case "Endurance I":
					return EnduranceI;
				case "Endurance II":
					return EnduranceII;
				case "Endurance III":
					return EnduranceIII;
				case "Potency I":
					return PuissanceI;
				case "Potency II":
					return PuissanceII;
				case "Potency III":
					return PuissanceIII;
				case "Focus I":
					return FocusI;
				case "Focus II":
					return FocusII;
				case "Focus III":
					return FocusIII;
				default:
					return null;
			}	
		}
	}
}