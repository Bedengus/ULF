using System;

namespace ULF
{
  public static class Human
  {
    public static void Apto(Persona Ego){
      Console.WriteLine("\nDo you wish to Choose-Reroll two statuses or increase +10 (to a maximum of 15) to a single one?");
      Console.WriteLine("Type 'reroll' or 'increase'");
      Σ.rector=Console.ReadLine().ToLower();

      if(Σ.rector=="reroll"){
          for(int i=0; i < 2; i++){
              Console.WriteLine("\nChoose a status to reroll.");
              Σ.notou=Console.ReadLine().ToLower();

              switch(Σ.notou){
                  case "str":
                      Console.WriteLine("\nYour current status is: "+Ego.Vigor[0]);
                      Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
                      Σ.rector=Console.ReadLine().ToLower();
                      if(Σ.rector=="balanced"){
                          Σ.unus = Mechanicae.Volvere(4)+10;
                          Console.WriteLine("\nThe balanced roll results in: "+Σ.unus);
                      } else{
                          Σ.unus = Mechanicae.Volvere(20);
                      }
                      break;
                  case "dex":
                      Console.WriteLine("\nYour current status is: "+Ego.Dexteritate[0]);
                      Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
                      Σ.rector=Console.ReadLine().ToLower();
                      if(Σ.rector=="balanced"){
                          Σ.unus = Mechanicae.Volvere(4)+10;
                          Console.WriteLine("\nThe balanced roll results in: "+Σ.unus);
                      } else{
                          Σ.unus = Mechanicae.Volvere(20);
                      }
                      break;
                  case "con":
                      Console.WriteLine("\nYour current status is: "+Ego.Conditio[0]);
                      Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
                      Σ.rector=Console.ReadLine().ToLower();
                      if(Σ.rector=="balanced"){
                          Σ.unus = Mechanicae.Volvere(4)+10;
                          Console.WriteLine("\nThe balanced roll results in: "+Σ.unus);
                      } else{
                          Σ.unus = Mechanicae.Volvere(20);
                      }
                      break;
                  case "int":
                      Console.WriteLine("\nYour current status is: "+Ego.Intelligentia[0]);
                      Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
                      Σ.rector=Console.ReadLine().ToLower();
                      if(Σ.rector=="balanced"){
                          Σ.unus = Mechanicae.Volvere(4)+10;
                          Console.WriteLine("\nThe balanced roll results in: "+Σ.unus);
                      } else{
                          Σ.unus = Mechanicae.Volvere(20);
                      }
                      break;
                  case "wis":
                      Console.WriteLine("\nYour current status is: "+Ego.Sapientia[0]);
                      Console.WriteLine("Do you wish for 'balanced' or 'wild'?");
                      Σ.rector=Console.ReadLine().ToLower();
                      if(Σ.rector=="balanced"){
                          Σ.unus = Mechanicae.Volvere(4)+10;
                          Console.WriteLine("\nThe balanced roll results in: "+Σ.unus);
                      } else{
                          Σ.unus = Mechanicae.Volvere(20);
                      }
                      break;
                  default:
                      Console.WriteLine("\nYou throw the reroll away... Mad humans...");
                      Σ.notou="los";
                      break;      
              }
              if(Σ.notou != "los"){
                  Console.WriteLine("\nDo you wish to keep the 'old' roll or the 'new' roll?");
                  Σ.rector=Console.ReadLine().ToLower();
                  if(Σ.rector=="new"){
                      switch(Σ.notou){
                          case "str":
                              Ego.Vigor[0]=Σ.unus;
                              break;
                          case "dex":
                              Ego.Dexteritate[0]=Σ.unus;
                              break;
                          case "con":
                              Ego.Conditio[0]=Σ.unus;
                              break;
                          case "int":
                              Ego.Intelligentia[0]=Σ.unus;
                              break;
                          case "wis":
                              Ego.Sapientia[0]=Σ.unus;
                              break;
                          default:
                              Console.WriteLine("\nYou throw the reroll away... Mad humans...");
                              break;
                      }
                  } else{
                      Console.WriteLine("\nYou keep your old status.");
                  }
              }
          }
      } else if(Σ.rector=="increase"){
          Console.WriteLine("\nChoose a status to increase; any point over 15 will be lost.");
          Ego.Index();
          Σ.rector=Console.ReadLine().ToLower();

          switch(Σ.rector){
                  case "str":
                      if ((Ego.Vigor[0]+10) > 15){
                          Ego.Vigor[0] = 15;
                      } else{
                          Ego.Vigor[0] += 10;
                      }
                      break;
                  case "dex":
                      if ((Ego.Dexteritate[0]+10) > 15){
                          Ego.Dexteritate[0] = 15;
                      } else{
                          Ego.Dexteritate[0] += 10;
                      }
                      break;
                  case "con":
                      if ((Ego.Conditio[0]+10) > 15){
                          Ego.Conditio[0] = 15;
                      } else{
                          Ego.Conditio[0] += 10;
                      }
                      break;
                  case "int":
                      if ((Ego.Intelligentia[0]+10) > 15){
                          Ego.Intelligentia[0] = 15;
                      } else{
                          Ego.Intelligentia[0] += 10;
                      }
                      break;
                  case "wis":
                      if ((Ego.Sapientia[0]+10) > 15){
                          Ego.Sapientia[0] = 15;
                      } else{
                          Ego.Sapientia[0] += 10;
                      }
                      break;
                  default:
                      Console.WriteLine("\nSad day.");
                      break;
          } 
      } else{
        Console.WriteLine("\nVery human like, such haste and disregard. You may never recover this opportunity of youth.");
      }
      Console.WriteLine($"\n{Ego.Nomen} {Ego.Cognomen} you are a determined human; and with your puny statuses you will make something out of yourself:");
      Ego.Index();
    }
    public static void Cisterna(Persona Ego){
      Σ.rector = Console.ReadLine().ToLower();

      if(Σ.rector=="roll"){
        Console.WriteLine("\nAs a human you have 40 base health and adds to it 1d4 for each CON point.");
      Ego.PV[0]=40;
      for (int i=0; i <= Ego.Conditio[0]; i++){
        Ego.PV[0] += Mechanicae.Volvere(4);
        Console.ReadLine();
      }
      Console.WriteLine("\nAs a human you have 540 base mana and adds to it 1d20 for each INT point.");
      Ego.PM[0]=540;
      for (int i=0; i <= Ego.Intelligentia[0]; i++){
        Ego.PM[0] += Mechanicae.Volvere(20);
        Console.ReadLine();
      }
      } else{
        Ego.PV[0] = Mechanicae.Volvere(4, Ego.Conditio[0])+40;
        Ego.PM[0] = Mechanicae.Volvere(20, Ego.Intelligentia[0])+540;
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
        Ego.Altitudo = 120 + Mechanicae.Volvere(10,10);
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
        Ego.Altitudo=170;
        Ego.Latitudo=50;
        Ego.Crassitudo[1]=7;
				Ego.Crassitudo[0]=12;
        Ego.Carnatio=170*50*12;
        Ego.Pondus=61;
        Ego.Spatium[0]=85;
        Ego.Spatium[1]=85;
        Ego.Planitia[0]=8500;
        Ego.Planitia[1]=2040;
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

      Primor.Hostis[hostis].Vigor[0] = 11;
      Primor.Hostis[hostis].Dexteritate[0] = 11;
      Primor.Hostis[hostis].Conditio[0] = 11;
      Primor.Hostis[hostis].Intelligentia[0] = 11;
      Primor.Hostis[hostis].Sapientia[0] = 11;
      Primor.Hostis[hostis].Virtus();

      Primor.Hostis[hostis].Altitudo=170;
      Primor.Hostis[hostis].Latitudo=50;
      Primor.Hostis[hostis].Crassitudo[1]=7;
      Primor.Hostis[hostis].Crassitudo[0]=12;
      Primor.Hostis[hostis].Carnatio=170*50*12;
      Primor.Hostis[hostis].Pondus=61;
      Primor.Hostis[hostis].Spatium[0]=85;
      Primor.Hostis[hostis].Spatium[1]=85;
      Primor.Hostis[hostis].Planitia[0]=8500;
      Primor.Hostis[hostis].Planitia[1]=2040;
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