void Task19(){
    // Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
    Console.Write("Введите пятизначное число: ");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    if(number % 10 == number / 10000 && number /10%10 == number /1000%10){
        Console.WriteLine("Число полиндром");
    }
    else
    {
        Console.WriteLine("Число не полиндром");
    }
}
void Task21(){
    // Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
    Console.Write("Введите координату Х точки А: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y точки А: ");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z точки A: ");
    int az = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату X точки B: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Y точки B: ");
    int by = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату Z точки B: ");
    int bz = Convert.ToInt32(Console.ReadLine());

    double ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
    Console.WriteLine("Расстояние от точки А до B : " + Math.Round(ab, 2));
}
void Task23(){
    // Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
}

//Task19();
Task21();