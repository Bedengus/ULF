using System;

namespace ULF
{
  public class Genus
  {
    public Human Human;
    public Orc Orc;
    public Vampire Vampire;
    public Dwarf Dwarf;
    public Elf Elf;
    public Werewolf Werewolf;
    public string typus;
    public void Linea(string genus){
				switch(genus){
						case "human":
              typus="Human";
              Human = new Human();
              Human.Apto();
              break;
						case "orc":
              typus="Orc";
              Orc = new Orc();
              Orc.Apto();
              break;
						case "vampire":
              typus="Vampire";
              Vampire = new Vampire();
              Vampire.Apto();
              break;
						case "dwarf":
              typus="Dwarf";
              Dwarf = new Dwarf();
              Dwarf.Apto();
              break;
						case "elf":
              typus="Elf";
              Elf = new Elf();
              Elf.Apto();
              break;
						case "werewolf":
              typus="Werewolf";
              Werewolf = new Werewolf();
              Werewolf.Apto();
              break;
						default:
              Console.WriteLine("Currently extinct.");
              Σ.rector = "ex";
              break;    
			}
	  }
    public void Cisterna(string genus){
			Console.WriteLine("\nYour life points, HP as hit points or PV as points de vie, and mana points, MP, are determinated by your race and statuses.");
			Console.WriteLine("Type 'roll' to see the rolls one by one or anything else to skip.");

				switch(genus){
					case "human":
						Human.Cisterna();
						break;
					case "orc":
						Orc.Cisterna();
						break;
					case "vampire":
						Vampire.Cisterna();
						break;
					case "dwarf":
						Dwarf.Cisterna();
						break;
					case "elf":
						Elf.Cisterna();
						break;
					case "werewolf":
						Werewolf.Cisterna();
						break;
					default:
						break;  
			}
		}
    public void Mensura(string genus){
			Console.WriteLine("Type 'roll' to randomize proportions; input anything else to use your race's standard measures.");

      switch(genus){
        case "human":
          Human.Mensura();
          break;
        case "orc":
          Orc.Mensura();
          break;
        case "vampire":
          Vampire.Mensura();
          break;
        case "dwarf":
          Dwarf.Mensura();
          break;
        case "elf":
          Elf.Mensura();
          break;
        case "werewolf":
          Werewolf.Mensura();
          break;
        default:
          break;  
      }
      Primor.homo.Caput[0]=Math.Round((Primor.homo.Altitudo/8)*1, 2);
      Primor.homo.Caput[1]=Math.Round(Primor.homo.Caput[0]*0.5, 2);
      Primor.homo.Caput[2]=Math.Round(Primor.homo.Caput[0]*Primor.homo.Caput[1], 2);
      Primor.homo.Ocullus[0]=Math.Round((Primor.homo.Caput[1]/4)*0.5, 2);
      Primor.homo.Ocullus[1]=Math.Round(Primor.homo.Ocullus[0]*2, 2);
      Primor.homo.Ocullus[2]=Math.Round(Primor.homo.Ocullus[0]*Primor.homo.Ocullus[1], 2);
      Primor.homo.Collum[0]=Math.Round((Primor.homo.Altitudo/16)*1, 2);
      Primor.homo.Collum[1]=Math.Round(Primor.homo.Collum[0]*1, 2);
      Primor.homo.Collum[2]=Math.Round(Primor.homo.Collum[0]*Primor.homo.Collum[1], 2);
      Primor.homo.Cor[0]=Math.Round((Primor.homo.Altitudo/16)*1, 2);
      Primor.homo.Cor[1]=Math.Round(Primor.homo.Cor[0]*1, 2);
      Primor.homo.Cor[2]=Math.Round(Primor.homo.Cor[0]*Primor.homo.Cor[1], 2);
      Primor.homo.Tergum[0]=Math.Round((Primor.homo.Altitudo/8)*3.5, 2);
      Primor.homo.Tergum[1]=Math.Round(Primor.homo.Tergum[0]*0.1, 2);
      Primor.homo.Tergum[2]=Math.Round(Primor.homo.Tergum[0]*Primor.homo.Tergum[1], 2);
      Primor.homo.Bracchium[0]=Math.Round((Primor.homo.Altitudo/8)*3.5, 2);
      Primor.homo.Bracchium[1]=Math.Round(Primor.homo.Bracchium[0]*0.1, 2);
      Primor.homo.Bracchium[2]=Math.Round(Primor.homo.Bracchium[0]*Primor.homo.Bracchium[1], 2);
      Primor.homo.Stomachus[0]=Math.Round((Primor.homo.Altitudo/8)*1, 2);
      Primor.homo.Stomachus[1]=Math.Round(Primor.homo.Stomachus[0]*2, 2);
      Primor.homo.Stomachus[2]=Math.Round(Primor.homo.Stomachus[0]*Primor.homo.Stomachus[1], 2);
      Primor.homo.Crus[0]=Math.Round((Primor.homo.Altitudo/2)*1, 2);
      Primor.homo.Crus[1]=Math.Round(Primor.homo.Crus[0]*0.1, 2);
      Primor.homo.Crus[2]=Math.Round(Primor.homo.Crus[0]*Primor.homo.Crus[1], 2);
		}
    public void NovaMensura(string genus){
				switch(genus){
					case "human":
						Human.NovaMensura(Primor.homo.CorpusAptus);
						break;
					case "orc":
						Orc.NovaMensura(Primor.homo.CorpusAptus);
						break;
					case "vampire":
						Vampire.NovaMensura(Primor.homo.CorpusAptus);
						break;
					case "dwarf":
						Dwarf.NovaMensura(Primor.homo.CorpusAptus);
						break;
					case "elf":
						Elf.NovaMensura(Primor.homo.CorpusAptus);
						break;
					case "werewolf":
						Werewolf.NovaMensura(Primor.homo.CorpusAptus);
						break;
					default:
						break;  
			}
		}

    public void Renovamen(string genus){
				switch(genus){
						case "Human":
              Human = new Human();
              break;
						case "Orc":
              Orc = new Orc();
              break;
						case "Vampire":
              Vampire = new Vampire();
              break;
						case "Dwarf":
              Dwarf = new Dwarf();
              break;
						case "Elf":
              Elf = new Elf();
              break;
						case "Werewolf":
              Werewolf = new Werewolf();
              break;
						default:
              Console.WriteLine("Currently extinct.");
              Σ.rector = "ex";
              break;    
			}
		}
  
    public void Auto(string genus, string nomen){
      switch(genus){
						case "human":
              Human = new Human();
              Human.Auto(nomen);
              break;
						case "orc":
              Orc = new Orc();
              Orc.Auto(nomen);
              break;
						case "vampire":
              Vampire = new Vampire();
              Vampire.Auto(nomen);
              break;
						case "dwarf":
              Dwarf = new Dwarf();
              Dwarf.Auto(nomen);
              break;
						case "elf":
              Elf = new Elf();
              Elf.Auto(nomen);
              break;
						case "werewolf":
              Werewolf = new Werewolf();
              Werewolf.Auto(nomen);
              break;
						default:
              Human = new Human();
              Human.Auto(nomen);
              break;
      } 
    }
  }
}