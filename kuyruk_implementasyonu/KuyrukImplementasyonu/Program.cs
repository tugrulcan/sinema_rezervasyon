using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueImplementation;
using System.IO;

namespace KuyrukImplementasyonu
{
    class Program
    {
        public static StringBuilder sb = new StringBuilder();

        static void Main(string[] args)
        {
            yazdir("Dairesel kuyruk modeli işletiliyor.\n");

            var sw = new Stopwatch();

            CircularArrayTypedQueue cq = new CircularArrayTypedQueue(20);
            PriorityArrayTypedQueue pq_asc = new PriorityArrayTypedQueue(20, "asc");
            PriorityArrayTypedQueue pq_desc = new PriorityArrayTypedQueue(20, "desc");


            Random rnd = new Random();
            for (int i = 0; i < 20; i++)
            {
                int sure = rnd.Next(60, 600);
                cq.Insert(sure);
                pq_asc.Insert(sure);
                pq_desc.Insert(sure);
            }

            sw.Start();
            
            for (int i = 0; i < 20; i++)
            {
                var s = (int)cq.Remove();
                System.Threading.Thread.Sleep(s);
                yazdir(i + 1 + ". eleman " + s + " sn sonra dairesel kuyruktan çıktı.\n");
            }

            sw.Stop();

            yazdir("Dairesel kuyruk tamamlandı! Tamamlanma süresi: " + sw.ElapsedMilliseconds + "\n");            
            yazdir("Öncelikli (artan) kuyruk modeli işletiliyor.\n");

            sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 20; i++)
            {
                var s = (int)pq_asc.Remove();
                System.Threading.Thread.Sleep(s);
               yazdir( i + 1 + ". eleman " + s + " sn sonra (artan) öncelikli kuyruktan çıktı.\n");
            }
            sw.Stop();
            yazdir("(artan) Öncelikli kuyruktan çıkartma tamamlandı! Tamamlanma süresi: " + sw.ElapsedMilliseconds + "\n");

            yazdir("Öncelikli (azalan) kuyruk modeli işletiliyor.\n");

            sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 20; i++)
            {
                var s = (int)pq_desc.Remove();
                System.Threading.Thread.Sleep(s);
                yazdir(i + 1 + ". eleman " + s + " sn sonra Priority Queue (azalan) kuyruktan çıktı.\n");
            }
            sw.Stop();
            yazdir("(azalan) Öncelikli kuyruktan çıkartma tamamlandı! Tamamlanma süresi: " + sw.ElapsedMilliseconds + "\n");
            File.WriteAllText(@"../../kuyrukCiktisi.txt", sb.ToString());
            string path = (@"../../kuyrukCiktisi.txt").ToString();
            Console.WriteLine("Çıktılar " + path + " dizinine kaydedildi!!");
            Console.WriteLine("\nÇıkmak için bir enter'a basınız.");
            Console.ReadLine();

        }

        public static void yazdir(string s)
        {
            Console.Write(s);
            sb.Append(s);
        }
    }
}
