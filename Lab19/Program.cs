using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Comp> comps = new List<Comp>()
            {
                new Comp() { Code = 010, Name = "Asus", Type = "Core i3", Rate = 1800, V = 512, Memory = 1, Videomemory = 256, Cost = 1200.35, Quantity = 123 },
                new Comp() { Code = 020, Name = "Acer", Type = "Core i5", Rate = 3600, V = 1024, Memory = 2, Videomemory = 512, Cost = 2200.5, Quantity = 23 },
                new Comp() { Code = 030, Name = "Honor", Type = "Core i3", Rate = 900, V = 512, Memory = 1, Videomemory = 256, Cost = 1000.3, Quantity = 180 },
                new Comp() { Code = 040, Name = "Intel", Type = "Core i7", Rate = 6200, V = 1536, Memory = 2, Videomemory = 2048, Cost = 3200.35, Quantity = 13 },
                new Comp() { Code = 050, Name = "Acer", Type = "Core i5", Rate = 3600, V = 1024, Memory = 2, Videomemory = 1024, Cost = 2500.88, Quantity = 100 },
                new Comp() { Code = 060, Name = "Dell", Type = "Core i3", Rate = 1800, V = 512, Memory = 1, Videomemory = 256, Cost = 900.35, Quantity = 87 },
            };
            //Console.WriteLine("Введите тип процессора");
            //string type = Console.ReadLine();
            //List<Comp> comps1 = comps.Where(x => x.Type == type).ToList();
            //Print(comps1);
            //Console.ReadKey();  
            //Console.WriteLine("Введите V-объем памяти ОЗУ");
            //int v = Convert.ToInt32(Console.ReadLine());
            //List<Comp> comps2 = comps.Where(x => x.V>=v).ToList();
            //Print(comps2);
            //Console.ReadKey();

            //List<Comp> comps3 = comps.OrderBy(x=>x.Cost).ToList() ;
            //Print(comps3);
            //Console.ReadKey();
            //IEnumerable<IGrouping<string, Comp>> comps4 = comps.GroupBy(x => x.Type);
            //foreach (IGrouping<string,Comp> gr in comps4)
            //{
            //    Console.WriteLine(gr.Key);
            //    foreach (Comp c in gr)
            //    {
            //        Console.WriteLine($"{c.Code} {c.Name} {c.Type} {c.Rate} {c.V} {c.Memory} {c.Videomemory} {c.Cost} {c.Quantity}");

            //    }
            //    Console.ReadKey();
            //Comp comps5 = comps.OrderByDescending(x => x.Cost).FirstOrDefault();
            //Console.WriteLine($"{comps5.Code} {comps5.Name} {comps5.Type} {comps5.Rate} {comps5.V} {comps5.Memory} {comps5.Videomemory} {comps5.Cost} {comps5.Quantity} ");
            //Console.ReadKey();  
            //Comp comps6 = comps.OrderBy(x => x.Cost).FirstOrDefault();
            //Console.WriteLine($"{comps6.Code} {comps6.Name} {comps6.Type}  {comps6.V} {comps6.Memory} {comps6.Videomemory} {comps6.Cost} ");
            //Console.ReadKey();
            Console.WriteLine(comps.Any(x => x.Quantity > 30));
            Console.ReadKey();  

        }
        static void Print(List<Comp> comps)
        {
            foreach (Comp c in comps)
            {

                Console.WriteLine($"{c.Code} {c.Name} {c.Type} {c.Rate} {c.V} {c.Memory} {c.Videomemory} {c.Cost} {c.Quantity}");
            }

            Console.WriteLine();

        }
    }
}
