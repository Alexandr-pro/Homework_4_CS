// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();    
int NumberA, NumberB;
    Console.WriteLine("Для формулы A^B");
    Console.Write("Введите число A: ");
    NumberA = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    NumberB = Convert.ToInt32(Console.ReadLine());

        
        int result = NumberA;

            for (int i = 2; i <= NumberB; i++)
            {
                result *= NumberA;
            }

            Console.WriteLine($"{NumberA}^{NumberB} = {result}");
            
