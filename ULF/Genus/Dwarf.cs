using System;

namespace ULF
{
  public static class Dwarf
  {
    public static void Apto(Persona Ego){
      Console.WriteLine("\nDo you wish to Choose-Reroll either STR or INT or to increase one by 3 points?");
      Console.WriteLine("Type 'reroll' or 'increase'");
      Σ.rector=Console.ReadLine().ToLower();

      if (Σ.rector=="reroll"){
          Console.WriteLine("\nYour current STR is: "+Ego.Vigor[0]);
          Console.WriteLine("Your current INT is: "+Ego.Intelligentia[0]);
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
                      Ego.Intelligentia[0] = Σ.unus;
                  } else{
                      Console.WriteLine("\nYou keep your old status.");
                  }
              } else{
                  Σ.unus = Mechanicae.Volvere(20);
                  Console.WriteLine("\nDo you wish to keep the 'old' roll or the 'new' roll?");
                  Σ.rector=Console.ReadLine().ToLower();
                  if(Σ.rector=="new"){
                      Ego.Intelligentia[0] = Σ.unus;
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
                      Ego.Vigor[0] = Σ.unus;
                  } else{
                      Console.WriteLine("\nYou keep your old status.");
                  }
              } else{
                  Σ.unus = Mechanicae.Volvere(20);
                  Console.WriteLine("\nDo you wish to keep the 'old' roll or the 'new' roll?");
                  Σ.rector=Console.ReadLine().ToLower();
                  if(Σ.rector=="new"){
                      Ego.Vigor[0] = Σ.unus;
                  } else{
                      Console.WriteLine("\nYou keep your old status.");
                  }
              }
          } else{
              Ego.Vigor[0] = Mechanicae.Volvere(20);
          }
      } else if(Σ.rector=="increase"){
        Console.WriteLine("\nYour current STR is: "+Ego.Vigor[0]);
        Console.WriteLine("Your current INT is: "+Ego.Intelligentia[0]);
        Console.WriteLine("Choose either 'int' or 'str'.");
        Σ.rector=Console.ReadLine().ToLower();

        if(Σ.rector=="int"){
          Ego.Intelligentia[0]+=3;
        } else{
          Ego.Vigor[0]+=3;
        }
      } else{
          Ego.Vigor[0]+=3;
      }

      Console.WriteLine("\nDo you wish to 'increase' Constitution by 3 points or 'reroll' it?");
      Σ.rector=Console.ReadLine().ToLower();
      if(Σ.rector=="reroll"){
          Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
          Σ.rector=Console.ReadLine().ToLower();
          if(Σ.rector=="balanced"){
              Ego.Conditio[0] = Mechanicae.Volvere(4)+10;
          } else{
              Ego.Conditio[0] = Mechanicae.Volvere(20);
          }
      } else{
          Ego.Conditio[0]+=3;
      }
      Console.WriteLine($"\n{Ego.Nomen} {Ego.Cognomen} you are a broad barril-like dwarf; seek out the wide world and see how puny your statuses gained by restless mining are:");
      Ego.Index();
    }
    public static void Cisterna(Persona Ego){
      Σ.rector = Console.ReadLine().ToLower();

      if(Σ.rector=="roll"){
        Console.WriteLine("\nAs a dwarf you have 60 base health and adds to it 1d8 for each CON point.");
        Ego.PV[0]=60;
        for (int i=0; i <= Ego.Conditio[0]; i++){
          Ego.PV[0] += Mechanicae.Volvere(8);
          Console.ReadLine();
        }
        Console.WriteLine("\nAs a dwarf you have 590 base mana and adds to it 1d20 for each INT point.");
        Ego.PM[0]=590;
        for (int i=0; i <= Ego.Intelligentia[0]; i++){
          Ego.PM[0] += Mechanicae.Volvere(20);
          Console.ReadLine();
        }
      } else{
        Ego.PV[0] = Mechanicae.Volvere(8, Ego.Conditio[0])+60;
        Ego.PM[0] = Mechanicae.Volvere(20, Ego.Intelligentia[0])+590;
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
        Ego.Altitudo = 50 + Mechanicae.Volvere(10,7);
        Ego.Latitudo = 40 + Mechanicae.Volvere(10,2);
        Ego.Crassitudo[1] = 35 + Mechanicae.Volvere(10);
      	Ego.Crassitudo[0] = Math.Round((Ego.Latitudo / 100) * Ego.Crassitudo[1], 2);
        Ego.Carnatio = Math.Round(Ego.Altitudo * Ego.Latitudo * Ego.Crassitudo[0], 2);
        Ego.Pondus[0] = Math.Round((Ego.Carnatio * 0.8) / 1000, 2);
        Ego.Spatium[0] = Math.Round(Ego.Altitudo / 2);
        Ego.Spatium[1] = Math.Round(Ego.Altitudo / 2);
        Ego.Planitia[0]= Math.Round(Ego.Altitudo * Ego.Latitudo, 2);
        Ego.Planitia[1]= Math.Round(Ego.Altitudo * Ego.Crassitudo[0], 2);
      } else{
        Ego.Altitudo=80;
        Ego.Latitudo=50;
        Ego.Crassitudo[1]=40;
	    	Ego.Crassitudo[0]=20;
        Ego.Carnatio=80*50*20;
        Ego.Pondus[0]=64;
        Ego.Spatium[0]=40;
        Ego.Spatium[1]=40;
        Ego.Planitia[0]=4000;
        Ego.Planitia[1]=1600;
      }
			Ego.Index("dimensions");
      Console.ReadLine();
    }
    public static void NovaMensura(Persona Ego, int cel=3){
			if(cel>=3){
				Ego.Crassitudo[1] = 35 + Mechanicae.Volvere(10);
			} else if(cel==2){
				Ego.Crassitudo[1] = Math.Round((35 + Mechanicae.Volvere(10))*1.2);
			} else if(cel==1){
				Ego.Crassitudo[1] = Math.Round((35 + Mechanicae.Volvere(10))*1.5);
			}
      Ego.Crassitudo[0] = Math.Round((Ego.Latitudo / 100) * Ego.Crassitudo[1], 2);
      Ego.Carnatio = Math.Round(Ego.Altitudo * Ego.Latitudo * Ego.Crassitudo[0], 2);
      Ego.Pondus[0] = Math.Round((Ego.Carnatio * 0.8) / 1000, 2);
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

      Primor.Hostis[hostis].Vigor[0] = 13;
      Primor.Hostis[hostis].Dexteritate[0] = 10;
      Primor.Hostis[hostis].Conditio[0] = 13;
      Primor.Hostis[hostis].Intelligentia[0] = 10;
      Primor.Hostis[hostis].Sapientia[0] = 10;
      Primor.Hostis[hostis].Virtus();

      Primor.Hostis[hostis].Altitudo=80;
      Primor.Hostis[hostis].Latitudo=50;
      Primor.Hostis[hostis].Crassitudo[1]=40;
      Primor.Hostis[hostis].Crassitudo[0]=20;
      Primor.Hostis[hostis].Carnatio=80*50*20;
      Primor.Hostis[hostis].Pondus[0]=64;
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