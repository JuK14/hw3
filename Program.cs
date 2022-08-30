//Задача 1

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

if (number.Length > 5 || number.Length < 4)
{
  Console.WriteLine("Не пятизначное число");
  
}
else
{
if (number[0] == number[4] && number[1] == number[3])
{
    Console.WriteLine(number + "- Является палиндромом");
}
else
{
    Console.WriteLine(number + "- Не является палиндромом");
}
}


//Задача 2

Console.WriteLine("Введите координаты точки A по оси абсцисс: ");
double Ax = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки A по оси ординат: ");
double Ay = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки А по оси аппликат: ");
double Az = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси абсцисс: ");
double Bx = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси ординат: ");
double By = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B по оси аппликат: ");
double Bz = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((Ax-Bx),2)+ Math.Pow((Ay-By),2)+ Math.Pow((Az-Bz),2));

Console.WriteLine("Расстояние между точкой А и точкой B равно  " + Math.Round(result,2));