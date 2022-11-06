/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


    Console.WriteLine("Введите пятизначное число");
    int number = int.Parse(Console.ReadLine() ??"");
    Console.WriteLine();
    
    if(number < 100000 && number > 9999)
     
        
       Console.Write($" Число {number} ");
    else
    {
        Console.WriteLine("Введено не пятизначное число. Попробуйте еще раз))");
        return;
    }   
    string numberAsString = number.ToString();
    int indexNULL = int.Parse(numberAsString[0].ToString());
    int indexFIRST = int.Parse(numberAsString[1].ToString());
    int indexSECOND = int.Parse(numberAsString[2].ToString());
    int indexTHIRD = int.Parse(numberAsString[3].ToString());
    int indexFORTH = int.Parse(numberAsString[4].ToString());
    if (indexNULL ==  indexFORTH && indexFIRST == indexTHIRD)
        Console.WriteLine("   ЯВЛЯЕТСЯ ПАЛИАНДРОМ");
    else
    {
        Console.WriteLine("   НЕ ЯВЛЯЕТСЯ ПАЛИНДРОМОМ.");
        return;
    }
    