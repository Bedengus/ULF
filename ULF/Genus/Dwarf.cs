using System;

namespace ULF
{
  public class Dwarf : Genus
  {
    public void Apto(){
      Console.WriteLine("\nDo you wish to Choose-Reroll either STR or INT or to increase one by 3 points?");
      Console.WriteLine("Type 'reroll' or 'increase'");
      Σ.rector=Console.ReadLine().ToLower();

      if (Σ.rector=="reroll"){
          Console.WriteLine("\nYour current STR is: "+Primor.homo.Vigor);
          Console.WriteLine("Your current INT is: "+Primor.homo.Intelligentia);
          Console.WriteLine("Choose either 'int' or 'str'.");
          Σ.rector=Console.ReadLine().ToLower();
          
          if(Σ.rector=="int"){
              Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
              Σ.rector=Console.ReadLine().ToLower();
              if(Σ.rector=="balanced"){
                  Σ.unus = Mechanicae.Volvere(4)+10;
                  Console.WriteLine("\nThe balanced roll results in: "+Σ.unus);
                  Console.WriteLine("\nDo you wish to keep the 'old' roll or the 'new' roll?");
                  Σ.rector=Console.ReadLine().ToLower();
                  if(Σ.rector=="new"){
                      Primor.homo.Intelligentia = Σ.unus;
                  } else{
                      Console.WriteLine("\nYou keep your old status.");
                  }
              } else{
                  Σ.unus = Mechanicae.Volvere(20);
                  Console.WriteLine("\nDo you wish to keep the 'old' roll or the 'new' roll?");
                  Σ.rector=Console.ReadLine().ToLower();
                  if(Σ.rector=="new"){
                      Primor.homo.Intelligentia = Σ.unus;
                  } else{
                      Console.WriteLine("\nYou keep your old status.");
                  }
              }
          } else if(Σ.rector=="str"){
              Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
              Σ.rector=Console.ReadLine().ToLower();
              if(Σ.rector=="balanced"){
                  Σ.unus = Mechanicae.Volvere(4)+10;
                  Console.WriteLine("\nThe balanced roll results in: "+Σ.unus);
                  Console.WriteLine("\nDo you wish to keep the 'old' roll or the 'new' roll?");
                  Σ.rector=Console.ReadLine().ToLower();
                  if(Σ.rector=="new"){
                      Primor.homo.Vigor = Σ.unus;
                  } else{
                      Console.WriteLine("\nYou keep your old status.");
                  }
              } else{
                  Σ.unus = Mechanicae.Volvere(20);
                  Console.WriteLine("\nDo you wish to keep the 'old' roll or the 'new' roll?");
                  Σ.rector=Console.ReadLine().ToLower();
                  if(Σ.rector=="new"){
                      Primor.homo.Vigor = Σ.unus;
                  } else{
                      Console.WriteLine("\nYou keep your old status.");
                  }
              }
          } else{
              Primor.homo.Vigor = Mechanicae.Volvere(20);
          }
      } else if(Σ.rector=="increase"){
        Console.WriteLine("\nYour current STR is: "+Primor.homo.Vigor);
        Console.WriteLine("Your current INT is: "+Primor.homo.Intelligentia);
        Console.WriteLine("Choose either 'int' or 'str'.");
        Σ.rector=Console.ReadLine().ToLower();

        if(Σ.rector=="int"){
          Primor.homo.Intelligentia+=3;
        } else{
          Primor.homo.Vigor+=3;
        }
      } else{
          Primor.homo.Vigor+=3;
      }

      Console.WriteLine("\nDo you wish to 'increase' Constitution by 3 points or 'reroll' it?");
      Σ.rector=Console.ReadLine().ToLower();
      if(Σ.rector=="reroll"){
          Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
          Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="balanced"){
              Primor.homo.Conditio = Mechanicae.Volvere(4)+10;
          } else{
              Primor.homo.Conditio = Mechanicae.Volvere(20);
          }
      } else{
          Primor.homo.Conditio+=3;
      }
      Primor.homo.Genus.Cisterna(Primor.homo.Genus.typus.ToLower());
      Console.WriteLine($"\n{Primor.homo.Nomen} {Primor.homo.Cognomen} you are a broad barril-like dwarf; seek out the wide world and see how puny your statuses gained by restless mining are:");
      Primor.homo.Index();
    }
    public void Cisterna(){
      Σ.rector = Console.ReadLine().ToLower();

      if(Σ.rector=="roll"){
        Console.WriteLine("\nAs a dwarf you have 60 base health and adds to it 1d8 for each CON point.");
        Primor.homo.PV[0]=60;
        for (int i=0; i <= Primor.homo.Conditio; i++){
          Primor.homo.PV[0] += Mechanicae.Volvere(8);
          Console.ReadLine();
        }
        Console.WriteLine("\nAs a dwarf you have 590 base mana and adds to it 1d20 for each INT point.");
        Primor.homo.PM[0]=590;
        for (int i=0; i <= Primor.homo.Intelligentia; i++){
          Primor.homo.PM[0] += Mechanicae.Volvere(20);
          Console.ReadLine();
        }
      } else{
        Primor.homo.PV[0] = Mechanicae.Volvere(8, Primor.homo.Conditio)+60;
        Primor.homo.PM[0] = Mechanicae.Volvere(20, Primor.homo.Intelligentia)+590;
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
        Primor.homo.Altitudo = 50 + Mechanicae.Volvere(10,7);
        Primor.homo.Latitudo = 40 + Mechanicae.Volvere(10,2);
        Primor.homo.Crassitudo[1] = 35 + Mechanicae.Volvere(10);
      	Primor.homo.Crassitudo[0] = Math.Round((Primor.homo.Latitudo / 100) * Primor.homo.Crassitudo[1], 2);
        Primor.homo.Carnatio = Math.Round(Primor.homo.Altitudo * Primor.homo.Latitudo * Primor.homo.Crassitudo[0], 2);
        Primor.homo.Pondus = Math.Round((Primor.homo.Carnatio * 0.8) / 1000, 2);
        Primor.homo.Spatium[0] = Math.Round(Primor.homo.Altitudo / 2);
        Primor.homo.Spatium[1] = Math.Round(Primor.homo.Altitudo / 2);
        Primor.homo.Planitia[0]= Math.Round(Primor.homo.Altitudo * Primor.homo.Latitudo, 2);
        Primor.homo.Planitia[1]= Math.Round(Primor.homo.Altitudo * Primor.homo.Crassitudo[0], 2);
      } else{
        Primor.homo.Altitudo=80;
        Primor.homo.Latitudo=50;
        Primor.homo.Crassitudo[1]=40;
	    	Primor.homo.Crassitudo[0]=20;
        Primor.homo.Carnatio=80*50*20;
        Primor.homo.Pondus=64;
        Primor.homo.Spatium[0]=40;
        Primor.homo.Spatium[1]=40;
        Primor.homo.Planitia[0]=4000;
        Primor.homo.Planitia[1]=1600;
      }
			Primor.homo.Index("dimensions");
      Console.ReadLine();
    }
    public void NovaMensura(int cel=3){
			if(cel>=3){
				Primor.homo.Crassitudo[1] = 35 + Mechanicae.Volvere(10);
			} else if(cel==2){
				Primor.homo.Crassitudo[1] = Math.Round((35 + Mechanicae.Volvere(10))*1.2);
			} else if(cel==1){
				Primor.homo.Crassitudo[1] = Math.Round((35 + Mechanicae.Volvere(10))*1.5);
			}
      Primor.homo.Crassitudo[0] = Math.Round((Primor.homo.Latitudo / 100) * Primor.homo.Crassitudo[1], 2);
      Primor.homo.Carnatio = Math.Round(Primor.homo.Altitudo * Primor.homo.Latitudo * Primor.homo.Crassitudo[0], 2);
      Primor.homo.Pondus = Math.Round((Primor.homo.Carnatio * 0.8) / 1000, 2);
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

      Primor.Hostis[hostis].Vigor = 13;
      Primor.Hostis[hostis].Dexteritate = 10;
      Primor.Hostis[hostis].Conditio = 13;
      Primor.Hostis[hostis].Intelligentia = 10;
      Primor.Hostis[hostis].Sapientia = 10;
      Primor.Hostis[hostis].Virtus();

      Primor.Hostis[hostis].Altitudo=80;
      Primor.Hostis[hostis].Latitudo=50;
      Primor.Hostis[hostis].Crassitudo[1]=40;
      Primor.Hostis[hostis].Crassitudo[0]=20;
      Primor.Hostis[hostis].Carnatio=80*50*20;
      Primor.Hostis[hostis].Pondus=64;
      Primor.Hostis[hostis].Spatium[0]=40;
      Primor.Hostis[hostis].Spatium[1]=40;
      Primor.Hostis[hostis].Planitia[0]=4000;
      Primor.Hostis[hostis].Planitia[1]=1600;
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