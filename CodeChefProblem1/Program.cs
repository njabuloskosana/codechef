using System;

namespace CodeChefProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            String numInputs;
            numInputs = Console.ReadLine();
            int index = Convert.ToInt32(numInputs);
            int [] answers = new int[index];
            int arrayIndex = 0;
            for (int i=0;i<index;i++)
            {
                String values;
                String firstNumber="";
                String secondNumber="";
                values = Console.ReadLine();
                int currentNum = 1;
                for(int j=0;j<values.Length;j++)
                {
                    if(values[j]!=' ')
                    {
                        if(currentNum==1)
                        {
                            firstNumber += values[j];
                        }
                        else
                        {
                            secondNumber += values[j];
                        }
                    }
                    else
                    {
                        currentNum++;
                    }
                }
                int num1 = Convert.ToInt32(firstNumber);
                int num2 = Convert.ToInt32(secondNumber);
                int answer = num1 + num2;
                answers[arrayIndex] = answer;
                arrayIndex++;
                
            }
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(answers[i]);
            }

        }
    }
}
