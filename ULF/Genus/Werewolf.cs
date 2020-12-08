using System;

namespace ULF
{
  public static class Werewolf
  {
    public static void Apto(Persona Ego){
      Console.WriteLine("\nDo you wish to 'increase' STR by 2 points or Higher-Reroll it?");
      Console.WriteLine("Type 'reroll' or 'increase'");
      Σ.rector=Console.ReadLine().ToLower();

      if(Σ.rector=="reroll"){
          Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
              Σ.rector=Console.ReadLine().ToLower();
              if(Σ.rector=="balanced"){
                  Σ.unus = Mechanicae.Volvere(4)+10;
                  if(Σ.unus > Ego.Vigor[0]){
                      Ego.Vigor[0] = Σ.unus;
                  } else{
                  }
              } else{
                  Σ.unus = Mechanicae.Volvere(20);
                  if(Σ.unus > Ego.Vigor[0]){
                      Ego.Vigor[0] = Σ.unus;
                  } else{
                  }
              }
      } else{
          Ego.Vigor[0]+=2;
      }
      Console.WriteLine("\nDo you wish to 'increase' either CON or DEX by 3 points or Higher-Reroll one?");
      Console.WriteLine("Type 'reroll' or 'increase'");
      Σ.rector=Console.ReadLine().ToLower();

      if(Σ.rector=="reroll"){
          Console.WriteLine("\nYour current CON is: "+Ego.Conditio[0]);
          Console.WriteLine("Your current DEX is: "+Ego.Dexteritate[0]);
          Console.WriteLine("Which do you wish to Higher-Reroll?");
          Σ.rector=Console.ReadLine().ToLower();

          if(Σ.rector=="con"){
              Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
              Σ.rector=Console.ReadLine().ToLower();
              if(Σ.rector=="balanced"){
                  Σ.unus = Mechanicae.Volvere(4)+10;
                  if(Σ.unus > Ego.Conditio[0]){
                      Ego.Conditio[0] = Σ.unus;
                  } else{
                  }
              } else{
                  Σ.unus = Mechanicae.Volvere(20);
                  if(Σ.unus > Ego.Conditio[0]){
                      Ego.Conditio[0] = Σ.unus;
                  } else{
                  }
              }
          } else if(Σ.rector=="dex"){
              Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
              Σ.rector=Console.ReadLine().ToLower();
              if(Σ.rector=="balanced"){
                  Σ.unus = Mechanicae.Volvere(4)+10;
                  if(Σ.unus > Ego.Dexteritate[0]){
                      Ego.Dexteritate[0] = Σ.unus;
                  } else{
                  }
              } else{
                  Σ.unus = Mechanicae.Volvere(20);
                  if(Σ.unus > Ego.Dexteritate[0]){
                      Ego.Dexteritate[0] = Σ.unus;
                  } else{
                  }
              }
          } else{
              Console.WriteLine("\nYou are an useless fat dog with neither athletics nor stamina.");
          }
              
      } else{
          Console.WriteLine("\nYour current CON is: "+Ego.Conditio[0]);
          Console.WriteLine("Your current DEX is: "+Ego.Dexteritate[0]);
          Console.WriteLine("Which do you wish to increase by 3?");
          Σ.rector=Console.ReadLine().ToLower();

          if(Σ.rector=="con"){
              Ego.Conditio[0]+=3;
          } else if(Σ.rector=="dex"){
              Ego.Dexteritate[0]+=3;
          } else{
              Console.WriteLine("\nYou are an useless fat dog with neither athletics nor stamina.");
          }
      }
      Console.WriteLine($"\n{Ego.Nomen} {Ego.Cognomen} you are a wild beast of the proud werewolf race who has taken on the world since you were born; show what your natural statuses can do:");
      Ego.Index();
    }
    public static void Cisterna(Persona Ego){
      Σ.rector = Console.ReadLine().ToLower();

      if(Σ.rector=="roll"){
        Console.WriteLine("\nAs a werewolf you have 50 base health and adds to it 1d6 for each CON point.");
        Ego.PV[0]=50;
        for (int i=0; i <= Ego.Conditio[0]; i++){
          Ego.PV[0] += Mechanicae.Volvere(6);
          Console.ReadLine();
        }
        Console.WriteLine("\nAs a werewolf you have 540 base mana and adds to it 1d12 for each INT point.");
        Ego.PM[0]=540;
        for (int i=0; i <= Ego.Intelligentia[0]; i++){
          Ego.PM[0] += Mechanicae.Volvere(20);
          Console.ReadLine();
        }
      } else{
        Ego.PV[0] = Mechanicae.Volvere(6, Ego.Conditio[0])+50;
        Ego.PM[0] = Mechanicae.Volvere(12, Ego.Intelligentia[0])+540;
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
        Ego.Altitudo = 150 + Mechanicae.Volvere(10,10);
        Ego.Latitudo = Math.Round((Ego.Altitudo / 100) * (20 + Mechanicae.Volvere(10)), 2);
        Ego.Crassitudo[1] = 4 + Mechanicae.Volvere(4);
      	Ego.Crassitudo[0] = Math.Round((Ego.Altitudo / 100) * Ego.Crassitudo[1], 2);
        Ego.Carnatio = Math.Round(Ego.Altitudo * Ego.Latitudo * Ego.Crassitudo[0], 2);
        Ego.Pondus[0] = Math.Round((Ego.Carnatio * 0.6) / 1000, 2);
        Ego.Spatium[0] = Math.Round(Ego.Altitudo / 2);
        Ego.Spatium[1] = Math.Round(Ego.Altitudo / 2);
        Ego.Planitia[0]= Math.Round(Ego.Altitudo * Ego.Latitudo, 2);
        Ego.Planitia[1]= Math.Round(Ego.Altitudo * Ego.Crassitudo[0], 2);
      } else{
        Ego.Altitudo=195;
        Ego.Latitudo=50;
        Ego.Crassitudo[1]=6;
				Ego.Crassitudo[0]=12;
        Ego.Carnatio=195*50*12;
        Ego.Pondus[0]=70;
        Ego.Spatium[0]=97;
        Ego.Spatium[1]=97;
        Ego.Planitia[0]=9750;
        Ego.Planitia[1]=2340;
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
      Ego.Pondus[0] = Math.Round((Ego.Carnatio * 0.6) / 1000, 2);
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

      Primor.Hostis[hostis].Vigor[0] = 12;
      Primor.Hostis[hostis].Dexteritate[0] = 13;
      Primor.Hostis[hostis].Conditio[0] = 10;
      Primor.Hostis[hostis].Intelligentia[0] = 10;
      Primor.Hostis[hostis].Sapientia[0] = 10;
      Primor.Hostis[hostis].Virtus();

      Primor.Hostis[hostis].Altitudo=195;
      Primor.Hostis[hostis].Latitudo=50;
      Primor.Hostis[hostis].Crassitudo[1]=6;
      Primor.Hostis[hostis].Crassitudo[0]=12;
      Primor.Hostis[hostis].Carnatio=195*50*12;
      Primor.Hostis[hostis].Pondus[0]=70;
      Primor.Hostis[hostis].Spatium[0]=97;
      Primor.Hostis[hostis].Spatium[1]=97;
      Primor.Hostis[hostis].Planitia[0]=9750;
      Primor.Hostis[hostis].Planitia[1]=2340;
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