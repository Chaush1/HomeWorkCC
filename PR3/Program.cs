
/*Напишите программу, которая принимает на вход 
пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число из пяти цифр: ");
        string number = Console.ReadLine();

        void CheckingNumber(string number)
        {
            if (number[0] == number[4] && number[1] == number[3])
            {
                Console.WriteLine("ДА");
            }
            else Console.WriteLine("НЕТ");
        }
            if (number!.Length == 5)
        {
            CheckingNumber(number);
        }
        else Console.WriteLine("Ведите пятизначное число: ");
*/

/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.


Console.Write("Введите координаты точки А через пробел: ");
        string xyz = Console.ReadLine()!;
        string[] partsA = xyz.Split(' ');
        int xA = int.Parse(partsA[0]);
        int yA = int.Parse(partsA[1]);
        int zA = int.Parse(partsA[2]);

        Console.Write("Введите координаты точки B через пробел: ");
        xyz = Console.ReadLine()!;
        string[] partsB = xyz.Split(' ');
        int xB = int.Parse(partsB[0]);
        int yB = int.Parse(partsB[1]);
        int zB = int.Parse(partsB[2]);

        double distsnce = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2));

        Console.WriteLine($"Расстояние между точкой А -> B = {distsnce:F2}");
*/

/* Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");

        int number = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= number; i++)

Console.Write($"{Math.Pow(i, 3)}. ");
*/


