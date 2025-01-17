﻿// // Вывод на экран цифр введенных с клавиатуры

void PrintNumber(int[,] numbers, int userNumber)
{
    int columnsInNumber = 6;
    int allNumbersInArray = 10;
    int startPrint = numbers.GetLength(1) - 1 - (columnsInNumber * (allNumbersInArray - userNumber));
    int endPrint = startPrint + columnsInNumber;
    if (userNumber != 0)
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = startPrint; j < endPrint; j++)
            {
                if (numbers[i, j] == 0) Console.Write(" ");
                else Console.Write("#");
            }
            Console.WriteLine();
        }
    }
    else
    {
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = startPrint + 1; j < endPrint; j++)
            {
                if (numbers[i, j] == 0) Console.Write(" ");
                else Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
int[,] numbers =
{
    {0, 0, 1, 1, 0, 0,  0, 0, 0, 0, 1, 0,  0, 0, 1, 1, 0, 0,  0, 0, 1, 1, 0, 0,  0, 0, 0, 0, 1, 0,  0, 1, 1, 1, 1, 0,   0, 0, 1, 1, 0, 0,   0, 1, 1, 1, 1, 0,   0, 0, 1, 1, 0, 0,   0, 0, 1, 1, 0, 0  },
    {0, 1, 0, 0, 1, 0,  0, 0, 0, 1, 1, 0,  0, 1, 0, 0, 1, 0,  0, 1, 0, 0, 1, 0,  0, 0, 0, 1, 1, 0,  0, 1, 0, 0, 0, 0,   0, 1, 0, 0, 0, 0,   0, 0, 0, 1, 0, 0,   0, 1, 0, 0, 1, 0,   0, 1, 0, 0, 1, 0  },
    {0, 1, 0, 0, 1, 0,  0, 0, 1, 0, 1, 0,  0, 0, 0, 1, 0, 0,  0, 0, 0, 1, 0, 0,  0, 0, 1, 0, 1, 0,  0, 1, 1, 1, 0, 0,   0, 1, 1, 1, 0, 0,   0, 0, 1, 0, 0, 0,   0, 0, 1, 1, 0, 0,   0, 0, 1, 1, 1, 0  },
    {0, 1, 0, 0, 1, 0,  0, 0, 0, 0, 1, 0,  0, 0, 1, 0, 0, 0,  0, 1, 0, 0, 1, 0,  0, 1, 1, 1, 1, 0,  0, 0, 0, 0, 1, 0,   0, 1, 0, 0, 1, 0,   0, 1, 0, 0, 0, 0,   0, 1, 0, 0, 1, 0,   0, 0, 0, 0, 1, 0  },
    {0, 0, 1, 1, 0, 0,  0, 0, 0, 0, 1, 0,  0, 1, 1, 1, 1, 0,  0, 0, 1, 1, 0, 0,  0, 0, 0, 0, 1, 0,  0, 1, 1, 1, 0, 0,   0, 1, 1, 1, 0, 0,   0, 1, 0, 0, 0, 0,   0, 0, 1, 1, 0, 0,   0, 0, 1, 1, 0, 0  },
};

// int userNumber = Convert.ToInt32(Console.ReadLine());

int userNumber = 123;

while (userNumber > 0)
{
    int printNumber;
    printNumber = userNumber % 10;
    userNumber /= 10;
    PrintNumber(numbers, printNumber);
}
