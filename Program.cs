// Задача №10
//Console.WriteLine("Введите трёхзначное число :");
//string Numbers =Console.ReadLine()!;
//if (Numbers.Length !=3) {
//  Console.WriteLine("Введено неверное число");
//}
//else
//{
 //   Console.WriteLine($"Вторая цифры равна: {Numbers[1]}");
 //}


// Задача №15
Console.WriteLine("Введите число от 1 до 7 :");
int numbers = int.Parse (Console.ReadLine()!);
int a = numbers ;
    if (numbers > 0 && numbers < 8)
    {
        if (numbers == 7 || numbers == 6)
        {
            Console.Write("Под цифрой " + numbers + " - Выходной");
        }
        else
        {
            Console.Write("Под цифрой " + numbers + " - Рабочий");
        }
    }



