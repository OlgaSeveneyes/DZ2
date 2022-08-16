Console.Write("Введите число от 1 до 7: ");
string? num = Console.ReadLine();
int numI;

if (int.TryParse(num, out numI))
{
    if (numI>0 && numI<=5)
    {   
        Console.WriteLine("Нет");  
    } 
    else if (numI>5 && numI<=7)
    {
       Console.WriteLine("Да"); 
    }
    else if (numI>7)
    {
        Console.WriteLine("Ошибка ввода! Необходимо ввести число от 1 до 7");
    }
}
else
{
    Console.WriteLine("Ошибка ввода! Необходимо ввести число от 1 до 7");
} 
