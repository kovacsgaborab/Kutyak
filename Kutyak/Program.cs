using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kutyak
{
    class Program
    {
        static List<KutyaNev> kutyaNevek = new List<KutyaNev>();
        static List<KutyaFajta> kutyaFajtak = new List<KutyaFajta>();
        static List<Kutya> kutyaLista = new List<Kutya>();

        static void KutyaNevekBeolvasas()
        {
            StreamReader be = new StreamReader("KutyaNevek.csv");

            be.ReadLine();

            while (!be.EndOfStream)
            {
                string[] adat = be.ReadLine().Split(';');

                kutyaNevek.Add(new KutyaNev(
                  Convert.ToInt32(adat[0]),
                  adat[1]
                ));
            }

            be.Close();
        }

        static void KutyaFajtaBeolvasas()
        {
            StreamReader sr = new StreamReader("KutyaFajtak.csv");

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] a = sr.ReadLine().Split(';');
                kutyaFajtak.Add(new KutyaFajta(int.Parse(a[0]), a[1], a[2]));
            }

            sr.Close();
        }

        static void KutyaBeolvasas()
        {
            StreamReader sr = new StreamReader("Kutyak.csv");

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string[] a = sr.ReadLine().Split(';');
                kutyaLista.Add(new Kutya(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), int.Parse(a[3]), a[4]));
            }
        }

        static void Harmadik()
        {
            Console.WriteLine("3. feladat: Kutyanevek száma: {0}", kutyaNevek.Count);
        }

        static void Negyedik()
        {
            
        }

        static void Main(string[] args)
        {
            KutyaNevekBeolvasas();
            KutyaFajtaBeolvasas();
            KutyaBeolvasas();

            Console.WriteLine(kutyaLista.Count);

            Harmadik();


            Console.ReadLine();
        }
    }
}
