// Task 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
Console.WriteLine("This program calculates the average of each column.");
int numberRow = EnterUserData("Enter number of rows:");
int numberCol = EnterUserData("Enter number of columns:");
int lowerLim = EnterUserData("Enter lower limit for random range:");
int upperLim = EnterUserData("Enter upper limit for random range:");
int precision = EnterUserData("Enter precision:");
int[,] randomArray = new int[numberRow, numberCol];
double[] averageArray = new double[numberCol];
FillArray(randomArray, numberRow, numberCol, lowerLim, upperLim);
PrintArray(randomArray);

for (int i = 0; i < randomArray.GetLength(1); i++)
{
double sum = 0;
for (int j = 0; j < randomArray.GetLength(0); j++)
{
sum = sum + randomArray[j, i];
}
averageArray[i] = Math.Round(sum / randomArray.GetLength(0), precision); ;
Console.WriteLine($"The average of the column {i} is {averageArray[i]};");
}

int[,] FillArray(int[,] array, int numberRow, int numberCol, int lowerLim, int upperLim)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(lowerLim, upperLim + 1);
}
}
return array;
}

void PrintArray(int[,] array)
{
Console.WriteLine("You entered the following array:");
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i, j] + " ");
}
Console.WriteLine();
}
}

int EnterUserData(string nameUserData)
{
Console.Write($"{nameUserData}");
return Convert.ToInt32(Console.ReadLine());
}