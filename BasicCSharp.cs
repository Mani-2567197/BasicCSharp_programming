using System;
namespace BasciCSharpAssigment
{
    public class BasicCSharp
    {

        public void PrintDetails()
        {
            Console.WriteLine("Plz Enter User Name");
            string username = Console.ReadLine().ToUpper();
            Console.WriteLine($"*** Hello,{username}! ***");
        }
        public void BasicArithmetic()
        {

            string choice;
            Console.WriteLine("*** Performing Basic Arithmetic Operations ***");
            try
            {
                do
                {
                    Console.WriteLine("Enter the values for num1 & num2:");
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Arithmetic operations as follows:");
                    Console.WriteLine($"Addition:{num1 + num2}\nSubtraction:{num1 - num2}\nMultiplcation:{num1 * num2}\nDivision:{num1/num2}\nModulus:{num1 % num2}");
                    Console.WriteLine("Do you wanna continue the operation if yes press y to exit press any key....");
                    choice = Console.ReadLine().ToUpper();
                }
                while (choice == "Y");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide by zero is undefined:"+e.Message);
            }
           
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input:"+e.Message);
            }
        }
        public void EvenorOdd()
        {
            Console.WriteLine("Determineing the given number is even or odd :");
            try
            {
                string choice;
                do
                {
                    Console.WriteLine("Enter the value for number");
                    int num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        Console.WriteLine($"Number {num} is :Even");
                    }
                    else
                    {
                        Console.WriteLine($"Number {num} is :Odd");
                    }
                    Console.WriteLine("Do you wanna continue the operation if yes press y to exit press any key....");
                    choice = Console.ReadLine().ToUpper();
                }
                while (choice == "Y"); 
            }
            catch(FormatException e)
            {
                Console.WriteLine("Invalid format:" + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error !!!" + e.Message);
            }
        }
        public void Loop()
        {
            Console.WriteLine("*** printig numbers using for loop ***");
            for(int i = 1; i <=10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");
        }
        public void Array()
        {
            int[] values = new int[5] {5,10,20,30,40};
            int sum = 0; double average = 0;
            foreach(int i in values)
            {
                sum += i;
                
            }
            average += sum / values.Length;
            Console.WriteLine("Sum:\t"+sum);
            Console.WriteLine("Average:\t"+average);
        }
        public void Calculatefactorial()
        {
            int fact = 1;
            Console.WriteLine("Enter the number to calculate Factorial");
            int num=int.Parse(Console.ReadLine());
            for(int i = 1; i <=num; i++)
            {
                fact=fact*i;
            }
            Console.WriteLine($"Factorial of {num} is :"+fact);
        }

        public void Conversion()
        {
            
            bool valid = false;
            int age = 0;
            while (!valid)
            {
                Console.Write("Enter Age:\t");
                string str = Console.ReadLine();
                
                if(int.TryParse(str, out age))
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid age");
                }
            }
            if (age<18)
            {
                Console.WriteLine($"This person is minor age is :{age}");
            }
            else if (age >= 18 && age<65)
            {
                Console.WriteLine($"This person is Adult age is :{age}");
            }
            else
            {
                Console.WriteLine($"This person is Senior Citizen age is :{age}");
            }
        }
    }
}

