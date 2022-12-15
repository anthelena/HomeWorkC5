// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// Точки для уравнений пользователь вводит с клавиатуры, можно через несколько ReadLine
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine ("k1");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("b1");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("k2");
double k2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine ("b2");
double b2=Convert.ToDouble(Console.ReadLine());
Coordinates(k1,k2,b1,b2); 

void Coordinates(double k1, double k2, double b1, double b2)
{
  double [] coordinates = new double [2]; // coordinates[0]=x; coordinates[1]=y 
  
  if (k1==k2 && b1==b2)
    {
        Console.WriteLine("Прямые совпадают. Вы ввели одинаковые координаты для обеих строк.");
        return;
    } 
  else if (k1==k2)
    {
        Console.WriteLine("Прямые паралельны.");
        return;
    }
  else
   {
       coordinates[0] = (b2-b1)/(k1-k2);
       coordinates[1] = k1*(b2-b1)/(k1-k2) + b1;
       Console.WriteLine("("+coordinates[0] + ";" + coordinates[1]+")");
   }
}
  