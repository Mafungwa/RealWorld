namespace RealWorldSln
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            

        Person person1 = new Person("Pule", 30, "Black", 1.8, false, true);      

            Console.WriteLine("Personal Information: Name > " + person1.GetName());
            Console.WriteLine("Personal Information: Age > " + person1.GetAge());
            Console.WriteLine("Personal Information: Race > " + person1.GetRace());
            Console.WriteLine("Personal Information: Height > " + person1.GetHeight());
            Console.WriteLine("Personal Information: Employeed > " + person1.GetEmployeed());
            Console.WriteLine("Personal Information: Do you have matric > " + person1.GetHaveMatric());
            Console.WriteLine("Personal Information: Language > " + person1.Speak("IsiXhosa"));
            Console.WriteLine("Personal Information: Run/Relay > " + person1.Run("100m"));
            Console.WriteLine("Personal Information: Medication > " + person1.Medication(true));

        }
    }
}
