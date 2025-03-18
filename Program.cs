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
