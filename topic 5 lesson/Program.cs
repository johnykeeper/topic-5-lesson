namespace topic_5_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // jonathan
            int people = 20;
            int cats = 30;
            int dog = 15;
            Console.WriteLine("people: " + people + " dogs:" + dog + " cats: " + cats);
            if (people < cats)
            {
                Console.WriteLine("too many cats!!!");
            }
            if (people > cats)
            {
                Console.WriteLine("not many cats");
            }
            if (people < dog)
            {
                Console.WriteLine("too many dogs");
            }
            if (people > dog)
            {
                Console.WriteLine("not many dogs");
            }
            Console.WriteLine("press Enter to continue");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
