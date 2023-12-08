namespace RealWorldSln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            

        Person person1 = new Person("Pule", 30, "Black", 1.8, false, true);

            person1.Speak("IsiXosha");
            person1.Run("100m");
            person1.Medication(true);

            Console.WriteLine("Personal Information: " + person1.Name);
            Console.WriteLine("Personal Information: " + person1.Age);
            Console.WriteLine("Personal Information: " + person1.Race);
            Console.WriteLine("Personal Information: " + person1.Height);
            Console.WriteLine("Personal Information: " + person1.Employeed);
            Console.WriteLine("Personal Information: " + person1.HaveMatric);
            Console.WriteLine("Personal Information: " + person1.Speak);
            Console.WriteLine("Personal Information: " + person1.Run);
            Console.WriteLine("Personal Information: " + person1.Medication);





        }
    }
}
