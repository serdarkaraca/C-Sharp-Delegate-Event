using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Delegate_Event
{
    delegate void DelAlomelo(String aMesaj);
    class Program

         
    {
        static void Main(string[] args)
        {
            Muhittin m = new Muhittin();
            Cemal c = new Cemal(m);
            m.alomelo();
            Console.ReadLine();
        }

        class Muhittin
        {
            int Sayi;
            String Yazi;
            public event DelAlomelo MesajGonder;
            public void alomelo()
            {
                Console.WriteLine("birazdan eventi tetikleyecem");
                Thread.Sleep(2000);
                MesajGonder("mesaj");
            }
        }
        
        class Cemal
        {
            public Cemal(Muhittin m)
            {
                m.MesajGonder += MesajGeldi;
            }

            void MesajGeldi(String mesaj)
            {
                Console.WriteLine(mesaj);
            }
        }
    }



}
