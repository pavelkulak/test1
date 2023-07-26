﻿// Решение в группах задач:
// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
        int[] numbers = new int[8];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(0, 2);
        }

        Console.Write("[");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i]);

            // Проверяем, является ли текущий элемент последним
            if (i < numbers.Length - 1)
            {
                Console.Write(",");
            }
        }
        Console.WriteLine("]");
