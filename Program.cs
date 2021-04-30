using System;
using System.Linq;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter total number of subjects offered : ");
            string totalNumberOfSubjects = Console.ReadLine();

            string checkedNoOfSubject = checkInput(totalNumberOfSubjects);
            double arraySizeToDouble = double.Parse(checkedNoOfSubject);

            int arraySize = (int)arraySizeToDouble;
            double[] studentScore = new double[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Enter score for subject {i+1} : ");
                string userScoreInput = Console.ReadLine();

                string checkedScoreInput = checkInput(userScoreInput);
                studentScore[i] = double.Parse(checkedScoreInput);
            }

            double cgpa = (studentScore.Sum()) / (arraySize * 10);
            double percentageCgpa = cgpa * 9.5;
            Console.WriteLine($"Your CGPA is : {cgpa, 0:F2} \nYour percentage CGPA is : {percentageCgpa, 0:F2}");
        }

        static string checkInput(string userInput)
        {
            bool isValid = double.TryParse(userInput, out double checkValue);
            while (isValid == false)
            {
                Console.Write($"Invalid input! \nEnter a valid input : ");
                userInput = Console.ReadLine();
                isValid = double.TryParse(userInput, out checkValue);
            }
            return userInput;
        }
    }
}