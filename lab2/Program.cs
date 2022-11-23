using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Serialization
{
    public class Rent
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public Rent() { }
        public Rent(int id, string brand, string model, int price)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Price = price;

        }
    }

        public class Client
        {
            public int Id { get; set; }
            public string FIO { get; set; }
            public int Age { get; set; }
            public Client() { }
            public Client(int id, string fio, int age)
            {
                Id = id;
                FIO = fio;
                Age = age;
            }

        }
    
    public class JsonHandler<T> where T : class
    {
        private string NameFile;
        JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

        public JsonHandler() { }

        public JsonHandler(string NameFile)
        {
            this.NameFile = NameFile;
        }

        public void SetFileName(string NameFile)
        {
            this.NameFile = NameFile;
        }

        public void Write(List<T> list)
        {
            string jsonString = JsonSerializer.Serialize(list, options);

            if (new FileInfo(NameFile).Length == 0)
            {
                File.WriteAllText(NameFile, jsonString);
            }
            else
            {
                Console.WriteLine("Указанный путь к файлу не пустой");
            }
        }

        public void Delete()
        {
            File.WriteAllText(NameFile, string.Empty);
        }

        public void Rewrite(List<T> list)
        {
            string jsonString = JsonSerializer.Serialize(list, options);

            File.WriteAllText(NameFile, jsonString);
        }

        public void Read(ref List<T> list)
        {
            if (File.Exists(NameFile))
            {
                if (new FileInfo(NameFile).Length != 0)
                {
                    string jsonString = File.ReadAllText(NameFile);
                    list = JsonSerializer.Deserialize<List<T>>(jsonString);
                }
                else
                {
                    Console.WriteLine("Указанный путь к файлу не пустой");
                }
            }
        }

        public void OutputJsonContents()
        {
            string jsonString = File.ReadAllText(NameFile);

            Console.WriteLine(jsonString);
        }

        public void OutputSerializedList(List<T> list)
        {
            Console.WriteLine(JsonSerializer.Serialize(list, options));
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<Rent> partsList = new List<Rent>();

            JsonHandler<Rent> partsHandler = new JsonHandler<Rent>("PartsFile.json");

            partsList.Add(new Rent(1, "Lada", "Granta", "10000" ,new Client(256, "Krivosheev Mihail", "19")));
            partsList.Add(new Rent(2, "BMW", "M5 F90", "35000" ,new Client(222, "Khrisanov Arseny", "19")));
            partsList.Add(new Rent(3, "Mercedes", "c63 amg", "40000" , new Client(128, "Zinkov Daniil", "22")));


            partsHandler.Rewrite(partsList);
            partsHandler.OutputJsonContents();
        }
    }
}
