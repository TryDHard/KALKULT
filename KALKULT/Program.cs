int result;
int int1;
int int2;
int operation;

Console.WriteLine("1)Сложение");
Console.WriteLine("2)Вычитание");
Console.WriteLine("3)Умножение");
Console.WriteLine("4)Деление");
Console.WriteLine("5)Возведение в степень");
Console.WriteLine("6)Найти корень");
Console.WriteLine("7)Найти % от числа");
Console.WriteLine("8)Найти факториал из числа");
Console.WriteLine("9)Выход из программы");

Console.WriteLine("Введите операцию: ");
operation = Convert.ToInt32(Console.ReadLine());

while (operation != 9)
{
    
    if (operation == 1)
    {

        Console.WriteLine("Введите слагаемое №1: ");
        int1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите слагаемое №2: ");
        int2 = Convert.ToInt32(Console.ReadLine());

        result = int1 + int2;

        Console.WriteLine("Сумма = " + result);

    }

    else if (operation == 2)
    {

        Console.WriteLine("Введите уменьшаемое: ");
        int1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите вычитаемое: ");
        int2 = Convert.ToInt32(Console.ReadLine());

        result = int1 - int2;

        Console.WriteLine("Разность = " + result);



    }
    
    else if (operation == 3)
    {

        Console.WriteLine("Введите множимое: ");
        int1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите множитель: ");
        int2 = Convert.ToInt32(Console.ReadLine());

        result = int1 * int2;

        Console.WriteLine("Призведение = " + result);



    }

    else if (operation == 4)
    {

        Console.WriteLine("Введите делимое: ");
        int1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите делитель: ");
        int2 = Convert.ToInt32(Console.ReadLine());

        result = int1 / int2;

        Console.WriteLine("Частное = " + result);



    }

    else if (operation == 5)
    {

        Console.WriteLine("Введите основание степени: ");
        int1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите показатель степени: ");
        int2 = Convert.ToInt32(Console.ReadLine());

        result = Convert.ToInt32(Math.Pow(int1, int2));

        Console.WriteLine(int1 + " в степени " + int2 + " = " + result);



    }

    else if (operation == 6)
    {

        Console.WriteLine("Введите число из которого нужно извелчь квадратный корень: ");
        int1 = Convert.ToInt32(Console.ReadLine());

        result = Convert.ToInt32(Math.Sqrt(int1));

        Console.WriteLine("Квадратный корень числа " + int1 + " = " + result);



    }

    else if (operation == 7)
    {

        Console.WriteLine("Введите число от которого надо найти процент: ");
        int1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите искомый процент: ");
        int2 = Convert.ToInt32(Console.ReadLine());

        result = (int1 * int2 / 100); ;

        Console.WriteLine(int2 + " процент(а) от числа " + int1 + " = " + result);



    }

    else if (operation == 8)
    {
        {
            Console.WriteLine("Введите число факториал которого нужно найти: ");

            int1 = Convert.ToInt32(Console.ReadLine());

            int fact = 1;

            for (int i = 2; i <= int1; i++)
            {

                fact = fact * i;

            }
            Console.WriteLine("Факториал числа " + int1 + " = " + fact);

        }

        Console.WriteLine("Какую операцию совершить далее?");
        Console.WriteLine("1)Сложение");
        Console.WriteLine("2)Вычитание");
        Console.WriteLine("3)Умножение");
        Console.WriteLine("4)Деление");
        Console.WriteLine("5)Возведение в степень");
        Console.WriteLine("6)Найти корень");
        Console.WriteLine("7)Найти % от числа");
        Console.WriteLine("8)Найти факториал из числа");
        Console.WriteLine("9)Выход из программы");

        operation = Convert.ToInt32(Console.ReadLine());

    }

}

Console.WriteLine("Всего хорошего!");