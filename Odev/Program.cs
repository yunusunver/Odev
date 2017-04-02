using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{

    abstract class Sekiller {
        private char Sembol;
        private bool DoluMu;
        private DateTime OlusturmaTarihi;

        public Sekiller() {
            Sembol = '*';
        }
        public Sekiller(char sembol) { }
        public Sekiller(char sembol,bool doluMu) { }
        public void setSembol(char sembol) {
            Sembol = sembol;
        }
        public char getSembol() {
            return Sembol;
        }
        public void setDoluMu(bool doluMu) {
            DoluMu = doluMu;
        }
        public bool getDoluMu() {
            return DoluMu;
        }
        private void setOlusturmaTarihi(DateTime tarih) {
            OlusturmaTarihi = tarih;
        }
        public DateTime getOlusturmaTarihi() {
            return OlusturmaTarihi;
        }

        abstract public double AlanHesapla();
        abstract public double CevreHesapla();
        abstract public void Ciz();
        abstract public void OzellikYazdir();
    }

    class Dikdortgen : Sekiller {
        private double Yukseklik;
        private double Genislik;

        public Dikdortgen() {
            setSembol('*');
            setDoluMu(true);
            Yukseklik = 5;
            Genislik = 10;
        }
        public Dikdortgen(double yukseklik,double genislik) {
            setSembol('*');
            setDoluMu(true);
            Yukseklik = yukseklik;
            Genislik = genislik;
        }
        public void setYukseklik(double yukseklik) {
            Yukseklik = yukseklik;
        }
        public double getYukseklik() {
            return Yukseklik;
        }
        public void setGenislik(double genislik)
        {
            Genislik = genislik;
        }
        public double getGenislik()
        {
            return Genislik;
        }

        public override double AlanHesapla()
        {
            return Yukseklik * Genislik;
        }
        public override double CevreHesapla()
        {
            return 2 * (Yukseklik+Genislik);
        }
        public override void Ciz()
        {
            if (getDoluMu() == true)
            {
                for (int i = 0; i < getYukseklik(); i++)
                {
                    for (int j = 0; j < getGenislik(); j++)
                    {
                        Console.Write(getSembol());
                    }
                    Console.WriteLine();
                }
            }
            else {
                for (int i = 0; i < getYukseklik(); i++)
                {
                    for (int j = 0; j < getGenislik(); j++)
                    {
                        if (i == 0 || i == getYukseklik() - 1)
                        {
                            Console.Write(getSembol());
                        }
                        else if (j == 0 || j == getGenislik()-1)
                        {
                            Console.Write(getSembol());

                        }
                        else {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }

            }   
        }
        public override void OzellikYazdir()
        {
            Console.WriteLine("{0} tarihinde oluşturulan Dikdörtgen sınıfı --> Genislik={1} Yükseklik={2} Alan={3} Çevre={4} ", DateTime.Now, getGenislik(), getYukseklik(), AlanHesapla(), CevreHesapla());
        }
    }

    class Ucgen : Sekiller{
        private double Kenar;

        public Ucgen() {
            setSembol('*');
            setDoluMu(true);
            Kenar = 5;
        }
        public Ucgen(double kenar) {
            setSembol('*');
            setDoluMu(true);
            Kenar = kenar;
        }
        public void setKenar(double kenar) {
            Kenar = kenar;
        }
        public double getKenar() {
            return Kenar;
        }

        public override double AlanHesapla()
        {
            return Kenar*Kenar*Kenar;
        }
        public override double CevreHesapla()
        {
            return 3 * Kenar;
        }
        public override void Ciz()
        {
            if (getKenar()%2==0) {
                Console.WriteLine("Çizim yapılamıyor.");
            }
            else {
                if (getDoluMu() == true)
                {
                    for (int i = 0; i <= (int)(getKenar() / 2); i++)
                    {
                        for (int j = (int)(getKenar()/2 - i); j > 0; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < 2 * i + 1; k++)
                        {
                            Console.Write(getSembol());

                        }
                        Console.WriteLine();

                    }
                    
                }
                else {
                    for (int i = 0; i <= (int)(getKenar() / 2); i++)
                    {
                        for (int j = (int)(getKenar() / 2) - i; j > 0; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < 2 * i + 1; k++)
                        {

                            if (k == 0 || k == 2 * i)
                            {
                                Console.Write(getSembol());
                            }
                            else if ((int)(getKenar() / 2) == i)
                            {
                                Console.Write(getSembol());
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();

                    }

                }
            }

        }
        public override void OzellikYazdir()
        {
            
            Console.WriteLine("{0} tarihinde oluşturulan Üçgen sınıfı --> Kenar={1} Alan={2} Cevre={3}",DateTime.Now,getKenar(),AlanHesapla(),CevreHesapla());
        }

    }

    class EskenarDortgen : Dikdortgen {
        public EskenarDortgen() {
            setSembol('*');
            setDoluMu(true);
            setYukseklik(5);
            setGenislik(5);
        }
        public EskenarDortgen(bool yon) {
            setSembol('*');
            setDoluMu(yon);
            setYukseklik(5);
            setGenislik(5);
        }
        public EskenarDortgen(double yukseklik,double genislik) {
            setSembol('*');
            setDoluMu(true);
            setYukseklik(yukseklik);
            setGenislik(genislik);
        }
        public EskenarDortgen(bool yon,double yukseklik,double genislik) {
            setSembol('*');
            setDoluMu(yon);
            setYukseklik(yukseklik);
            setGenislik(genislik);
        }

        public override double AlanHesapla()
        {
            return getGenislik() + getYukseklik();
        }
        public override double CevreHesapla()
        {
            return 2 * getYukseklik() + 2 * getGenislik();

        }
        public override void Ciz()
        {
            if (getYukseklik() != getGenislik() || getGenislik() % 2 == 0 || getYukseklik() % 2 == 0)
            {
                Console.WriteLine("Cizim yapılamıyor");

            }
            else {
                if (getDoluMu() == true)
                {
                  
                }
                else {

                }

            }


        }
        public override void OzellikYazdir()
        {
            Console.WriteLine("{0} tarihinde oluşturulan Eşkenardörtgen sınıfı --> Genislik={1} Yükseklik={2} Alan={3} Çevre={4} ", DateTime.Now,getGenislik(),getYukseklik(), AlanHesapla(), CevreHesapla());
        }

    }
    
    class ParalelKenar : Dikdortgen
    {
        public bool Yon;

        public ParalelKenar() {
            Yon = true;
            setSembol('*');
            setDoluMu(true);
            setYukseklik(5);
            setGenislik(5);
        }
        public ParalelKenar(bool yon) {
            Yon = yon;
            setSembol('*');
            setDoluMu(true);
            setYukseklik(5);
            setGenislik(5);
        }
        public ParalelKenar(double yukseklik, double genislik) {
            Yon = true;
            setSembol('*');
            setDoluMu(true);
            setYukseklik(yukseklik);
            setGenislik(genislik);
        }
        public ParalelKenar(bool yon, double yukseklik, double genislik) {
            Yon = yon;
            setSembol('*');
            setDoluMu(true);
            setYukseklik(yukseklik);
            setGenislik(genislik);
        }
        public void setYon(bool yon) {
            Yon = yon;
        }
        public bool getYon() {
            return Yon;
        }
        public override double AlanHesapla()
        {
            return getGenislik()*getYukseklik();
        }
        public override double CevreHesapla()
        {
            return 2 * getYukseklik() + 2 * getGenislik();
        }
        public override void Ciz()
        {
           
            if (getDoluMu()==true) {
                if (Yon == true) {
                    for (int i = 0; i < getYukseklik(); i++)
                    {
                        for (int j=(int)getYukseklik()-i;j>0;j--) {
                            Console.Write(" ");
                        }
                        for (int k=0;k<getGenislik()-1;k++) {
                            Console.Write(getSembol());
                        }
                        Console.WriteLine();
                    }
                }
                else {
                    for (int i = 0; i < getYukseklik(); i++)
                    {
                        for (int j=1;j<getYukseklik()-i;j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < getGenislik(); k++)
                        {
                            Console.Write(getSembol());
                        }
                        Console.WriteLine();
                    }
                }

            }
            else {
                if (Yon == true)
                {
                    for (int i = 0; i < getYukseklik(); i++)
                    {
                        for (int j = (int)getYukseklik() - i; j > 0; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < getGenislik(); k++)
                        {
                            if (i == 0 || i == getYukseklik() - 1)
                            {
                                Console.Write(getSembol());
                            }
                            else if (k == 0 || k == getGenislik() - 1)
                            {
                                Console.Write(getSembol());
                            }
                            else {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    for (int i = 0; i < getYukseklik(); i++)
                    {
                        for (int j = 1; j < getYukseklik()+i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < getGenislik(); k++)
                        {
                            if (i == 0 || i == getYukseklik() - 1)
                            {
                                Console.Write(getSembol());
                            }
                            else if (k == 0 || k == getGenislik() - 1)
                            {
                                Console.Write(getSembol());
                            }
                            else
                            {
                                Console.Write(" ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
        public override void OzellikYazdir()
        {
            Console.WriteLine("{0} tarihinde oluşturulan ParalelKenar sınıfı --> Genislik={1} Yükseklik={2} Alan={3} Çevre={4} ", DateTime.Now, getGenislik(), getYukseklik(), AlanHesapla(), CevreHesapla());
        }
    }

    class Program
    {
        static void DikdortgenBilgileri(Dikdortgen a) {
            bool dongu = true;
            do
            {
                Console.WriteLine("1-)Alan Hesapla\n2-)Çevre Hesapla\n3-)Ciz\n4-)Genislik Degistir\n5-)Uzunluk Degistir\n6-)Karakter Degistir\n7-)Dolumu Degistir\n8-)Bilgileri Yazdır\n9-)Üst Menü\n10-)Cıkıs");
                int secim = Convert.ToInt32(Console.ReadLine());
                int sonuc;
                char karakter;
                bool dolum;
                switch (secim)
                {
                    case 1:
                        Console.WriteLine(a.AlanHesapla());
                        break;
                    case 2:
                        Console.WriteLine(a.CevreHesapla());
                        break;
                    case 3:
                        a.Ciz();
                        break;
                    case 4:
                        sonuc = Convert.ToInt32(Console.ReadLine()); a.setGenislik(sonuc);
                        break;
                    case 5:
                        sonuc = Convert.ToInt32(Console.ReadLine()); a.setYukseklik(sonuc);
                        break;
                    case 6:
                        karakter = Convert.ToChar(Console.ReadLine()); a.setSembol(karakter);
                        break;
                    case 7:
                        dolum = Convert.ToBoolean(Console.ReadLine()); a.setDoluMu(dolum);
                        break;
                    case 8:
                        a.OzellikYazdir();
                        break;
                    case 9: dongu = false; break;
                    case 10: Environment.Exit(0); break;

                }
            } while (dongu!=false);

        }


        static void DikdortgenBilgileri(EskenarDortgen c)
        {
            bool dongu=true;
            do
            {
                Console.WriteLine("1-)Alan Hesapla\n2-)Çevre Hesapla\n3-)Ciz\n4-)Genislik Degistir\n5-)Uzunluk Degistir\n6-)Karakter Degistir\n7-)Dolumu Degistir\n8-)Bilgileri Yazdır\n9-)Üst Menü\n10-)Cıkıs");
                int secim = Convert.ToInt32(Console.ReadLine());
                int sonuc;
                char karakter;
                bool dolum;
                switch (secim)
                {
                    case 1:
                        Console.WriteLine(c.AlanHesapla());
                        break;
                    case 2:
                        Console.WriteLine(c.CevreHesapla());
                        break;
                    case 3:
                        c.Ciz();
                        break;
                    case 4:
                        sonuc = Convert.ToInt32(Console.ReadLine()); c.setGenislik(sonuc);
                        break;
                    case 5:
                        sonuc = Convert.ToInt32(Console.ReadLine()); c.setYukseklik(sonuc);
                        break;
                    case 6:
                        karakter = Convert.ToChar(Console.ReadLine()); c.setSembol(karakter);
                        break;
                    case 7:
                        dolum = Convert.ToBoolean(Console.ReadLine()); c.setDoluMu(dolum);
                        break;
                    case 8:
                        c.OzellikYazdir();
                        break;
                    case 9: dongu = false; break;
                    case 10: Environment.Exit(0); break;

                }
            } while (dongu!=false);
        }

        static void DikdortgenBilgileri(ParalelKenar d)
        {
            bool dongu = true;
            do
            {
                Console.WriteLine("1-)Alan Hesapla\n2-)Çevre Hesapla\n3-)Ciz\n4-)Genislik Degistir\n5-)Uzunluk Degistir\n6-)Karakter Degistir\n7-)Dolumu Degistir\n8-)Bilgileri Yazdır\n9-)Üst Menü\n10-)Cıkıs");
                int secim = Convert.ToInt32(Console.ReadLine());
                int sonuc;
                char karakter;
                bool dolum;
                switch (secim)
                {
                    case 1:
                        Console.WriteLine(d.AlanHesapla());
                        break;
                    case 2:
                        Console.WriteLine(d.CevreHesapla());
                        break;
                    case 3:
                        d.Ciz();
                        break;
                    case 4:
                        sonuc = Convert.ToInt32(Console.ReadLine()); d.setGenislik(sonuc);
                        break;
                    case 5:
                        sonuc = Convert.ToInt32(Console.ReadLine()); d.setYukseklik(sonuc);
                        break;
                    case 6:
                        karakter = Convert.ToChar(Console.ReadLine()); d.setSembol(karakter);
                        break;
                    case 7:
                        dolum = Convert.ToBoolean(Console.ReadLine()); d.setDoluMu(dolum);
                        break;
                    case 8:
                        d.OzellikYazdir();
                        break;
                    case 9:dongu = false; break;
                    case 10: Environment.Exit(0); break;

                }
            } while (dongu!=false);
        }

        static void UcgenBilgileri(Ucgen b)
        {
            bool dongu = true;
            do
            {
                Console.WriteLine("1-)Alan Hesapla\n2-)Çevre Hesapla\n3-)Ciz\n4-)Kenar Degistir\n5-)Karakter Degistir\n6-)Dolumu Degistir\n7-)Bilgileri Yazdır\n8-)Üst Menü\n9-)Cıkıs");
                int secim = Convert.ToInt32(Console.ReadLine());
                int sonuc;
                char karakter;
                bool dolum;
                switch (secim)
                {
                    case 1:
                        Console.WriteLine(b.AlanHesapla());
                        break;
                    case 2:
                        Console.WriteLine(b.CevreHesapla());
                        break;
                    case 3:
                        b.Ciz();
                        break;
                    case 4:
                        sonuc = Convert.ToInt32(Console.ReadLine()); b.setKenar(sonuc);
                        break;
                    case 5:
                        karakter = Convert.ToChar(Console.ReadLine()); b.setSembol(karakter);
                        break;
                    case 6:
                        dolum = Convert.ToBoolean(Console.ReadLine()); b.setDoluMu(dolum);
                        break;
                    case 7:
                        b.OzellikYazdir();
                        break;
                    case 8: dongu = false;
                        break;
                    case 9: Environment.Exit(0); break;

                }
            } while (dongu!=false);
        }
        static void Main(string[] args)
        {
            Dikdortgen a=new Dikdortgen();
            Ucgen b = new Ucgen();
            EskenarDortgen c = new EskenarDortgen();
            ParalelKenar d = new ParalelKenar();
            int secim;
            bool dongu=true;
            int yukseklik, genislik, kenar;
            do
            {
            Console.WriteLine("Olusturulacak sekli seçiniz : ");
            Console.WriteLine("1-)Dikdörtgen\n2-)Üçgen\n3-)Eşkenar Dörtgen\n4-)ParalelKenar\n5-)Cıkıs\n Seçiminiz >>");
            secim = Convert.ToInt32(Console.ReadLine());
            
                switch (secim) {
                    case 1: Console.WriteLine("Dikdörtgenin genişliğini giriniz : "); genislik = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Dikdörtgenin yüksekliğini giriniz : "); yukseklik = Convert.ToInt32(Console.ReadLine());
                        a.setGenislik(genislik);
                        a.setYukseklik(yukseklik);
                        DikdortgenBilgileri(a);
                        break;
                    case 2: Console.WriteLine("Ucgenin kenar uzunlugunu giriniz : "); kenar = Convert.ToInt32(Console.ReadLine());
                        b.setKenar(kenar);
                        UcgenBilgileri(b);
                        break;
                    case 3: Console.WriteLine("Eskenardörtgenin genisligini giriniz :"); genislik = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Eskenardörtgenin yuksekligini giriniz :"); yukseklik = Convert.ToInt32(Console.ReadLine());
                        c.setGenislik(genislik);
                        c.setYukseklik(yukseklik);
                        DikdortgenBilgileri(c);
                        break;
                    case 4:
                        Console.WriteLine("Paralelkenar genisligini giriniz :"); genislik = Convert.ToInt32(Console.ReadLine()); Console.WriteLine("Paralelkenar yuksekligini giriniz :"); yukseklik = Convert.ToInt32(Console.ReadLine());
                        d.setGenislik(genislik);
                        d.setYukseklik(yukseklik);
                        DikdortgenBilgileri(d);
                        break;
                    case 5:dongu = false;Console.WriteLine("Byy :)");
                            break;
                }
            } while (dongu!=false);
            Console.ReadKey();
        }
    }
}
