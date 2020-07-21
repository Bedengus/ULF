using System;

namespace ULF
{
  public class Genus
  {
    public string typus;
    public void Linea(string genus, Persona Ego){
      genus=genus.ToLower();
      switch(genus){
        case "human":
          typus="Human";
          Human.Apto(Ego);
          break;
        case "orc":
          typus="Orc";
          Orc.Apto(Ego);
          break;
        case "vampire":
          typus="Vampire";
          Vampire.Apto(Ego);
          break;
        case "dwarf":
          typus="Dwarf";
          Dwarf.Apto(Ego);
          break;
        case "elf":
          typus="Elf";
          Elf.Apto(Ego);
          break;
        case "werewolf":
          typus="Werewolf";
          Werewolf.Apto(Ego);
          break;
        default:
          Console.WriteLine("Currently extinct.");
          Σ.rector = "ex";
          break;    
      }
      Cisterna(typus, Ego);
	  }
    public void Cisterna(string genus, Persona Ego){
			Console.WriteLine("\nYour life points, HP as hit points or PV as points de vie, and mana points, MP, are determinated by your race and statuses.");
			Console.WriteLine("Type 'roll' to see the rolls one by one or anything else to skip.");

        genus=genus.ToLower();
				switch(genus){
					case "human":
						Human.Cisterna(Ego);
						break;
					case "orc":
						Orc.Cisterna(Ego);
						break;
					case "vampire":
						Vampire.Cisterna(Ego);
						break;
					case "dwarf":
						Dwarf.Cisterna(Ego);
						break;
					case "elf":
						Elf.Cisterna(Ego);
						break;
					case "werewolf":
						Werewolf.Cisterna(Ego);
						break;
					default:
						break;  
			}
      Mensura(typus, Ego);
		}
    public void Mensura(string genus, Persona Ego){
			Console.WriteLine("Type 'roll' to randomize proportions; input anything else to use your race's standard measures.");

      genus=genus.ToLower();
      switch(genus){
        case "human":
          Human.Mensura(Ego);
          break;
        case "orc":
          Orc.Mensura(Ego);
          break;
        case "vampire":
          Vampire.Mensura(Ego);
          break;
        case "dwarf":
          Dwarf.Mensura(Ego);
          break;
        case "elf":
          Elf.Mensura(Ego);
          break;
        case "werewolf":
          Werewolf.Mensura(Ego);
          break;
        default:
          break;  
      }
      Ego.Caput[0]=Math.Round((Ego.Altitudo/8)*1, 2);
      Ego.Caput[1]=Math.Round(Ego.Caput[0]*0.5, 2);
      Ego.Caput[2]=Math.Round(Ego.Caput[0]*Ego.Caput[1], 2);
      Ego.Ocullus[0]=Math.Round((Ego.Caput[1]/4)*0.5, 2);
      Ego.Ocullus[1]=Math.Round(Ego.Ocullus[0]*2, 2);
      Ego.Ocullus[2]=Math.Round(Ego.Ocullus[0]*Ego.Ocullus[1], 2);
      Ego.Collum[0]=Math.Round((Ego.Altitudo/16)*1, 2);
      Ego.Collum[1]=Math.Round(Ego.Collum[0]*1, 2);
      Ego.Collum[2]=Math.Round(Ego.Collum[0]*Ego.Collum[1], 2);
      Ego.Cor[0]=Math.Round((Ego.Altitudo/16)*1, 2);
      Ego.Cor[1]=Math.Round(Ego.Cor[0]*1, 2);
      Ego.Cor[2]=Math.Round(Ego.Cor[0]*Ego.Cor[1], 2);
      Ego.Tergum[0]=Math.Round((Ego.Altitudo/8)*3.5, 2);
      Ego.Tergum[1]=Math.Round(Ego.Tergum[0]*0.1, 2);
      Ego.Tergum[2]=Math.Round(Ego.Tergum[0]*Ego.Tergum[1], 2);
      Ego.Bracchium[0]=Math.Round((Ego.Altitudo/8)*3.5, 2);
      Ego.Bracchium[1]=Math.Round(Ego.Bracchium[0]*0.1, 2);
      Ego.Bracchium[2]=Math.Round(Ego.Bracchium[0]*Ego.Bracchium[1], 2);
      Ego.Stomachus[0]=Math.Round((Ego.Altitudo/8)*1, 2);
      Ego.Stomachus[1]=Math.Round(Ego.Stomachus[0]*2, 2);
      Ego.Stomachus[2]=Math.Round(Ego.Stomachus[0]*Ego.Stomachus[1], 2);
      Ego.Crus[0]=Math.Round((Ego.Altitudo/2)*1, 2);
      Ego.Crus[1]=Math.Round(Ego.Crus[0]*0.1, 2);
      Ego.Crus[2]=Math.Round(Ego.Crus[0]*Ego.Crus[1], 2);
		}

    /*public void NovaMensura(string genus){
				switch(genus){
					case "human":
						Human.NovaMensura(Ego.CorpusAptus);
						break;
					case "orc":
						Orc.NovaMensura(Ego.CorpusAptus);
						break;
					case "vampire":
						Vampire.NovaMensura(Ego.CorpusAptus);
						break;
					case "dwarf":
						Dwarf.NovaMensura(Ego.CorpusAptus);
						break;
					case "elf":
						Elf.NovaMensura(Ego.CorpusAptus);
						break;
					case "werewolf":
						Werewolf.NovaMensura(Ego.CorpusAptus);
						break;
					default:
						break;  
			}
		}*/
  
    public void Auto(string genus, string nomen){
      genus=genus.ToLower();
      switch(genus){
						case "human":
              Human.Auto(nomen);
              break;
						case "orc":
              Orc.Auto(nomen);
              break;
						case "vampire":
              Vampire.Auto(nomen);
              break;
						case "dwarf":
              Dwarf.Auto(nomen);
              break;
						case "elf":
              Elf.Auto(nomen);
              break;
						case "werewolf":
              Werewolf.Auto(nomen);
              break;
            case "quadrupod":
              Quadrupod.Auto(nomen);
              break;
						default:
              Human.Auto(nomen);
              break;
      } 
    }
  }
}