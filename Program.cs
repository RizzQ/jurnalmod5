using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }
    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine($"Data {i+1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: 3/10/2022 5:32:01 AM ");
        }
    }
}
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

    }

    class Program
    {
        public static void Main()
        {
        SimpleDataBase<int> newData = new SimpleDataBase<int>();
        newData.addNewData(12);
        newData.addNewData(34);
        newData.addNewData(56);
        newData.PrintAllData();

    }
    }
            PemrosesData data = new PemrosesData();

            Console.WriteLine(data.DapatkanNilaiTerbesar<int>(10, 30, 22));

        }
    }

