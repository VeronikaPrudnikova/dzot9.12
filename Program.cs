// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
int naturalNumber(int A, int B)
{
    int step = A;

    for(int i = 1; i < B; i++)
    {
        step = step * A;
    }

    return step;

}

Console.Write("Enter the number A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number B: ");
int B = Convert.ToInt32(Console.ReadLine());

int result = naturalNumber(A, B);

Console.WriteLine($"A в степени B равно -> {result}");
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    sum = sum + (number%10);
    number = number / 10;
    
}
Console.Write($"Сумма {sum}");
*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

/*
int[] Newarray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Введите элемент {i} массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = Newarray(size);

for(int i = 0; i < myArray.Length; i++)
{
    Console.Write($"{myArray[i]}, ");
}
*/