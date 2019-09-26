using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What's your name?");
            string name;
            name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "! What's your age?");
            int age;
            age = int.Parse(Console.ReadLine());
            if(age<20)
            {
                Console.WriteLine("We apologize. Your BMI might not be accurate due to you being young.");
            }
            else if(age>60)
            {
                Console.WriteLine("We apologize. Your BMI might not be accurate due to you being old.");
            }
            else
            {
                Console.WriteLine("This is your Body Mass Index calculator. Please insert your weight in kilograms");
                double mass;
                mass = double.Parse(Console.ReadLine());
                Console.WriteLine("Now please insert your height in meters");
                double height;
                height = double.Parse(Console.ReadLine());
                double bmi;
                bmi = mass / (height * height);
                Console.WriteLine("Your bmi is" + " " + Math.Round(bmi).ToString()+",");
                if (bmi < 16)
                {
                    Console.Write(" life threatening underweight.");
                }
                else if (bmi < 18.5)
                {
                    Console.Write(" underweight.");
                }
                else if (bmi < 25)
                {
                    Console.Write(" normal weight.");
                }
                else if (bmi < 30)
                {
                    Console.Write(" overweight.");
                }
                else if (bmi < 35)
                {
                    Console.Write(" obese.");
                }
                else if (bmi < 40)
                {
                    Console.Write(" morbid obese.");
                }
                else
                {
                    Console.Write(" life threatening obesity.");
                }
                }
            }
        }
    }

