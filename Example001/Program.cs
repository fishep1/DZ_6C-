//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количетсво элемментов массива:\t");
        int elementsArray = int.Parse(Console.ReadLine());

        int[] MyArray = new int[elementsArray];

        for(int i = 0; i < MyArray.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексос {i}:\t");
                MyArray[i] = int.Parse(Console.ReadLine());
            }

    void ShowArray(int[] Array1) // Метод вывода значений элемментов массива на экран
            {
                Console.WriteLine("Вывод массива: ");
                for (int i = 0; i < MyArray.Length; i++)
                {
                    Console.Write($"\t{Convert.ToString(MyArray[i])}");
                }
            }
             int Integer(int[] Array2)
            {    
                int count = 0;
                for (int i = 0; i < Array2.Length; i++)
                    if (Array2[i] > 0)
                    {
                        count++;                    
                    }
                return count;
            }

            ShowArray(MyArray);
            Console.Write($"\nПользователь ввел чисел больше нуля: "+Integer(MyArray));
}
}