
Console.WriteLine("Введите 3 цифры!");
while(true)
    {string koleso =Console.ReadLine();
        if  (koleso [2] > -1)
            Console.WriteLine("{0}вот третья =>{1}",koleso,koleso [2]);
        else 
            Console.WriteLine("3 цифры нет");
            break;
            
        }
Console.WriteLine("Exit");