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