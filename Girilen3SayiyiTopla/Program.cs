using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Girilen3SayiyiTopla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            İslem islem= new İslem();
            int toplam =islem.toplama(sayi2:10,sayi3:50,sayi1:40);
            Console.WriteLine(toplam);
        }
    }
    public class İslem
    {
        public int toplama (int sayi1, int sayi2,int sayi3)
        {
            return (sayi1+sayi2+sayi3);
        }
    }
}
