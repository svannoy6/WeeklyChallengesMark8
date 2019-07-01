using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
       public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            int answerSubtract;

            answerSubtract = 25 - 10;

            Console.WriteLine(answerSubtract);
            return answerSubtract;

           
        }

        public int Add(int number1, int number2)
        {
			int answerAdd;
			answerAdd = 5 + 5;
			Console.WriteLine(answerAdd);
            return answerAdd;

        }

        public int GetSmallestNumber(int number1, int number2)
        {
          if (number1 < number2)
          {
                return number1;   
          }
          else
            {
                return number2;
            }


        }

        public long Multiply(long factor1, long factor2)
        {
            throw new NotImplementedException();
        }

        public string GetGreeting(string nameOfPerson)
        {
            string personName = "Nick.";
            Console.WriteLine("Hello " + personName);
            return personName;
        }

        public string GetHey()
        {
            string response = "Hey!";
            Console.WriteLine(response);
            return response;
    }
}
