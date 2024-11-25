using System;

public class ArrayOperations
{
   

    // Метод сортировки массива по возрастанию
    public static void a1(int[] a)  
    {
        Array.Sort(a); // Используем  метод Array.Sort для сортировки на месте.  
    }

    // Метод сортировки массива по убыванию
    public static void b1(int[] a)   
    {
        Array.Sort(a);
        Array.Reverse(a); // Используем Array.Reverse  для инвертирования порядка элементов.

    }

    // Метод объединения двух массивов в один
    public static int[] c1(int[] a, int[] b) 
    {
        Lazy<int> d = new Lazy<int>(() => a.Length + b.Length);//определяет то, что нужно вычислить, когда значение d будет запрошено. 
        int[] c = new int[d.Value]; //Здесь  получается  значение  объекта
        Array.Copy(a, c, a.Length); // Используем Array.Copy для массивов
        Array.Copy(b, 0, c, a.Length, b.Length); // Используем Array.Copy для массивов
        return c;
    }
    public static int Ca(int n)
    {
        int di = Math.Abs(n - 123); // Вычисляем абсолютную разность

        if (n > 123)
        {
            return di * 3; // Тройная разность, если n > 123
        }
        else
        {
            return di; // Обычная разность
        }
    }

    public static void Main()
    {
        Console.Write("Выберите задание, 1 или 2: \t");
        string zad = Console.ReadLine();
        if (zad == "2")
        {
            Console.Write("Введите количество элементов массива 1: \t");
            int aelement = int.Parse(Console.ReadLine());
            int[] a = new int[aelement];

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"\n Введите {i} элемент масива: \t ");
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Введите количество элементов массива 2: \t");
            int belement = int.Parse(Console.ReadLine());
            int[] b = new int[belement];
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write($"\n Введите {i} элемент масива: \t ");
                b[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Исходный массив a:");
            Console.WriteLine(string.Join(", ", a));
            Console.WriteLine("Исходный массив b:");
            Console.WriteLine(string.Join(", ", b));
            a1(a);
            Console.WriteLine("\n Отсортированный по возрастанию массив a:");
            Console.WriteLine(string.Join(", ", a));

            b1(a);
            Console.WriteLine("\n Отсортированный по убыванию массив a:");
            Console.WriteLine(string.Join(", ", a));

            int[] c = c1(a, b);
            Console.WriteLine("\n Объединенный массив c:");
            Console.WriteLine(string.Join(", ", c));
        }
        if (zad == "1")
        {
            Console.WriteLine("Введите целое число:");
    string n1 = Console.ReadLine();

    if (int.TryParse(n1, out int number)) //проверка на тип вводимых данных 
    {
      int result = Ca(number);
      Console.WriteLine($"Результат: {result}");
    }
    else
    {
      Console.WriteLine("Некорректный ввод.");
    }
        }
    }
    
}

