using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            String fullName = "Anikin Stanislav Gennadyevich";
            Byte yourAge = 36;
            String yourEmail = "saulgoodman7777@yandex.ru";
            Double assessmentPrograming = 89.7;
            Double assessmentMath = 78.8;
            Double assessmentPhysics = 92.3; 
            Console.WriteLine($"Full Name: {fullName}\n Your Age: {yourAge}\n Your Email {yourEmail}\n Your Points for Programming {assessmentPrograming}\n Your Points for Math {assessmentMath}\n Your Points for Physics {assessmentPhysics}" );
            Console.ReadKey();

            //Console.WriteLine("Full name: " + fullName);
            //Console.WriteLine("Your Age: " + yourAge);
            //Console.WriteLine("Your Email: " + yourEmail);
            //Console.WriteLine("Points Program: " + assessmentPrograming);
            //Console.WriteLine("Points Mahth: " + assessmentMath);
            //Console.WriteLine("Points Physics: " + assessmentPhysics);
            //Console.ReadKey();

            //Начало второго задания
            Double a = assessmentPrograming;
            Double b = assessmentMath;
            Double c = assessmentPhysics;

            //Double totalPoints = a + b + c;
            Console.WriteLine($"Total ponts : {a+b+c}");
            Console.ReadKey();

            //Double averagePoints = (a + b + c) / 3;
            Console.WriteLine($"Average points: {(a+b+c)/3}");
            Console.ReadKey();




        }
    }
}
