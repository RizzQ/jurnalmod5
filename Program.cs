using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class PemrosesData
    {
        public T DapatkanNilaiTerbesar<T> (T nilai1, T nilai2, T nilai3)
        {
        dynamic a = (dynamic)nilai1;
        dynamic b = (dynamic)nilai2;
        dynamic c = (dynamic)nilai3;
        if (a > b && a > c) {
            return a;
        }
        else if(b > a && b > c) { return b; }
        else
        {
            return c;
        }
        

    }

    class Program
    {
        public static void Main()
        {
            PemrosesData data = new PemrosesData();

            Console.WriteLine(data.DapatkanNilaiTerbesar<int>(10, 30, 22));

        }
    }
}
