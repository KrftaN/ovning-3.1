namespace övning_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange din ålder:");
            int age = int.Parse(Console.ReadLine());

            if (age >= 16 && age <= 19)
            {
                Console.WriteLine("Du får delta i tävlingen.");
            }
            else if (age < 16)
            {
                Console.WriteLine("Du är för ung för att delta i tävlingen.");
            }
            else
            {
                Console.WriteLine("Du är för gammal för att delta i tävlingen.");
            }
        }
    }
}
