class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите размер массива");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];

        FillArray(ref array);
        int[] pairs = MultiplyPairs(array);
        Console.WriteLine(NicePrint(pairs));
    }

    static void FillArray(ref int[] array)
    {
        Console.WriteLine("Введите элементы массива");

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
    }

    static int[] MultiplyPairs(int[] array)
    {
        int[] pairs = new int[array.Length / 2];
        for (int i = 0; i < pairs.Length; i++)
        {
            pairs[i] = array[i] * array[array.Length - 1 - i];
        }

        return pairs;
    }

    static string NicePrint(int[] array)
    {
        return $"Умноженные пары: {String.Join(", ", array)}";
    }
}
