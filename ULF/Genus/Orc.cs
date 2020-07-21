using System;

namespace ULF
{
  public static class Orc
  {
    public static void Apto(Persona Ego){
      Console.WriteLine("\nDo you wish to 'increase' Strength by 2 points or 'reroll' it?");
      Σ.rector=Console.ReadLine().ToLower();

      if (Σ.rector=="reroll"){
          Console.WriteLine("\nYour current status is: "+Ego.Vigor[0]);
          Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
          Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="balanced"){
              Ego.Vigor[0] = Mechanicae.Volvere(4)+10;
          } else{
              Ego.Vigor[0] = Mechanicae.Volvere(20);
          }
      } else if(Σ.rector=="increase"){
          Ego.Vigor[0]+=2;
      } else{
          Console.WriteLine("\nYou skip your only natural advantage? Sadly that advantage is not Intellice...");
      }

      Console.WriteLine("\nChoose to 'increase' Constitution by 4 points at the price of minus 2 Wisdom and Intelligence OR 'reroll' Constitution for a Lower-Reroll at Wisdom and Intelligence.");
      Σ.rector=Console.ReadLine().ToLower();

      if (Σ.rector=="reroll"){
          Console.WriteLine("\nYour current CON is: "+Ego.Conditio[0]);
          Console.WriteLine("Your current INT is: "+Ego.Intelligentia[0]);
          Console.WriteLine("Your current WIS is: "+Ego.Sapientia[0]);
          Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
          Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="balanced"){
              Ego.Conditio[0] = Mechanicae.Volvere(4)+10;
              Σ.unus = Mechanicae.Volvere(4)+10;
              if(Σ.unus < Ego.Intelligentia[0]){
                  Ego.Intelligentia[0] = Σ.unus;
              }
              Σ.unus = Mechanicae.Volvere(4)+10;
              if(Σ.unus < Ego.Sapientia[0]){
                  Ego.Sapientia[0] = Σ.unus;
              }
          } else{
              Ego.Conditio[0] = Mechanicae.Volvere(20);
              Σ.unus = Mechanicae.Volvere(20);
              if(Σ.unus < Ego.Intelligentia[0]){
                  Ego.Intelligentia[0] = Σ.unus;
              }
              Σ.unus = Mechanicae.Volvere(20);
              if(Σ.unus < Ego.Sapientia[0]){
                  Ego.Sapientia[0] = Σ.unus;
              }
          }
      } else{
          Ego.Conditio[0]+=4;
          Ego.Intelligentia[0]-=2;
          Ego.Sapientia[0]-=2;
      }

      Console.WriteLine($"\n{Ego.Nomen} {Ego.Cognomen} you are a wild orc and the world has no positive expectations for you; and that reflect your puny statuses:");
      Ego.Index();
    }
    public static void Cisterna(Persona Ego){
      Σ.rector = Console.ReadLine().ToLower();

      if(Σ.rector=="roll"){
        Console.WriteLine("\nAs an orc you have 50 base health and adds to it 1d6 for each CON point.");
        Ego.PV[0]=50;
        for (int i=0; i <= Ego.Conditio[0]; i++){
          Ego.PV[0] += Mechanicae.Volvere(6);
          Console.ReadLine();
        }
        Console.WriteLine("\nAs an orc you have 490 base mana and adds to it 2d8 for each INT point.");
        Ego.PM[0]=490;
        for (int i=0; i <= Ego.Intelligentia[0]*2; i++){
          Ego.PM[0] += Mechanicae.Volvere(8);
          Console.ReadLine();
        }
      } else{
        Ego.PV[0] = Mechanicae.Volvere(6, Ego.Conditio[0])+50;
				Ego.PM[0] = Mechanicae.Volvere(8, Ego.Intelligentia[0]*2)+490;
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
        Ego.Latitudo = Math.Round((Ego.Altitudo / 100) * (25 + Mechanicae.Volvere(10)), 2);
        Ego.Crassitudo[1] = 5 + Mechanicae.Volvere(6);
      	Ego.Crassitudo[0] = Math.Round((Ego.Altitudo / 100) * Ego.Crassitudo[1], 2);
        Ego.Carnatio = Math.Round(Ego.Altitudo * Ego.Latitudo * Ego.Crassitudo[0], 2);
        Ego.Pondus = Math.Round((Ego.Carnatio * 0.6) / 1000, 2);
        Ego.Spatium[0] = Math.Round(Ego.Altitudo / 2);
        Ego.Spatium[1] = Math.Round(Ego.Altitudo / 2);
        Ego.Planitia[0]= Math.Round(Ego.Altitudo * Ego.Latitudo, 2);
        Ego.Planitia[1]= Math.Round(Ego.Altitudo * Ego.Crassitudo[0], 2);
      } else{
        Ego.Altitudo=195;
        Ego.Latitudo=60;
        Ego.Crassitudo[1]=7;
				Ego.Crassitudo[0]=14;
        Ego.Carnatio=195*60*14;
        Ego.Pondus=98;
        Ego.Spatium[0]=97;
        Ego.Spatium[1]=97;
        Ego.Planitia[0]=11700;
        Ego.Planitia[1]=2730;
      }
			Ego.Index("dimensions");
      Console.ReadLine();
    }
    public static void NovaMensura(Persona Ego, int cel=3){
			if(cel>=3){
				Ego.Crassitudo[1] = 5 + Mechanicae.Volvere(6);
			} else if(cel==2){
				Ego.Crassitudo[1] = Math.Round((5 + Mechanicae.Volvere(6))*1.2);
			} else if(cel==1){
				Ego.Crassitudo[1] = Math.Round((5 + Mechanicae.Volvere(6))*1.5);
			}
      Ego.Crassitudo[0] = Math.Round((Ego.Altitudo / 100) * Ego.Crassitudo[1], 2);
      Ego.Carnatio = Math.Round(Ego.Altitudo * Ego.Latitudo * Ego.Crassitudo[0], 2);
      Ego.Pondus = Math.Round((Ego.Carnatio * 0.6) / 1000, 2);
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
      Primor.Hostis[hostis].Dexteritate[0] = 10;
      Primor.Hostis[hostis].Conditio[0] = 14;
      Primor.Hostis[hostis].Intelligentia[0] = 8;
      Primor.Hostis[hostis].Sapientia[0] = 8;
      Primor.Hostis[hostis].Virtus();

      Primor.Hostis[hostis].Altitudo=195;
      Primor.Hostis[hostis].Latitudo=60;
      Primor.Hostis[hostis].Crassitudo[1]=7;
      Primor.Hostis[hostis].Crassitudo[0]=14;
      Primor.Hostis[hostis].Carnatio=195*60*14;
      Primor.Hostis[hostis].Pondus=98;
      Primor.Hostis[hostis].Spatium[0]=97;
      Primor.Hostis[hostis].Spatium[1]=97;
      Primor.Hostis[hostis].Planitia[0]=11700;
      Primor.Hostis[hostis].Planitia[1]=2730;
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