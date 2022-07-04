/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число. Введите корректное число.";

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if (result == 0)
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
            else
                break;
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }

    return result;
}

void Palindrome(string count)
{
    string message1 = "Введенное число является палиндромом";
    string message2 = "Введенное число НЕ ЯВЛЯЕТСЯ палиндромом";
    string message3 = "Введенное число НЕ пятизначное";
    if (count.Length != 5)
        Console.WriteLine(message3);    
    else  if  (count[0] == count[4] && count[1] == count[3])
            Console.WriteLine(message1);
         else
            Console.WriteLine(message2);
}


int number = GetNumber("Введите пятизначное число");

string count = Convert.ToString(number);

Palindrome(count);