using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ULF
{
  [Serializable] class Herctum
  {
    public string nomen;
    public string cognomen;
    public string Gtypus;
    public Dictionary<string, bool> ordo = new Dictionary<string, bool>();
		public int[] pv=new int[2];
		public double[] pm=new double[2];
    public double credits;
    public string[] repertoire=new string[20];
    public Dictionary<string, string> repertoireB = new Dictionary<string, string>();
    public string[] actus = new string[20];
    public Dictionary<string, int> metier = new Dictionary<string, int>();
    public Dictionary<string, int> peritia = new Dictionary<string, int>();

    public int[] Vigor = new int[2];
		public int[] Dexteritate = new int[2];
		public int[] Conditio = new int[2];
		public int[] Intelligentia = new int[2];
		public int[] Sapientia = new int[2];

		public double altitudo;
		public double latitudo;
		public double[] crassitudo=new double[2];
		public double pondus;
		public double[] spatium=new double[2];
		public double carnatio;
    public double[] planitia=new double[3];
    public double[] caput=new double[3];
    public double[] ocullus=new double[3];
    public double[] collum=new double[3];
    public double[] cor=new double[3];
    public double[] tergum=new double[3];
    public double[] bracchium=new double[3];
    public double[] stomachus=new double[3];
    public double[] crus=new double[3];
		
		public int capacitas;
		public int potentia;
		public double celeritas;
		public double accuratio;
		public double perceptio;

		public int agilitas;
		public int accuratioP;
		public int perceptioP;
    public double agiT;
		public double perT;
		public double casT;


		public int convertioMechanica;
		public int liguritio;
		public int fluentaAnima;
		public int corpusAptus;

    public string armaN;
    public Dictionary<string, int> panaN = new Dictionary<string, int>();
  }
  [Serializable] class HerctumA
  {
    public string Peritia;
    public int Acutus;
    public int Acutulus;
    public int Obtusus;
    public int DamnumT;
    public double Spatium;
    public double Toleratio;
    public int Deficio;
    public string Mat;
    public string Nomen;
    public string Typus;
    public double Pondus;
    public double Pretium;
  }
}