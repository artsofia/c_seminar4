namespace tasks;
class Program
{
    static void Main(string[] args)
    {
        int Input(string text)
        {
            Console.Write(text);
            return Convert.ToInt32(Console.ReadLine());
        }


        void Task25()
        {
            // Используя определение степени числа, напишите цикл, который принимает
            // на вход два натуральных числа (A и B) и возводит число A в степень B.

            int numA = Input("Введите число A: ");
            int numB = Input("Введите число B: ");
            int exp = numA;

            for (int i = 1; i < numB; i++)
            {
                numA = numA * exp;
            }
            Console.WriteLine($"Число {exp} в степени {numB} = {numA}");
        }


        void Task27()
        {
            // Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

            int num = Input("Введите число: ");
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine($"Сумма цифр в числе: {sum}");
        }


        void Task29()
        {
            // Напишите программу, которая задаёт массив из 8 случайных
            // целых чисел и выводит отсортированный по модулю массив.

            Random rnd = new Random();

            int size = 8;
            int[] numbers = new int[size];

            // Добавляем в массив 8 случайных чисел
            for (int i = 0; i < size; i++)
            {
                numbers[i] = rnd.Next(-100, 100);
            }

            // Сортируем массив по модулю 
            for (int i = 0; i < size - 1; i++)
            {
                int minPosition = i;

                for (int j = i + 1; j < size; j++)
                {
                    if (Math.Abs(numbers[j]) < Math.Abs(numbers[minPosition])) minPosition = j;
                }

                int temporary = numbers[i];
                numbers[i] = numbers[minPosition];
                numbers[minPosition] = temporary;
            }

            // Выводим отсортированный массив
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }

        // Проверка кода 
        Console.Clear();
        int task = Input("Введите номер задачи: ");
        switch (task)
        {
            case 25:
                Task25();
                break;
            case 27:
                Task27();
                break;
            case 29:
                Task29();
                break;
            default:
                Console.WriteLine("Ошибка ввода");
                break;
        }
    }
}
