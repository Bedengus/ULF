using System;

namespace ULF
{
    public class Yuno
    {
        public void Sensus(string sensus, Persona Ego, Persona hostis){
            switch(sensus){
                case "Mulus":
                    Mulus.Sensus(Ego, hostis);
                    break;
                default:
                    
                    break;
            }
        }
    }
}