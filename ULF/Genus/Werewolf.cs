using System;

namespace ULF
{
  public class Werewolf : Genus
  {
    public void Apto(){
      Console.WriteLine("\nDo you wish to 'increase' STR by 2 points or Higher-Reroll it?");
      Console.WriteLine("Type 'reroll' or 'increase'");
      Σ.rector=Console.ReadLine().ToLower();

      if(Σ.rector=="reroll"){
          Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
              Σ.rector=Console.ReadLine().ToLower();
              if(Σ.rector=="balanced"){
                  Σ.unus = Mechanicae.Volvere(4)+10;
                  if(Σ.unus > Primor.homo.Vigor){
                      Primor.homo.Vigor = Σ.unus;
                  } else{
                  }
              } else{
                  Σ.unus = Mechanicae.Volvere(20);
                  if(Σ.unus > Primor.homo.Vigor){
                      Primor.homo.Vigor = Σ.unus;
                  } else{
                  }
              }
      } else{
          Primor.homo.Vigor+=2;
      }
      Console.WriteLine("\nDo you wish to 'increase' either CON or DEX by 3 points or Higher-Reroll one?");
      Console.WriteLine("Type 'reroll' or 'increase'");
      Σ.rector=Console.ReadLine().ToLower();

      if(Σ.rector=="reroll"){
          Console.WriteLine("\nYour current CON is: "+Primor.homo.Conditio);
          Console.WriteLine("Your current DEX is: "+Primor.homo.Dexteritate);
          Console.WriteLine("Which do you wish to Higher-Reroll?");
          Σ.rector=Console.ReadLine().ToLower();

          if(Σ.rector=="con"){
              Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
              Σ.rector=Console.ReadLine().ToLower();
              if(Σ.rector=="balanced"){
                  Σ.unus = Mechanicae.Volvere(4)+10;
                  if(Σ.unus > Primor.homo.Conditio){
                      Primor.homo.Conditio = Σ.unus;
                  } else{
                  }
              } else{
                  Σ.unus = Mechanicae.Volvere(20);
                  if(Σ.unus > Primor.homo.Conditio){
                      Primor.homo.Conditio = Σ.unus;
                  } else{
                  }
              }
          } else if(Σ.rector=="dex"){
              Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
              Σ.rector=Console.ReadLine().ToLower();
              if(Σ.rector=="balanced"){
                  Σ.unus = Mechanicae.Volvere(4)+10;
                  if(Σ.unus > Primor.homo.Dexteritate){
                      Primor.homo.Dexteritate = Σ.unus;
                  } else{
                  }
              } else{
                  Σ.unus = Mechanicae.Volvere(20);
                  if(Σ.unus > Primor.homo.Dexteritate){
                      Primor.homo.Dexteritate = Σ.unus;
                  } else{
                  }
              }
          } else{
              Console.WriteLine("\nYou are an useless fat dog with neither athletics nor stamina.");
          }
              
      } else{
          Console.WriteLine("\nYour current CON is: "+Primor.homo.Conditio);
          Console.WriteLine("Your current DEX is: "+Primor.homo.Dexteritate);
          Console.WriteLine("Which do you wish to increase by 3?");
          Σ.rector=Console.ReadLine().ToLower();

          if(Σ.rector=="con"){
              Primor.homo.Conditio+=3;
          } else if(Σ.rector=="dex"){
              Primor.homo.Dexteritate+=3;
          } else{
              Console.WriteLine("\nYou are an useless fat dog with neither athletics nor stamina.");
          }
      }
      Primor.homo.Genus.Cisterna(Primor.homo.Genus.typus.ToLower());
      Console.WriteLine($"\n{Primor.homo.Nomen} {Primor.homo.Cognomen} you are a wild beast of the proud werewolf race who has taken on the world since you were born; show what your natural statuses can do:");
      Primor.homo.Index();
    }
    public void Cisterna(){
      Σ.rector = Console.ReadLine().ToLower();

      if(Σ.rector=="roll"){
        Console.WriteLine("\nAs a werewolf you have 50 base health and adds to it 1d6 for each CON point.");
        Primor.homo.PV[0]=50;
        for (int i=0; i <= Primor.homo.Conditio; i++){
          Primor.homo.PV[0] += Mechanicae.Volvere(6);
          Console.ReadLine();
        }
        Console.WriteLine("\nAs a werewolf you have 540 base mana and adds to it 1d12 for each INT point.");
        Primor.homo.PM[0]=540;
        for (int i=0; i <= Primor.homo.Intelligentia; i++){
          Primor.homo.PM[0] += Mechanicae.Volvere(20);
          Console.ReadLine();
        }
      } else{
        Primor.homo.PV[0] = Mechanicae.Volvere(6, Primor.homo.Conditio)+50;
        Primor.homo.PM[0] = Mechanicae.Volvere(12, Primor.homo.Intelligentia)+540;
      }
      Primor.homo.PV[1]=Primor.homo.PV[0];
      Primor.homo.PM[1]=Primor.homo.PM[0];
      Console.WriteLine("\nPV: "+Primor.homo.PV[0]);
      Console.WriteLine("MP: "+Primor.homo.PM[0]);
      Console.ReadLine();
      Primor.homo.Genus.Mensura(Primor.homo.Genus.typus.ToLower());
    }
    public void Mensura(){
      Σ.rector=Console.ReadLine().ToLower();

      if(Σ.rector=="roll"){
        Primor.homo.Altitudo = 150 + Mechanicae.Volvere(10,10);
        Primor.homo.Latitudo = Math.Round((Primor.homo.Altitudo / 100) * (20 + Mechanicae.Volvere(10)), 2);
        Primor.homo.Crassitudo[1] = 4 + Mechanicae.Volvere(4);
      	Primor.homo.Crassitudo[0] = Math.Round((Primor.homo.Altitudo / 100) * Primor.homo.Crassitudo[1], 2);
        Primor.homo.Carnatio = Math.Round(Primor.homo.Altitudo * Primor.homo.Latitudo * Primor.homo.Crassitudo[0], 2);
        Primor.homo.Pondus = Math.Round((Primor.homo.Carnatio * 0.6) / 1000, 2);
        Primor.homo.Spatium[0] = Math.Round(Primor.homo.Altitudo / 2);
        Primor.homo.Spatium[1] = Math.Round(Primor.homo.Altitudo / 2);
        Primor.homo.Planitia[0]= Math.Round(Primor.homo.Altitudo * Primor.homo.Latitudo, 2);
        Primor.homo.Planitia[1]= Math.Round(Primor.homo.Altitudo * Primor.homo.Crassitudo[0], 2);
      } else{
        Primor.homo.Altitudo=195;
        Primor.homo.Latitudo=50;
        Primor.homo.Crassitudo[1]=6;
				Primor.homo.Crassitudo[0]=12;
        Primor.homo.Carnatio=195*50*12;
        Primor.homo.Pondus=70;
        Primor.homo.Spatium[0]=97;
        Primor.homo.Spatium[1]=97;
        Primor.homo.Planitia[0]=9750;
        Primor.homo.Planitia[1]=2340;
      }
			Primor.homo.Index("dimensions");
      Console.ReadLine();
    }
    public void NovaMensura(int cel=3){
			if(cel>=3){
				Primor.homo.Crassitudo[1] = 4 + Mechanicae.Volvere(4);
			} else if(cel==2){
				Primor.homo.Crassitudo[1] = Math.Round((4 + Mechanicae.Volvere(4))*1.2);
			} else if(cel==1){
				Primor.homo.Crassitudo[1] = Math.Round((4 + Mechanicae.Volvere(4))*1.5);
			}
      Primor.homo.Crassitudo[0] = Math.Round((Primor.homo.Altitudo / 100) * Primor.homo.Crassitudo[1], 2);
      Primor.homo.Carnatio = Math.Round(Primor.homo.Altitudo * Primor.homo.Latitudo * Primor.homo.Crassitudo[0], 2);
      Primor.homo.Pondus = Math.Round((Primor.homo.Carnatio * 0.6) / 1000, 2);
      Primor.homo.Planitia[0]= Math.Round(Primor.homo.Altitudo * Primor.homo.Latitudo, 2);
      Primor.homo.Planitia[1]= Math.Round(Primor.homo.Altitudo * Primor.homo.Crassitudo[0], 2);
			Primor.homo.Index("dimensions");
      Console.ReadLine();
    }

    public void Auto(string hostis){
      
      Primor.Hostis[hostis].PV[0] = 100;
      Primor.Hostis[hostis].PM[0] = 600;
      Primor.Hostis[hostis].PV[1]=Primor.Hostis[hostis].PV[0];
      Primor.Hostis[hostis].PM[1]=Primor.Hostis[hostis].PM[0];

      Primor.Hostis[hostis].Vigor = 12;
      Primor.Hostis[hostis].Dexteritate = 13;
      Primor.Hostis[hostis].Conditio = 10;
      Primor.Hostis[hostis].Intelligentia = 10;
      Primor.Hostis[hostis].Sapientia = 10;
      Primor.Hostis[hostis].Virtus();

      Primor.Hostis[hostis].Altitudo=195;
      Primor.Hostis[hostis].Latitudo=50;
      Primor.Hostis[hostis].Crassitudo[1]=6;
      Primor.Hostis[hostis].Crassitudo[0]=12;
      Primor.Hostis[hostis].Carnatio=195*50*12;
      Primor.Hostis[hostis].Pondus=70;
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