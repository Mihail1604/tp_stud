using System;
using System.IO;
using System.Collections.Generic;
using System.Numerics;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Serialization
{
    public class Arenda
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }

        public Arenda() { }
        public Arenda(int id, string marka, string model,int price)
        {
            Id = id;
            Marka = marka;
            Model = model;
            Price = price;
            
        }



        public class Klient
        {
            public int Klientid { get; set; }

            public string FIO { get; set; }
            public int Age { get; set; }
            public Klient() { }
            public Klient(int klientid, string fio, int age)
            {
                Klientid = klientid;
                FIO = fio;
                Age = age;
            }

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
            List<Arenda> partsList = new List<Arenda>();

            JsonHandler<Arenda> partsHandler = new JsonHandler<Arenda>("PartsFile.json");

            partsList.Add(new Arenda(1, "Lada", "2115", "10000" ,new Klient(256, "Krivosheev Mihail", "19")));
            partsList.Add(new Arenda(2, "BMW", "M5 F90", "35000" ,new Klient(222, "Khrisanov Arseny", "19")));
            partsList.Add(new Arenda(3, "Mercedes", "c63 amg", "40000" , new Klient(128, "Zinkov Daniil", "22")));


            partsHandler.Rewrite(partsList);
            partsHandler.OutputJsonContents();
        }
    }
}
