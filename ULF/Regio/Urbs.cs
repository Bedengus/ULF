using System;
using System.Collections.Generic;

namespace ULF
{
    public class Urbs
    {
        public string Nomen{get; private set;}
        // public string[] Amplexus;
        public static Dictionary<string, int> Amplexus = new Dictionary<string, int>();
        public Urbs(string nomen, Dictionary<string, int> ample){
            Nomen=nomen;
            Amplexus=ample;

            /*Amplexus=new string[20];
            for(int u=0;u<ample.Length;u++){
                for(int d=0;d<this.Amplexus.Length;d++){
                    if(this.Amplexus[d]==null){
                    this.Amplexus[d]=ample[u];
                    break;
                    }
                }
            }*/
        }

        public static void Utor(Persona Ego){
            do{
                Console.WriteLine("\nYou are in "+Primor.homo.Regio.Nomen+"\n");
                Σ.rector = Console.ReadLine().ToLower();
                
                switch(Σ.rector){
                    case "save":
                        Ego.Salvare();
                    break;
                    case "look":
                        foreach (var u in Amplexus){
                            Console.WriteLine(u.Key+"\n");
                        }
                    break;
                    case "go":
                        Console.WriteLine("Whither?");
                        Σ.rector = Console.ReadLine();
                        Ego.Regio.Iter(Σ.rector, Ego);
                    break;
                    case "inventory":   
                        do{
                            Panoplia(Ego);
                        } while (Σ.rector == "");       
                    break;
                    case "doc":
                        Console.WriteLine(scriptum);
                        Console.ReadLine();
                    break;
                    case "help":
                        Console.WriteLine(Adventum.aux);
                        Console.ReadLine();
                    break;
                    default:
                    break;
                }
            } while(Σ.rector!="exit");
            Environment.Exit(0);
        }

        public static Urbs Advenire(string urb){
            Urbs EmeraldVillage = new Urbs("Emerald Village", new Dictionary<string, int>{{"Baazar",2}});

            switch(urb){
                case "Emerald Village":
                    return EmeraldVillage;
                case "dex":
                    //call
                    break;
                case "con":
                    //call
                    break;
                case "int":
                    //call
                    break;
                case "wis":
                    //call
                    break;
                default:
                    
                    break;
            }
            return EmeraldVillage;
        }

        public static void Panoplia(Persona Ego){
            Console.WriteLine("\nWhat do you want to do with your inventory?\n'look'\n'equip'");
            Σ.rector = Console.ReadLine().ToLower();
            if(Σ.rector=="look"){
                Ego.Spectare();
                Console.ReadLine();
            } else if(Σ.rector=="equip"){
                Console.WriteLine("\nWhat do you want to equip?");
                Σ.rector = Console.ReadLine();
                if(Array.Exists(Ego.panoN,i=>i==Σ.rector)){
                Ego.Arma = Ego.Arma.Ornare(Σ.rector.ToLower());
                Ego.Arma.Index();
                Ego.Virtus();
                } else{
                Console.WriteLine("\nYou do not have that item.");
                }
                Console.ReadLine();
            }
            Console.WriteLine("Type to exit:");
            Σ.rector = Console.ReadLine().ToLower();
        }

        public static string scriptum = "\nThis is a city."+
        "\nA city is a mid-point to seek events outside or inside, travel or use any facilities such as inns, shops and guilds."+
        "\nUse 'look' and 'go' to move to new locations.";
    }
}