using System;

namespace Laba_6
{
    public abstract class PersonBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public bool HasAuto { get; set; }
        public bool HasBike { get; set; }
        public double BMI { get; set; }

        public abstract double CalculateBMI();
    }

    public class Person : PersonBase
    {
        public override double CalculateBMI()
        {
            return Weight / (Height * Height);
        }

        public Person() { }

        public Person(string firstname, string lastname, string gender,
                      int age, double weight, double height, bool hasAuto, bool hasBike, double calculateBMI)
        {
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            Age = age;
            Weight = weight;
            Height = height;
            HasAuto = hasAuto;
            HasBike = hasBike;
            BMI = calculateBMI;
        }
    }

    public class Athlete : PersonBase
    {
        public override double CalculateBMI()
        {
            return 0.9 * (Weight / (Height * Height));
        }
    }

    public class OverweightPerson : PersonBase
    {
        public override double CalculateBMI()
        {
            return (Weight / (Height * Height)) * 1.1;
        }
    }
}
