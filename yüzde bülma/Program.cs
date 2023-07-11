using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yüzde_bülma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("yüzdesi bulnacak sayı");
            string girensayı = Console.ReadLine();
            int sayı=Convert.ToInt32(girensayı);





            Console.WriteLine("yüzde  kac");
            string girenyüzde = Console.ReadLine();
            int yüzde = Convert.ToInt32(girenyüzde);

            int sonuc = (sayı * yüzde) / 100;
            Console.WriteLine(sayı + " " +"sayısının" +" " +"yüzde" + " "+  girenyüzde+"ü" + " "+sonuc   );

            Console.ReadLine();

        }
    }
}
