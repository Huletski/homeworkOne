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





//task6 Показать последнюю цифру трехзначного числа

int N = 0;
Console.WriteLine("Введите трехзначное чило: ");
N = int.Parse(Console.ReadLine());
if (N >= 100 && N <= 999)
{
 int lastDigit = N%10;
 Console.WriteLine("Последняя цира числа: " + lastDigit);
}
else
{
 Console.WriteLine("Это не трехзначное число!!!!");
}

 */



 //task7 Показать вторую цифру трехзначного числа

/* 

Console.WriteLine("Введите трехзначное чило: ");
string Z = Console.ReadLine();
if (Z.Length == 3)

{
string lastDig = Z.Substring(1,1);
 Console.WriteLine("Вторая цира числа: " + lastDig);
}
else
{
 Console.WriteLine("Это не трехзначное число!!!!");
}

*/




//task8 Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

/*
string num = new Random().Next(10, 99).ToString();

string maxNumb = null;

if (Convert.ToInt32(num.Substring(0,1)) > Convert.ToInt32(num.Substring(1,1)))
{
maxNumb = num.Substring(0,1);
}
else
{
maxNumb = num.Substring(1,1);
}
Console.WriteLine ("Рандомное число: " + num);
Console.WriteLine ("Наибольшая цифра из этого числа: " + maxNumb);

*/




//task9 Удалить вторую цифру трёхзначного числа

/*

Console.WriteLine("Введите трехзначное чило: ");
string enteredNumb = Console.ReadLine();
if (enteredNumb.Length == 3)

{
string deletSecondNumber = enteredNumb.Remove(1,1);
 Console.WriteLine("Result of deleting 2 number: " + deletSecondNumber);
}
else
{
 Console.WriteLine("Это не трехзначное число!!!!");
}

*/





//task10 Выяснить, кратно ли число заданному, если нет, вывести остаток

/*

Console.WriteLine ("Введите два числа: ");
var numOne = int.Parse(Console.ReadLine());
var numTwo = int.Parse(Console.ReadLine());

if (numOne%numTwo == 0)
{
Console.WriteLine ("Первое число кратно второму.");
}
else
{
Console.WriteLine ("Первое число не кратно второму. Остаток: " + numOne % numTwo);
}

*/



//task11 Найти третью цифру числа или сообщить, что её нет

Console.WriteLine ("Введите число: ");
string findNumberThtree = Console.ReadLine();

if (findNumberThtree.Length > 2)
{
Console.WriteLine ("Третья цифра числа: "+ findNumberThtree.Substring(2,1));
}
else
{
Console.WriteLine ("В этом числе менее 3х цифр");
}