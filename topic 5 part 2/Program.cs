namespace topic_5_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int secerectnumber;
            secerectnumber = 1;



            Console.WriteLine("guess a number between 1-10");
            int.TryParse(Console.ReadLine(), out number);
            if (number == 1) 
            {

                Console.WriteLine("omg you got it right");



            }
            else
            {


                Console.WriteLine("thats not it the number was " + secerectnumber );

            }
            

        }
    }
}
