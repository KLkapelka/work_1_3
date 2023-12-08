// Добавляйте новые элементы в список до тех пор, пока пользователь не отправит пустую строку.
// Выведите в консоль самый короткий и самый длинный элементы списка.

using System;
using System.Collections.Generic; 
class work_1_3
{
    static void Main()
    {
        List<string> array = new List<string>(); 
        
        while (true) 
        {
            Console.Write("Введите число: "); 
            string data = Console.ReadLine(); 
            if (string.IsNullOrEmpty(data)) 
            {
                break; 
            }
            array.Add(data); 
        }
        
        string shortest = array[0]; 
        string longest = array[0]; 
        for (int i = 0; i < array.Count; i++)
        {
            if (array[i].Length < shortest.Length) 
            {
                shortest = array[i]; 
            }

            if (array[i].Length > longest.Length) 
            {
                longest = array[i]; 
            }
        }
        
        var str = string.Join(" ", array); 
        Console.WriteLine(str); 
        Console.WriteLine($"Самый короткий элемент: {shortest} \t Самый длинный элемент: {longest}"); s
    }
}
