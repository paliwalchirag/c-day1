using Microsoft.VisualBasic.FileIO;
using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataTypeDayOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name");
            //String name = Console.ReadLine();

            //Console.WriteLine("Enter Age");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Geneder M/F");
            //char gender = Convert.ToChar(Console.ReadLine());

            //Console.WriteLine("Enter Marks");
            //float marks = Convert.ToSingle(Console.ReadLine());

            ////Console.WriteLine("Name = "+name);
            ////Console.WriteLine("Age = " + age);
            ////Console.WriteLine("Gender = " + gender);
            ////Console.WriteLine("Marks = " + marks);

            //Console.WriteLine(" Name = " + name + "\n Age = " + age + "\n Gender = " + gender + "\n Marks = " + marks);

            //if (age >= 18)
            //{
            //    Console.WriteLine("you can drive");
            //}
            //else
            //{
            //    Console.WriteLine("you can not drive");
            //}

            //            Write a program named Admission for a college’s admissions office.The user enters
            //a numeric high school grade point average and an admission
            //test score.Display the message Accept if the student meets either of the following
            //requirements:
            //• A grade point average of 3.0 or higher, and an admission test score of at least 60
            //• A grade point average of less than 3.0, and an admission test score of at least 80
            //• If the student does not meet either of the qualification criteria, display Reject.

            //int age=Convert.ToInt32(Console.ReadLine());
            //if(age > 60 || age < 16)
            //{
            //    Console.WriteLine("FREE ticket");
            //}
            //else
            //{
            //    Console.WriteLine("Pay for it");
            //}

            //Console.WriteLine("Enter grade Point");
            //float gradePoint=Convert.ToSingle(Console.ReadLine());

            //Console.WriteLine("Enter admission test score");
            //float testScore = Convert.ToSingle(Console.ReadLine());

            //if(gradePoint>=3.0 && testScore >= 60)
            //{
            //    Console.WriteLine("admission granted");
            //}else if(gradePoint<3.0 && testScore >= 80)
            //{
            //    Console.WriteLine("admission granted");
            //}
            //else
            //{
            //    Console.WriteLine("Reject");
            //}

            //            Write an application that displays every perfect number from 1  through 10,000.
            //                A number is perfect if it equals the sum of all the smaller positive  
            //                integers that divide evenly into it. For example, 6 is perfect because 
            //                1, 2, and 3 divide
            //evenly into it and their sum is 6



            //Console.WriteLine("Enter any number ");

            //int number = 2;

            //while (number > 1 && number <= 10000)
            //{
            //    Console.WriteLine("Enter any number between 1 and 10000 ");
            //    number = Convert.ToInt32(Console.ReadLine());
            //    int sum = 0;
            //    for(int i = 1; i < number; i++)
            //    {
            //        if (number % i == 0)
            //        {
            //            sum += i;
            //        }

            //    }
            //    if (sum == number)
            //    {
            //        Console.WriteLine("the number is Perfect "+number);
            //    }
            //    else
            //    {
            //        Console.WriteLine("not the perfect");
            //    }
            //}

            //Write an application that continuously prompts a user for a series  of daily high 
            //    temperatures until the user enters a sentinel value(A value to denote end
            //    of input).Valid temperatures  range from 20 through 130 Fahrenheit.When
            //    the user enters a valid temperature, add it to a total; when the user 
            //    enters an invalid temperature, display an error message.  Before the
            //    program ends, display the number of temperatures entered and the average 
            //    temperature.

            //float temprature = 100;
            //int sentinalValue = 999;
            //float sum = 0;
            //int count = 0;
            //while(temprature != sentinalValue)
            //{
            //    Console.WriteLine("Enter the Temprature");
            //    temprature = Convert.ToSingle(Console.ReadLine());

            //    if (temprature < 20 || temprature > 130)
            //    {
            //        Console.WriteLine("Error");

            //    }
            //    else
            //    {
            //        sum += temprature;
            //        count++;
            //    }

            //}
            //Console.WriteLine("NUmber of temprature enters " + count);
            //Console.WriteLine("Average is "+sum/count);

            //            In the game Rock Paper Scissors, two players simultaneously choose one of three
            //options: rock, paper, or scissors. If both players choose the same option, then the
            //result is a tie. However, if they choose differently, the winner is determined as follows:
            //• Rock beats scissors, because a rock can break a pair of scissors.
            //• Scissors beats paper, because scissors can cut paper.
            //• Paper beats rock, because a piece of paper can cover a rock.
            //Create a game in which the computer randomly chooses roc


            //int temp = 1;
            //int temp2 = 1;

            //while (temp==1 || temp==2 || temp==3 || temp2 == 1 || temp2 == 2 || temp2 == 3)
            //{
            //    Console.WriteLine("player one pick 1.rock  2.paper 3.scissor");
            //    temp = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("player two pick 1.rock  2.paper 3.scissor");
            //    temp2 = Convert.ToInt32(Console.ReadLine());

            //    if (temp == temp2)
            //    {
            //        Console.WriteLine("Draw ");
            //    }
            //    if(temp == 1 && temp2 == 2)
            //    {
            //        Console.WriteLine("player two win");
            //    }
            //    if(temp==1 && temp2== 3)
            //    {
            //        Console.WriteLine("player one win");
            //    }
            //    if(temp==2 && temp2 == 1)
            //    {
            //        Console.WriteLine("player one win");
            //    }
            //    if(temp==2 && temp2 == 3)
            //    {
            //        Console.WriteLine("player two win");
            //    }
            //    if(temp==3 && temp2 == 1)
            //    {
            //        Console.WriteLine("player two win");
            //    }
            //    if(temp==3 && temp2 == 2)
            //    {
            //        Console.WriteLine("player one win");
            //    }
            //}


            //            AMN is a Transportation company that ships Goods to various  part of the country
            //            . The company uses the following function to calculate the cost(in dollars) of
            //            shipping based on the weight of the package(in pounds).
            //3.5, if 0 < w <= 1
            //5.5, if 1 < w < = 3
            //8.5, if 3 < w <= 10
            //10.5, if 10 < w <= 20
            //Write a program that prompts the user to enter the weight of the package and display the
            //shipping cost.If the weight is greater than 40, display a message “the package cannot
            //be shipped.”
            //AMN is a Tr

            //Console.WriteLine("Enter the weight");
            //float cost;
            //float weight=Convert.ToInt32(Console.ReadLine());
            //switch (weight)
            //{
            //    case float w when (w > 0 && w <= 1):
            //        cost = 3.5f;
            //        Console.WriteLine("Cost is 3.5");
            //        break;

            //    case float w when (w > 1 && w <= 3):
            //        cost = 5.5f;
            //        Console.WriteLine("Cost is 5.5");
            //        break;

            //    case float w when (w > 3 && w <= 10):
            //        cost = 8.5f;
            //        Console.WriteLine("Cost is 8.5");
            //        break;

            //    case float w when (w > 10 && w <= 20):
            //        cost = 10.5f;
            //        Console.WriteLine("Cost is 10.5");
            //        break;

            //    case float w when w > 40:
            //        Console.WriteLine("the package cannot be shipped");
            //        break;

            //    default:
            //        Console.WriteLine("cost is 10.5");
            //        break;

            //}

            Console.WriteLine("enter string");
            string name = Console.ReadLine();
            name.ToCharArray();

            int count = 0;
            for(int i = 0; i < name.Length; i++)
            {
                if (name[i]=='a' || name[i] == 'e' || name[i] == 'i' || name[i] == 'o' || name[i] == 'u')
                Console.Write(name[i] +" ");
                count++;
            }
            Console.WriteLine(count);
            













        }
    }
}
