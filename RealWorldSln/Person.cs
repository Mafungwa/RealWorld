using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RealWorldSln
{
    internal class Person
    {
        
        private int Age;
        private string Race;
        private double Height;
        private string Name;
        private bool HaveMatric;
        private bool Employeed;


        public Person(string name, int age, string race, double height, bool employeed, bool havematric) {

            Name = name;
            Age = age;
            Race = race;
            Height = height;
            HaveMatric = havematric;
            Employeed = employeed;        
        }

        public string Run(string relay)
        {
            return relay;
        }
        public string Speak(string language)
        {
            return language;
        }
        public bool Medication(bool status) 
        {
            return true;
        }
    }
}
