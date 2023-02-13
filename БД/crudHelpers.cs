using Praktica;

namespace Practica
{
    internal static class CrudHelpers
    {
        public static void Main(string[] args)
        {

            using (ApplicationContext db = new ApplicationContext())
            {
                Sotrudnik test = new Sotrudnik { Id = 10, Fio = "Кривошеев", Age = 19 };
                db.Sotrudniks.Add(test);
                db.SaveChanges();
                var Sotrudniks = db.Sotrudniks.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Sotrudnik u in Sotrudniks)
                {
                    Console.WriteLine(u.Fio + " - " + u.Age);
                }
            }


            using (ApplicationContext db = new ApplicationContext())
            {
                Sotrudnik? upduser = (from Sotrudnik in db.Sotrudniks where Sotrudnik.Id == 10 select Sotrudnik).First();
                if (upduser != null)
                {
                    upduser.Age = upduser.Age * 2;
                    db.SaveChanges();
                }
                var users = db.Sotrudniks.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Sotrudnik u in users)
                {
                    Console.WriteLine(u.Fio + " - " + u.Age);
                }

            }


            using (ApplicationContext db = new ApplicationContext())
            {
                Sotrudnik? deluser = (from Sotrudnik in db.Sotrudniks where Sotrudnik.Id == 10 select Sotrudnik).First();
                if (deluser != null)
                {
                    db.Sotrudniks.Remove(deluser);
                    db.SaveChanges();
                }
                var Sotrudniks = db.Sotrudniks.ToArray();
                Console.WriteLine("Список объектов");
                foreach (Sotrudnik u in Sotrudniks)
                {
                    Console.WriteLine(u.Fio + " - " + u.Age);
                }

            }

        }
    }
}