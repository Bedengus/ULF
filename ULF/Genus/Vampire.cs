using System;

namespace ULF
{
  public class Vampire : Genus
  {
    public void Apto(){
      int vis=0;
      int vel=0;
      Console.WriteLine("\nDo you wish to increase 4 points into 'wis' or 'con'?");
      Σ.rector=Console.ReadLine().ToLower();

      if(Σ.rector=="wis"){
          Primor.homo.Sapientia+=4;
          Console.WriteLine("\nYour Wisdom is: "+Primor.homo.Sapientia);
      } else if(Σ.rector=="con"){
          Primor.homo.Conditio+=4;
          Console.WriteLine("\nYour Constitution is: "+Primor.homo.Conditio);
      } else{
          Console.WriteLine("\nVery well; it goes to naught. Life strips you even of your natural racial advantages.");
      }

      for(int i=0; i < 4; i++)
      {   
          Console.WriteLine("\nChoose either 'str' or 'dex' to increase a point.");
          Σ.rector=Console.ReadLine().ToLower();

          if(Σ.rector=="str"){
              Primor.homo.Vigor++;
              Console.WriteLine("\nYour Strength is: "+Primor.homo.Vigor);
              vis++;
          } else if(Σ.rector=="dex"){
              Primor.homo.Dexteritate++;
              Console.WriteLine("\nYour Dexterity is: "+Primor.homo.Dexteritate);
              vel++;
          } else{
              Console.WriteLine("\nVery well; it goes to naught. Life strips you even of your natural racial advantages.");
          }

          if(vis==3 && vel==0){
              Primor.homo.Dexteritate++;
              i++;
              Console.WriteLine("\nYour Dexterity is: "+Primor.homo.Dexteritate);
          } else if(vel==3 && vis==0){
              Primor.homo.Vigor++;
              i++;
              Console.WriteLine("\nYour Strength is: "+Primor.homo.Vigor);
          }  
      }
      Primor.homo.Genus.Cisterna(Primor.homo.Genus.typus.ToLower());
      Console.WriteLine($"\n{Primor.homo.Nomen} {Primor.homo.Cognomen} you are a vampire and may you soar as an adventurer so that your puny statuses do not bring shame upon your galant race:");
      Primor.homo.Index();
    }
    public void Cisterna(){
      Σ.rector = Console.ReadLine().ToLower();

      if(Σ.rector=="roll"){
        Console.WriteLine("\nAs a vampire you have 40 base health and adds to it 1d8-1 for each CON point.");
        Primor.homo.PV[0]=40;
        for (int i=0; i <= Primor.homo.Conditio; i++){
          Primor.homo.PV[0] += Mechanicae.Volvere(8, mut: -1);
          Console.ReadLine();
        }
        Console.WriteLine("\nAs a vampire you have 640 base mana and adds to it 2d8 for each INT point.");
        Primor.homo.PM[0]=640;
        for (int i=0; i <= Primor.homo.Intelligentia*2; i++){
          Primor.homo.PM[0] += Mechanicae.Volvere(8);
          Console.ReadLine();
        }
      } else{
        Primor.homo.PV[0] = Mechanicae.Volvere(8, Primor.homo.Conditio, -1)+40;
        Primor.homo.PM[0] = Mechanicae.Volvere(8, Primor.homo.Intelligentia*2)+640;
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
        Primor.homo.Altitudo = 130 + Mechanicae.Volvere(10,10);
        Primor.homo.Latitudo = Math.Round((Primor.homo.Altitudo / 100) * (20 + Mechanicae.Volvere(10)), 2);
        Primor.homo.Crassitudo[1] = 4 + Mechanicae.Volvere(4);
      	Primor.homo.Crassitudo[0] = Math.Round((Primor.homo.Altitudo / 100) * Primor.homo.Crassitudo[1], 2);
        Primor.homo.Carnatio = Math.Round(Primor.homo.Altitudo * Primor.homo.Latitudo * Primor.homo.Crassitudo[0], 2);
        Primor.homo.Pondus = Math.Round((Primor.homo.Carnatio * 0.7) / 1000, 2);
        Primor.homo.Spatium[0] = Math.Round(Primor.homo.Altitudo / 2);
        Primor.homo.Spatium[1] = Math.Round(Primor.homo.Altitudo / 2);
        Primor.homo.Planitia[0]= Math.Round(Primor.homo.Altitudo * Primor.homo.Latitudo, 2);
        Primor.homo.Planitia[1]= Math.Round(Primor.homo.Altitudo * Primor.homo.Crassitudo[0], 2);
      } else{
        Primor.homo.Altitudo=180;
        Primor.homo.Latitudo=45;
        Primor.homo.Crassitudo[1]=6;
				Primor.homo.Crassitudo[0]=10;
        Primor.homo.Carnatio=180*45*10;
        Primor.homo.Pondus=56;
        Primor.homo.Spatium[0]=90;
        Primor.homo.Spatium[1]=90;
        Primor.homo.Planitia[0]=8100;
        Primor.homo.Planitia[1]=1840;
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
      Primor.homo.Pondus = Math.Round((Primor.homo.Carnatio * 0.7) / 1000, 2);
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
      Primor.Hostis[hostis].Dexteritate = 13;
      Primor.Hostis[hostis].Conditio = 10;
      Primor.Hostis[hostis].Intelligentia = 10;
      Primor.Hostis[hostis].Sapientia = 14;
      Primor.Hostis[hostis].Virtus();

      Primor.Hostis[hostis].Altitudo=180;
      Primor.Hostis[hostis].Latitudo=45;
      Primor.Hostis[hostis].Crassitudo[1]=6;
      Primor.Hostis[hostis].Crassitudo[0]=10;
      Primor.Hostis[hostis].Carnatio=180*45*10;
      Primor.Hostis[hostis].Pondus=56;
      Primor.Hostis[hostis].Spatium[0]=90;
      Primor.Hostis[hostis].Spatium[1]=90;
      Primor.Hostis[hostis].Planitia[0]=8100;
      Primor.Hostis[hostis].Planitia[1]=1840;
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