using System;

namespace ULF
{
    public class Mulus : Yuno
    {
        public static void Sensus(Persona Ego, Persona hostis){
            if(Ego.Spatium[1]>=Mechanicae.Calculus("hypod",Math.Abs(Ego.Lotus[0]-hostis.Lotus[0]),Math.Abs(Ego.Lotus[1]-hostis.Lotus[1]))){
                Ego.verb="Strike";
            } else{
                Ego.verb="Step";
            }
        }
    }
}