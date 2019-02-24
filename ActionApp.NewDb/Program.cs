using System;

namespace ActionApp.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ActionContext())
            {
                Console.WriteLine("enter your movie title");
                string title = Console.ReadLine();
                Console.WriteLine("enter your movie year");
                string year = Console.ReadLine();
                Console.WriteLine("enter your movie category");
                string category = Console.ReadLine();
                db.Actions.Add(new Actiontbl { title = title });
                db.Actions.Add(new Actiontbl { year = "year" });
                db.Actions.Add(new Actiontbl { category_name = "category" });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All blogs in database:");
                foreach (var Actiontbl in db.Actions)
                {
                    Console.WriteLine(" - {0} {1} {2}", Actiontbl.title, Actiontbl.year, Actiontbl.category_name);
                }
            }
        }
    }
}