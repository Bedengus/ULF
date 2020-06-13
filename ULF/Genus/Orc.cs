using System;

namespace ULF
{
  public class Orc : Genus
  {
    public void Apto(){
      Console.WriteLine("\nDo you wish to 'increase' Strength by 2 points or 'reroll' it?");
      Σ.rector=Console.ReadLine().ToLower();

      if (Σ.rector=="reroll"){
          Console.WriteLine("\nYour current status is: "+Primor.homo.Vigor);
          Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
          Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="balanced"){
              Primor.homo.Vigor = Mechanicae.Volvere(4)+10;
          } else{
              Primor.homo.Vigor = Mechanicae.Volvere(20);
          }
      } else if(Σ.rector=="increase"){
          Primor.homo.Vigor+=2;
      } else{
          Console.WriteLine("\nYou skip your only natural advantage? Sadly that advantage is not Intellice...");
      }

      Console.WriteLine("\nChoose to 'increase' Constitution by 4 points at the price of minus 2 Wisdom and Intelligence OR 'reroll' Constitution for a Lower-Reroll at Wisdom and Intelligence.");
      Σ.rector=Console.ReadLine().ToLower();

      if (Σ.rector=="reroll"){
          Console.WriteLine("\nYour current CON is: "+Primor.homo.Conditio);
          Console.WriteLine("Your current INT is: "+Primor.homo.Intelligentia);
          Console.WriteLine("Your current WIS is: "+Primor.homo.Sapientia);
          Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
          Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="balanced"){
              Primor.homo.Conditio = Mechanicae.Volvere(4)+10;
              Σ.unus = Mechanicae.Volvere(4)+10;
              if(Σ.unus < Primor.homo.Intelligentia){
                  Primor.homo.Intelligentia = Σ.unus;
              }
              Σ.unus = Mechanicae.Volvere(4)+10;
              if(Σ.unus < Primor.homo.Sapientia){
                  Primor.homo.Sapientia = Σ.unus;
              }
          } else{
              Primor.homo.Conditio = Mechanicae.Volvere(20);
              Σ.unus = Mechanicae.Volvere(20);
              if(Σ.unus < Primor.homo.Intelligentia){
                  Primor.homo.Intelligentia = Σ.unus;
              }
              Σ.unus = Mechanicae.Volvere(20);
              if(Σ.unus < Primor.homo.Sapientia){
                  Primor.homo.Sapientia = Σ.unus;
              }
          }
      } else{
          Primor.homo.Conditio+=4;
          Primor.homo.Intelligentia-=2;
          Primor.homo.Sapientia-=2;
      }
      Primor.homo.Genus.Cisterna(Primor.homo.Genus.typus.ToLower());
      Console.WriteLine($"\n{Primor.homo.Nomen} {Primor.homo.Cognomen} you are a wild orc and the world has no positive expectations for you; and that reflect your puny statuses:");
      Primor.homo.Index();
    }
    public void Cisterna(){
      Σ.rector = Console.ReadLine().ToLower();

      if(Σ.rector=="roll"){
        Console.WriteLine("\nAs an orc you have 50 base health and adds to it 1d6 for each CON point.");
        Primor.homo.PV[0]=50;
        for (int i=0; i <= Primor.homo.Conditio; i++){
          Primor.homo.PV[0] += Mechanicae.Volvere(6);
          Console.ReadLine();
        }
        Console.WriteLine("\nAs an orc you have 490 base mana and adds to it 2d8 for each INT point.");
        Primor.homo.PM[0]=490;
        for (int i=0; i <= Primor.homo.Intelligentia*2; i++){
          Primor.homo.PM[0] += Mechanicae.Volvere(8);
          Console.ReadLine();
        }
      } else{
        Primor.homo.PV[0] = Mechanicae.Volvere(6, Primor.homo.Conditio)+50;
				Primor.homo.PM[0] = Mechanicae.Volvere(8, Primor.homo.Intelligentia*2)+490;
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
        Primor.homo.Latitudo = Math.Round((Primor.homo.Altitudo / 100) * (25 + Mechanicae.Volvere(10)), 2);
        Primor.homo.Crassitudo[1] = 5 + Mechanicae.Volvere(6);
      	Primor.homo.Crassitudo[0] = Math.Round((Primor.homo.Altitudo / 100) * Primor.homo.Crassitudo[1], 2);
        Primor.homo.Carnatio = Math.Round(Primor.homo.Altitudo * Primor.homo.Latitudo * Primor.homo.Crassitudo[0], 2);
        Primor.homo.Pondus = Math.Round((Primor.homo.Carnatio * 0.6) / 1000, 2);
        Primor.homo.Spatium[0] = Math.Round(Primor.homo.Altitudo / 2);
        Primor.homo.Spatium[1] = Math.Round(Primor.homo.Altitudo / 2);
        Primor.homo.Planitia[0]= Math.Round(Primor.homo.Altitudo * Primor.homo.Latitudo, 2);
        Primor.homo.Planitia[1]= Math.Round(Primor.homo.Altitudo * Primor.homo.Crassitudo[0], 2);
      } else{
        Primor.homo.Altitudo=195;
        Primor.homo.Latitudo=60;
        Primor.homo.Crassitudo[1]=7;
				Primor.homo.Crassitudo[0]=14;
        Primor.homo.Carnatio=195*60*14;
        Primor.homo.Pondus=98;
        Primor.homo.Spatium[0]=97;
        Primor.homo.Spatium[1]=97;
        Primor.homo.Planitia[0]=11700;
        Primor.homo.Planitia[1]=2730;
      }
			Primor.homo.Index("dimensions");
      Console.ReadLine();
    }
    public void NovaMensura(int cel=3){
			if(cel>=3){
				Primor.homo.Crassitudo[1] = 5 + Mechanicae.Volvere(6);
			} else if(cel==2){
				Primor.homo.Crassitudo[1] = Math.Round((5 + Mechanicae.Volvere(6))*1.2);
			} else if(cel==1){
				Primor.homo.Crassitudo[1] = Math.Round((5 + Mechanicae.Volvere(6))*1.5);
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
      Primor.Hostis[hostis].Dexteritate = 10;
      Primor.Hostis[hostis].Conditio = 14;
      Primor.Hostis[hostis].Intelligentia = 8;
      Primor.Hostis[hostis].Sapientia = 8;
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