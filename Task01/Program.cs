Console.Write("Введите трехзначное число: ");
string? num = Console.ReadLine();
int numI;

if (int.TryParse(num, out numI))
{
    if (numI <= 99)
    {
        Console.WriteLine("Ошибка ввода! Введите трехзначное число: ");  
    }
    else if (numI > 999)
    {
        Console.WriteLine("Ошибка ввода! Введите трехзначное число: ");
    }
    else
    {
        numI = numI / 10;
        numI = numI % 10;    
        Console.WriteLine(numI); 
    }
}
else
{
    Console.WriteLine("Ошибка ввода! Необходимо ввести число");
} 