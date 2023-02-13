/*
//task1 По двум заданным числам проверять является ли первое квадратом второго

Console.WriteLine("Enter first number: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int secondNumber = int.Parse(Console.ReadLine());

 if (firstNumber == secondNumber * secondNumber)

{
    Console.WriteLine("Bingo!!! First number is squre of the second number! ");
}
else
{
Console.WriteLine("Sorry.First number is NOT sqare of the second number. ");
}



//task2 По заданному номеру дня недели вывести его название

Console.WriteLine("Please enter number day of the week:");
var numberOfDay = int.Parse(Console.ReadLine());

switch (numberOfDay)
{
    case 1:
    Console.WriteLine("Monday");
    break;

    case 2:
    Console.WriteLine("Tuesday");
    break;

    case 3:
    Console.WriteLine("Wednesday");
    break;

    case 4:
    Console.WriteLine("Thursday");
    break;

    case 5:
    Console.WriteLine("Friday");
    break;

    case 6:
    Console.WriteLine("Saturday");
    break;

    case 7:
    Console.WriteLine("Sunday");
    break;

    default:
    Console.WriteLine("Mistake!!! Enter number from 1 to 7");
    break;
}



//task3 Найти максимальное из трех чисел

Console.WriteLine("Please enter three different numbers: ");

int numberUno = int.Parse(Console.ReadLine());
int numberDue = int.Parse(Console.ReadLine());
int numberTre = int.Parse(Console.ReadLine());

int mostMax = numberUno;

if (numberDue > mostMax) mostMax = numberDue;
if (numberTre > mostMax) mostMax = numberTre;
int showMax = mostMax;
Console.WriteLine(showMax);



//task4 Выяснить является ли число чётным

 Console.WriteLine("Please,enter number;");
int testNumber = int.Parse(Console.ReadLine());
int reminder = testNumber%2;

string output = reminder == 0 ? "Evenly" : "not Evenly";

Console.WriteLine("Number is: " + output + "!!!");

*/

 //task5  Показать все четные числа от 1 до N

Console.WriteLine("Please, Enter number: ");
var enteredNumber = int.Parse(Console.ReadLine());
var evenNumber = 2;
if (enteredNumber > 1)
{
  while(evenNumber <= enteredNumber)
  {
    Console.Write(evenNumber + " ");
    evenNumber +=2;
  }
}

