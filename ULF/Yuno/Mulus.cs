using System;

namespace ULF
{
    public class Mulus : Yuno
    {
        public static void Sensus(Persona Ego, Persona hostis){
            if(Ego.Spatium[1]>=Mechanicae.Calculus("hypod",Math.Abs(Ego.Lotus.X-hostis.Lotus.X),Math.Abs(Ego.Lotus.Y-hostis.Lotus.Y))){
                Ego.verb="Strike";
            } else{
                Ego.verb="Step";
            }
        }
    }
}