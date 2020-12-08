using System;

namespace ULF
{
	public class Opes
	{
		public string Nomen{get; protected set;}

		public string Depictium;
    public int id;
    public int chronus;
    public string conditio;

		public string occumbo;

    public Opes(string nomen="", string dep="", int id=0, int chro=0, string occ="", string con=""){
      this.Nomen=nomen;
			this.Depictium=dep;
			this.id=id;
      this.chronus=chro; 
      this.conditio=con;
			this.occumbo=occ;
    }

		public static Opes Origo(string opes){
			
			Opes Teak = new Opes("Teak", "A skinny teak tree.", 1, 36000, "Teak Log", "hipster1");
			Opes Chestnut = new Opes("Chestnut", "A fragant chestnut tree.", 1, 36000, "Chestnut Log","hipster1");
			Opes Maple = new Opes("Maple", "A pretty maple tree.", 1, 36000, "Maple Log", "hipster2");

			switch(opes){
				case "Teak":return Teak;
				case "Chestnut":return Chestnut;
				case "Maple":return Maple;
				default:return null;
			}
			// Logs come in a 100 x 36 cilinder; that is 0.1 cubic meter. 100 liters or 42 board feet. So we can roll 3.2 to 6 credits per log in direct conversion, which is a lot really.
			/*Here are some log prices
			Red oak $.70 per bf. clear saw log = $112, $1.00 per bf. veneer log= $160
 
			White oak $.85 per bf. clear saw log = $136, $1.50 per bf. veneer log= $240
			
			Walnut $1.70 per bf. clear saw log = $272, $3.50 per bf. veneer log= $560
			
			Cherry $.90 per bf. clear saw log = $144, $1.40 per bf. veneer log= $224
			
			Hard Maple $.75 per bf. clear saw log = $120, $1.25 per bf. veneer log= $200*/
			// A log makes 10 planks o 100 x 3, plus six splinters. Each plank of teak, which is 3.2 the log, is worth some 0.45-0.5 C,
			//leading to 4.5 to 5.0 on a log, but usage of the saw and tax must be paid on the guild. Planks can also be of 100x6. Then likely colluns thicker too.
			// Splinters can burn in fire and kindling; and be made into arrow shaft. Weight wise it is around 400 arrows, but that, with tip and feather, is way too much at 40c.
		}

		public Caussae Auctumnum(){
			return Caussae.Acquirere(this.occumbo);
		}
	}
}