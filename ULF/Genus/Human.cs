using System;

namespace ULF
{
  public class Human : Genus 
  {
    public void Apto(){
      Console.WriteLine("\nDo you wish to Choose-Reroll two statuses or increase +10 (to a maximum of 15) to a single one?");
      Console.WriteLine("Type 'reroll' or 'increase'");
      Σ.rector=Console.ReadLine().ToLower();

      if(Σ.rector=="reroll"){
          for(int i=0; i < 2; i++){
              Console.WriteLine("\nChoose a status to reroll.");
              Σ.notou=Console.ReadLine().ToLower();

              switch(Σ.notou){
                  case "str":
                      Console.WriteLine("\nYour current status is: "+Primor.homo.Vigor);
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
                      Console.WriteLine("\nYour current status is: "+Primor.homo.Dexteritate);
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
                      Console.WriteLine("\nYour current status is: "+Primor.homo.Conditio);
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
                      Console.WriteLine("\nYour current status is: "+Primor.homo.Intelligentia);
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
                      Console.WriteLine("\nYour current status is: "+Primor.homo.Sapientia);
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
                              Primor.homo.Vigor=Σ.unus;
                              break;
                          case "dex":
                              Primor.homo.Dexteritate=Σ.unus;
                              break;
                          case "con":
                              Primor.homo.Conditio=Σ.unus;
                              break;
                          case "int":
                              Primor.homo.Intelligentia=Σ.unus;
                              break;
                          case "wis":
                              Primor.homo.Sapientia=Σ.unus;
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
          Primor.homo.Index();
          Σ.rector=Console.ReadLine().ToLower();

          switch(Σ.rector){
                  case "str":
                      if ((Primor.homo.Vigor+10) > 15){
                          Primor.homo.Vigor = 15;
                      } else{
                          Primor.homo.Vigor += 10;
                      }
                      break;
                  case "dex":
                      if ((Primor.homo.Dexteritate+10) > 15){
                          Primor.homo.Dexteritate = 15;
                      } else{
                          Primor.homo.Dexteritate += 10;
                      }
                      break;
                  case "con":
                      if ((Primor.homo.Conditio+10) > 15){
                          Primor.homo.Conditio = 15;
                      } else{
                          Primor.homo.Conditio += 10;
                      }
                      break;
                  case "int":
                      if ((Primor.homo.Intelligentia+10) > 15){
                          Primor.homo.Intelligentia = 15;
                      } else{
                          Primor.homo.Intelligentia += 10;
                      }
                      break;
                  case "wis":
                      if ((Primor.homo.Sapientia+10) > 15){
                          Primor.homo.Sapientia = 15;
                      } else{
                          Primor.homo.Sapientia += 10;
                      }
                      break;
                  default:
                      Console.WriteLine("\nSad day.");
                      break;
          } 
      } else{
        Console.WriteLine("\nVery human like, such haste and disregard. You may never recover this opportunity of youth.");
      }
			Primor.homo.Genus.Cisterna(Primor.homo.Genus.typus.ToLower());
      Console.WriteLine($"\n{Primor.homo.Nomen} {Primor.homo.Cognomen} you are a determined human; and with your puny statuses you will make something out of yourself:");
      Primor.homo.Index();
    }
    public void Cisterna(){
      Σ.rector = Console.ReadLine().ToLower();

      if(Σ.rector=="roll"){
        Console.WriteLine("\nAs a human you have 40 base health and adds to it 1d4 for each CON point.");
      Primor.homo.PV[0]=40;
      for (int i=0; i <= Primor.homo.Conditio; i++){
        Primor.homo.PV[0] += Mechanicae.Volvere(4);
        Console.ReadLine();
      }
      Console.WriteLine("\nAs a human you have 540 base mana and adds to it 1d20 for each INT point.");
      Primor.homo.PM[0]=540;
      for (int i=0; i <= Primor.homo.Intelligentia; i++){
        Primor.homo.PM[0] += Mechanicae.Volvere(20);
        Console.ReadLine();
      }
      } else{
        Primor.homo.PV[0] = Mechanicae.Volvere(4, Primor.homo.Conditio)+40;
        Primor.homo.PM[0] = Mechanicae.Volvere(20, Primor.homo.Intelligentia)+540;
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
        Primor.homo.Altitudo = 120 + Mechanicae.Volvere(10,10);
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
        Primor.homo.Altitudo=170;
        Primor.homo.Latitudo=50;
        Primor.homo.Crassitudo[1]=7;
				Primor.homo.Crassitudo[0]=12;
        Primor.homo.Carnatio=170*50*12;
        Primor.homo.Pondus=61;
        Primor.homo.Spatium[0]=85;
        Primor.homo.Spatium[1]=85;
        Primor.homo.Planitia[0]=8500;
        Primor.homo.Planitia[1]=2040;
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

      Primor.Hostis[hostis].Vigor = 11;
      Primor.Hostis[hostis].Dexteritate = 11;
      Primor.Hostis[hostis].Conditio = 11;
      Primor.Hostis[hostis].Intelligentia = 11;
      Primor.Hostis[hostis].Sapientia = 11;
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