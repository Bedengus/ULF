using System;

namespace ULF
{
  public static class Elf
  {
    public static void Apto(Persona Ego){
      Console.WriteLine("\nDo you wish to 'increase' either INT or DEX or WIS by 4 points, if less than nineteen, or Choose-Reroll a 1d20 at each?");
      Console.WriteLine("Type 'reroll' or 'increase'");
      Σ.rector=Console.ReadLine().ToLower();

      if (Σ.rector=="reroll"){
          Console.WriteLine("\nYour current WIS is: "+Ego.Sapientia[0]);
          Console.WriteLine("Your current INT is: "+Ego.Intelligentia[0]);
          Console.WriteLine("Your current DEX is: "+Ego.Dexteritate[0]);

          Σ.unus = Mechanicae.Volvere(20);

          Console.WriteLine("\nDo you wish to keep the 'old' roll or the 'new' roll for Wisdom?");
          Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="new"){
              Ego.Sapientia[0] = Σ.unus;
          } else{
              Console.WriteLine("\nYou keep your old Wisdom.");
          }

          Σ.unus = Mechanicae.Volvere(20);

          Console.WriteLine("\nDo you wish to keep the 'old' roll or the 'new' roll for Intelligence?");
          Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="new"){
              Ego.Intelligentia[0] = Σ.unus;
          } else{
              Console.WriteLine("\nYou keep your old Intelligence.");
          }

          Σ.unus = Mechanicae.Volvere(20);

          Console.WriteLine("\nDo you wish to keep the 'old' roll or the 'new' roll for Dexterity?");
          Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="new"){
              Ego.Dexteritate[0] = Σ.unus;
          } else{
              Console.WriteLine("\nYou keep your old Dexterity.");
          }
      } else if(Σ.rector=="increase"){
          Console.WriteLine("\nYour current WIS is: "+Ego.Sapientia[0]);
          Console.WriteLine("Your current INT is: "+Ego.Intelligentia[0]);
          Console.WriteLine("Your current DEX is: "+Ego.Dexteritate[0]);
          Console.WriteLine("Which do you wish to increment by 4?");
          Σ.rector=Console.ReadLine().ToLower();

          if(Σ.rector=="dex" && Ego.Dexteritate[0] < 19){
              Ego.Dexteritate[0]+=4;
          } else if(Σ.rector=="int" && Ego.Intelligentia[0] < 19){
              Ego.Intelligentia[0]+=4;
          } else if(Σ.rector=="wis" && Ego.Sapientia[0] < 19){
              Ego.Sapientia[0]+=4;
          } else{
              Console.WriteLine("\nYou make an academic mistake and suddenly your life sucks!");
          }
      }else{
          Ego.Dexteritate[0]+=4;
      }
      Console.WriteLine($"\n{Ego.Nomen} {Ego.Cognomen} kisama ha ririshii erufu de aru; and with your elitism you think the world will be an easy win:");
      Ego.Index();
    }
    public static void Cisterna(Persona Ego){
      Σ.rector = Console.ReadLine().ToLower();

      if(Σ.rector=="roll"){
        Console.WriteLine("\nAs an elf you have 50 base health and adds to it 1d4 for each CON point.");
        Ego.PV[0]=50;
        for (int i=0; i <= Ego.Conditio[0]; i++)
        {
          Ego.PV[0] += Mechanicae.Volvere(4);
          Console.ReadLine();
        }
        Console.WriteLine("\nAs an elf you have 640 base mana and adds to it 1d20 for each INT point.");
        Ego.PM[0]=640;
        for (int i=0; i <= Ego.Intelligentia[0]; i++)
        {
          Ego.PM[0] += Mechanicae.Volvere(20);
          Console.ReadLine();
        }
      } else{
        Ego.PV[0] = Mechanicae.Volvere(4, Ego.Conditio[0])+50;
        Ego.PM[0] = Mechanicae.Volvere(20, Ego.Intelligentia[0])+640;
      }
      Ego.PV[1]=Ego.PV[0];
      Ego.PM[1]=Ego.PM[0];
      Console.WriteLine("\nPV: "+Ego.PV[0]);
      Console.WriteLine("MP: "+Ego.PM[0]);
      Console.ReadLine();
    }
    public static void Mensura(Persona Ego){
      Σ.rector=Console.ReadLine().ToLower();

      if(Σ.rector=="roll"){
        Ego.Altitudo = 130 + Mechanicae.Volvere(10,10);
        Ego.Latitudo = Math.Round((Ego.Altitudo / 100) * (20 + Mechanicae.Volvere(10)), 2);
        Ego.Crassitudo[1] = 4 + Mechanicae.Volvere(4);
      	Ego.Crassitudo[0] = Math.Round((Ego.Altitudo / 100) * Ego.Crassitudo[1], 2);
        Ego.Carnatio = Math.Round(Ego.Altitudo * Ego.Latitudo * Ego.Crassitudo[0], 2);
        Ego.Pondus = Math.Round((Ego.Carnatio * 0.7) / 1000, 2);
        Ego.Spatium[0] = Math.Round(Ego.Altitudo / 2);
        Ego.Spatium[1] = Math.Round(Ego.Altitudo / 2);
        Ego.Planitia[0]= Math.Round(Ego.Altitudo * Ego.Latitudo, 2);
        Ego.Planitia[1]= Math.Round(Ego.Altitudo * Ego.Crassitudo[0], 2);
      } else{
        Ego.Altitudo=180;
        Ego.Latitudo=45;
        Ego.Crassitudo[1]=6;
				Ego.Crassitudo[0]=10;
        Ego.Carnatio=180*45*10;
        Ego.Pondus=56;
        Ego.Spatium[0]=90;
        Ego.Spatium[1]=90;
        Ego.Planitia[0]=8150;
        Ego.Planitia[1]=1800;
      }
			Ego.Index("dimensions");
      Console.ReadLine();
    }
    public static void NovaMensura(Persona Ego, int cel=3){
			if(cel>=3){
				Ego.Crassitudo[1] = 4 + Mechanicae.Volvere(4);
			} else if(cel==2){
				Ego.Crassitudo[1] = Math.Round((4 + Mechanicae.Volvere(4))*1.2);
			} else if(cel==1){
				Ego.Crassitudo[1] = Math.Round((4 + Mechanicae.Volvere(4))*1.5);
			}
      Ego.Crassitudo[0] = Math.Round((Ego.Altitudo / 100) * Ego.Crassitudo[1], 2);
      Ego.Carnatio = Math.Round(Ego.Altitudo * Ego.Latitudo * Ego.Crassitudo[0], 2);
      Ego.Pondus = Math.Round((Ego.Carnatio * 0.7) / 1000, 2);
      Ego.Planitia[0]= Math.Round(Ego.Altitudo * Ego.Latitudo, 2);
      Ego.Planitia[1]= Math.Round(Ego.Altitudo * Ego.Crassitudo[0], 2);
			Ego.Index("dimensions");
      Console.ReadLine();
    }

    public static void Auto(string hostis){
      
      Primor.Hostis[hostis].PV[0] = 100;
      Primor.Hostis[hostis].PM[0] = 600;
      Primor.Hostis[hostis].PV[1]=Primor.Hostis[hostis].PV[0];
      Primor.Hostis[hostis].PM[1]=Primor.Hostis[hostis].PM[0];

      Primor.Hostis[hostis].Vigor[0] = 10;
      Primor.Hostis[hostis].Dexteritate[0] = 13;
      Primor.Hostis[hostis].Conditio[0] = 10;
      Primor.Hostis[hostis].Intelligentia[0] = 13;
      Primor.Hostis[hostis].Sapientia[0] = 13;
      Primor.Hostis[hostis].Virtus();

      Primor.Hostis[hostis].Altitudo=180;
      Primor.Hostis[hostis].Latitudo=45;
      Primor.Hostis[hostis].Crassitudo[1]=6;
      Primor.Hostis[hostis].Crassitudo[0]=10;
      Primor.Hostis[hostis].Carnatio=180*45*10;
      Primor.Hostis[hostis].Pondus=56;
      Primor.Hostis[hostis].Spatium[0]=90;
      Primor.Hostis[hostis].Spatium[1]=90;
      Primor.Hostis[hostis].Planitia[0]=8150;
      Primor.Hostis[hostis].Planitia[1]=1800;
      Primor.Hostis[hostis].Caput[0]=Math.Round((Primor.Hostis[hostis].Altitudo/8)*1, 2);
      Primor.Hostis[hostis].Caput[1]=Math.Round(Primor.Hostis[hostis].Caput[0]*0.5, 2);
      Primor.Hostis[hostis].Caput[2]=Math.Round(Primor.Hostis[hostis].Caput[0]*Primor.Hostis[hostis].Caput[1], 2);
      Primor.Hostis[hostis].Ocullus[0]=Math.Round((Primor.Hostis[hostis].Caput[1]/4)*0.5, 2);
      Primor.Hostis[hostis].Ocullus[1]=Math.Round(Primor.Hostis[hostis].Ocullus[0]*2, 2);
      Primor.Hostis[hostis].Ocullus[2]=Math.Round(Primor.Hostis[hostis].Ocullus[0]*Primor.Hostis[hostis].Ocullus[1], 2);
      Primor.Hostis[hostis].Collum[0]=Math.Round((Primor.Hostis[hostis].Altitudo/16)*1, 2);
      Primor.Hostis[hostis].Collum[1]=Math.Round(Primor.Hostis[hostis].Collum[0]*1, 2);
      Primor.Hostis[hostis].Collum[2]=Math.Round(Primor.Hostis[hostis].Collum[0]*Primor.Hostis[hostis].Collum[1], 2);
      Primor.Hostis[hostis].Cor[0]=Math.Round((Primor.Hostis[hostis].Altitudo/16)*1, 2);
      Primor.Hostis[hostis].Cor[1]=Math.Round(Primor.Hostis[hostis].Cor[0]*1, 2);
      Primor.Hostis[hostis].Cor[2]=Math.Round(Primor.Hostis[hostis].Cor[0]*Primor.Hostis[hostis].Cor[1], 2);
      Primor.Hostis[hostis].Tergum[0]=Math.Round((Primor.Hostis[hostis].Altitudo/8)*3.5, 2);
      Primor.Hostis[hostis].Tergum[1]=Math.Round(Primor.Hostis[hostis].Tergum[0]*0.1, 2);
      Primor.Hostis[hostis].Tergum[2]=Math.Round(Primor.Hostis[hostis].Tergum[0]*Primor.Hostis[hostis].Tergum[1], 2);
      Primor.Hostis[hostis].Bracchium[0]=Math.Round((Primor.Hostis[hostis].Altitudo/8)*3.5, 2);
      Primor.Hostis[hostis].Bracchium[1]=Math.Round(Primor.Hostis[hostis].Bracchium[0]*0.1, 2);
      Primor.Hostis[hostis].Bracchium[2]=Math.Round(Primor.Hostis[hostis].Bracchium[0]*Primor.Hostis[hostis].Bracchium[1], 2);
      Primor.Hostis[hostis].Stomachus[0]=Math.Round((Primor.Hostis[hostis].Altitudo/8)*1, 2);
      Primor.Hostis[hostis].Stomachus[1]=Math.Round(Primor.Hostis[hostis].Stomachus[0]*2, 2);
      Primor.Hostis[hostis].Stomachus[2]=Math.Round(Primor.Hostis[hostis].Stomachus[0]*Primor.Hostis[hostis].Stomachus[1], 2);
      Primor.Hostis[hostis].Crus[0]=Math.Round((Primor.Hostis[hostis].Altitudo/2)*1, 2);
      Primor.Hostis[hostis].Crus[1]=Math.Round(Primor.Hostis[hostis].Crus[0]*0.1, 2);
      Primor.Hostis[hostis].Crus[2]=Math.Round(Primor.Hostis[hostis].Crus[0]*Primor.Hostis[hostis].Crus[1], 2);
    }
  }
}