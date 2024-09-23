namespace topic_5_lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // jonathan
            int people = 20;
            int cats = 30;
            int dogs = 15;
            Console.WriteLine("people: " + people + " dogs:" + dogs + " cats: " + cats);
            if (people < cats)
            {
                Console.WriteLine("too many cats!!!");
            }
            if (people > cats)
            {
                Console.WriteLine("not many cats");
            }
            if (people < dogs)
            {
                Console.WriteLine("too many dogs");
            }
            if (people > dogs)
            {
                Console.WriteLine("not many dogs");
            }
            Console.WriteLine("press Enter to continue");
            Console.ReadLine();
            Console.Clear();
            dogs += 5;
            Console.WriteLine("people: " + people + " dogs:" + dogs + " cats: " + cats);
            if (people >= dogs)
            {
                Console.WriteLine("people are greater than or equal to dogs");

            }
            if (people <= dogs)
            {
                Console.WriteLine("people are less than or equal to dogs");
            }
            if (people == dogs) ;
            {
                Console.WriteLine("people are dogs");

            }


        }
    }
}
