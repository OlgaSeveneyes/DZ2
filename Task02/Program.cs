Console.Write("Введите число: ");
string? num = Console.ReadLine();
int numI;

if (int.TryParse(num, out numI))
{
  if (numI<=99)
  {
    Console.Write("Третьей цифры нет"); 
  } 
  if (numI>99 && numI<1000)
  {
    numI = numI % 10;
    Console.WriteLine(numI);
  }
  while (numI>999)
  {
    numI = numI / 10;
    if (numI>99 && numI<1000)
    {
      numI = numI % 10;
      Console.WriteLine(numI);
    }
  }
}
else
{
    Console.WriteLine("Ошибка ввода! Необходимо ввести число");
}
