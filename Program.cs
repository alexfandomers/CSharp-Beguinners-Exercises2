namespace Exercises2
{
     public class Program
    {
        static void Main(string[] args)
        {  
          Console.WriteLine("///number 1///");
          //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
          //Display the count on the console.
          for (int i = 1; i < 10; i++)
           {
                if (i%3 == 0)
                {
                    Console.WriteLine(i);
                }
           }
          Console.WriteLine("///number 2///");

          //2- Write a program and continuously ask the user to enter a number or "ok" to exit.
          //Calculate the sum of all the previously entered numbers and display it on the console.
           var sum =0;
           var convertendo=0;
           while (true)
           {
                Console.WriteLine("Input a number: ");
                var inputA = Console.ReadLine();

                if (inputA == "ok")
                {
                    break;
                }
                else
                {
                    convertendo = Convert.ToInt32(inputA);
                    sum = sum + convertendo;
                }
                Console.WriteLine("O total é: " + sum);
           }
          Console.WriteLine("///number 3///");

          //3- Write a program and ask the user to enter a number.
          //Compute the factorial of the number and print it on the console. 
          //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
          //and display it as 5! = 120.
            int fact=1, numberB; 

            Console.Write("Enter any Number: ");
            numberB= Convert.ToInt32(Console.ReadLine()); 

            for(var i=1; i<=numberB; i++)
            {      
                fact=fact*i;      
            }      
            Console.WriteLine(numberB+ "!" + " = " + fact); 
            Console.WriteLine("///number 4///");

            //4- Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number. If the user guesses the number,
            //display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)  
            Random randoms = new Random();

            var randomNumber = randoms.Next(100,200);

            Console.WriteLine(randomNumber);

            Console.WriteLine("Input a number: ");
            var input =Convert.ToInt32(Console.ReadLine());

            if (input == randomNumber)
            {
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("You lost");
            }
            Console.WriteLine("///number 5///");

            //5- Write a program and ask the user to enter a series of numbers separated by comma.
            //Find the maximum of the numbers and display it on the console. For example
            //if the user enters “5, 3, 8, 1, 4", the program should display 8.
            Console.Write("Enter a series of numbers separated by comma: ");
            var userInput = Console.ReadLine();
            var numbers = userInput.Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach (var n in numbers)
            {
                var numberA = Convert.ToInt32(n);
                if (numberA > max)
                {
                    max = numberA;
                }
            }
            Console.WriteLine("Max is: " + max);
        }

    }
}