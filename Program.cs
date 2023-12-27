using System;

class OneDimensionalArrayWorker
{
    private double[] array;

    public OneDimensionalArrayWorker(int length)
    {
        try
        {
            if (length <= 0)
            {
                throw new ArgumentException("Длина массива должна быть больше нуля.");
            }

            array = new double[length];
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
            Error();
        }
    }

    public OneDimensionalArrayWorker(double x, int length)
    {
        try
        {
            if (length <= 0)
            {
                throw new ArgumentException("Длина массива должна быть больше нуля.");
            }

            array = new double[length];

            for (int i = 0; i < length; i++)
            {
                if (x <= 0)
                {
                    throw new ArgumentException("Значение x должно быть больше нуля.");
                }

                array[i] = Math.Log(x);
                x += 1;
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
            Error();
        }
    }

    public int CountLess
    {
        get
        {
            int count = 0;
            foreach (var element in array)
            {
                if (element < 0.2)
                {
                    count++;
                }
            }
            return count;
        }
    }

    public double Sum()
    {
        double sum = 0;
        foreach (var element in array)
        {
            if (element == 0)
            {
                break;
            }
            sum += Math.Abs(element);
        }
        return sum;
    }

    private void Error()
    {
        Console.WriteLine("Произошла ошибка. Перезапуск программы...");
        System.Diagnostics.Process.Start(Environment.ProcessPath);
        Environment.Exit(0);
    }

}

class Program
{
    static void Main()
    {
        Console.WriteLine("l");
        int.TryParse(Console.ReadLine(), out int l);
        Console.WriteLine("X");
        double.TryParse(Console.ReadLine(), out double X);
        OneDimensionalArrayWorker array = new OneDimensionalArrayWorker(X, l);
        Console.WriteLine("Количество элементов меньше 0.2: " + array.CountLess);
        Console.WriteLine("Сумма модулей элементов до первого нуля: " + array.Sum());
    }
}
