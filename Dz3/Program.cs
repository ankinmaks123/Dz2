// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите номер дня недели!");
int aboba = Console.Read(); 
while (true)
    {if (aboba>5 && aboba < 7) {
        Console.WriteLine("Выходной");}
    else if (aboba >7)
       { Console.WriteLine("Введите цифру от 1 до 7");}
    else
        {Console.WriteLine("Это рабочий деь");
        }
    
        break;
    }
    Console.WriteLine ("Exit");