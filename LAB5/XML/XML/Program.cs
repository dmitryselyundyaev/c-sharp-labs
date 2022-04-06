using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace XML
{
    public class Program
    {
        public struct Cinema
        {
            public string Name;
            public string Producer;
            public DateTime Date;
            public string Country;
            public double Price;
            public double Income;
            public double Profit;

            public Cinema(string name,string producer,DateTime date,string country,double price,double income,double profit)
            {
                Name = name;
                Producer = producer;
                Date = date;
                Country = country;
                Price = price;
                Income = income;    
                Profit = profit;
            }
        }
        static void Main(string[] args)
        {
            Cinema first = new Cinema("В пути", "Цибров П.П.", DateTime.Now, "Россия", 200222, 11100, 23210);
            Cinema second = new Cinema("Вагон метро", "Астафьев А.К.", DateTime.Now, "Сербия", 3100, 23100, 66400);
            Cinema third = new Cinema("Выстер", "Щербакаов А.О.", DateTime.Now, "Украина", 8213200, 821120, 44400);

            List<Cinema> myList = new List<Cinema>() { first,second,third};
            // создаем XmlSerializer
            XmlSerializer formatter = new XmlSerializer(typeof(List<Cinema>));

            // создаем поток (xml файл)
            using (FileStream fs = new FileStream("d://1.xml", FileMode.OpenOrCreate))
            {
                // сериализация (сохранение объекта в поток)
                formatter.Serialize(fs, myList);
            }

        }
    }
}
