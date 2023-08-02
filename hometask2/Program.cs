Console.WriteLine("Add fisrt number");
 int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add second number");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 > number2)
{
    Console.WriteLine("Max = first");
   Console.WriteLine("Min = second");
}
 if (number1 < number2)
{
  Console.WriteLine("Max = second");
  Console.WriteLine("Min = first");
}