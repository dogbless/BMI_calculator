using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace SillyPractice
{
    class Person
    {
        public float Height { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public Person(string name,float height, int weight, string gender,int age)
        {
            this.Name = name;
            this.Height = height;
            this.Weight = weight;
            this.Gender = gender;
            this.Age = age;

            
        }

        public void stats()
        {
            

            if (Gender.ToLower() == "female" || Gender.ToLower() == "woman" || Gender.ToLower() == "girl")
            {
                Console.WriteLine($"{Name} is a {Gender} she is {Age} years old, her height is {Height} and her weight is {Weight}");


            }
            else
            {
                Console.WriteLine($"{Name} is a {Gender} he is {Age} years old, his height is {Height} and his weight is {Weight}");

            }
        }
        public void Bmi(float height,int weight)
        {
            here:
            Console.WriteLine("Do you use the metric system or imperial");
            string morI = Console.ReadLine().ToLower();
            if (morI == "metric")
            {

                    float correctHeight = height / 100;
                    float HeightSquared = correctHeight * correctHeight;
                    float wfloat = weight;
                    float bmi = wfloat/HeightSquared;
                    Console.WriteLine($"{Name}'s bmi is {bmi}");
                Console.WriteLine("Would you like to see your health level? y/n");
                var userInput = Console.ReadLine().ToLower();
                if (userInput == "y" || userInput == "yes")
                {
                    Health(bmi);
                }
                else if (userInput == "n" || userInput == "no")
                {
                    Console.WriteLine("ok bye");


                }











            }
            else if (morI == "imperial")
            {
                Console.WriteLine("Inches or feet");
                string inchesOrFeet = Console.ReadLine().ToLower();
                if (inchesOrFeet == "inches")
                {
                    float heightSquared = height * height;
                    float wAndH = weight / heightSquared;
                    float bmi = wAndH * 703;
                    Console.WriteLine($"{Name}'s bmi is {bmi}");
                    Console.WriteLine("Would you like to see your health level? y/n");
                    var userInput = Console.ReadLine().ToLower();
                    if (userInput == "y" || userInput == "yes")
                    {
                        Health(bmi);
                    }
                    else if (userInput == "n" || userInput == "no")
                    {
                        Console.WriteLine("ok bye");
                        

                    }


                }
                else if (inchesOrFeet == "feet")
                {
                    float fheight = height * 12;
                    float heightSquared = fheight * fheight;
                    float wAndH = weight / heightSquared;
                    float bmi = wAndH * 703;
                    Console.WriteLine($"{Name}'s bmi is {bmi}");
                    Console.WriteLine("Would you like to see your health level? y/n");
                    var userInput = Console.ReadLine().ToLower();
                    if (userInput == "y" || userInput == "yes")
                    {
                        Health(bmi);
                    }
                    else if (userInput == "n" || userInput == "no")
                    {
                        Console.WriteLine("ok bye");


                    }

                }
                {
                    
                }


            
            
                
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Incorrect input");
                Console.ForegroundColor = ConsoleColor.White;
                goto here;
            }
            void Health(float bmi)
            {
                if (bmi > 26.3 && bmi < 30)
                {
                    Console.WriteLine("You are overweight");
                    Console.WriteLine("You should try losing some weight");
                    Console.WriteLine("sending exercise and diet plan......");
                    Console.WriteLine("Please stand by");
                    Thread.Sleep(4000);
                    Console.WriteLine("Documents sent");


                }
                else if (bmi > 30)
                {
                    Console.WriteLine("You are Obese your health is at major risk");
                    Console.WriteLine("You need to urgently loseweight");
                    Console.WriteLine("sending exercise and diet plan......");
                    Console.WriteLine("Please stand by");
                    Thread.Sleep(4000);
                    Console.WriteLine("Documents sent");
                }
               
                else if (bmi < 18.5)
                {
                    Console.WriteLine("You are underweight");
                    Console.WriteLine("You need to gain weight");
                    Console.WriteLine("sending exercise and diet plan......");
                    Console.WriteLine("Please stand by");
                    Thread.Sleep(4000);
                    Console.WriteLine("Documents sent");

                }
                else
                {
                    Console.WriteLine("You are healthy");
                    Console.WriteLine("Keep doing what you are doing :)");


                }

            }

        }
    }
}
