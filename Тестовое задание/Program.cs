using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graphs = new Graph();
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("1. Добавить новый узел");
                Console.WriteLine("2. Связать узлы (union)");
                Console.WriteLine("3. Проверить связность (find)");
                Console.WriteLine("4. Вывести все узлы и их соседские связи");
                Console.WriteLine("0. Закончить работу");
                Console.Write("\nВыберете действие > ");
                var action = Console.ReadKey();

                switch (action.KeyChar)
                {
                    case '1':
                        try
                        {
                            Console.Write("\nВведите значение нового узла > ");
                            var input = Console.ReadLine();
                            int nodeValue = Int32.Parse(input);
                            Console.WriteLine(graphs.AddNode(nodeValue)
                                ? "\nОперация прошла успешно!"
                                : "\nУзел со значением %i уже существует!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case '2':
                        try
                        {
                            Console.Write("\nВведите значение первого узла > ");
                            int firstNode = Int32.Parse(Console.ReadLine());
                            Console.Write("Введите значение второго узла > ");
                            int secondNode = Int32.Parse(Console.ReadLine());
                            switch (graphs.Union(firstNode, secondNode))
                            {
                                case 0:
                                    Console.WriteLine("Операция выполнена успешно!");
                                    break;
                                case 1:
                                    Console.WriteLine("Узлы сущестуют и они уже связаны!");
                                    break;
                                case -1:
                                    Console.WriteLine("Ошибка! Как минимум одного из узлов с введенным значением не существует!");
                                    break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case '3':
                        try
                        {
                            Console.Write("\nВведите значение первого узла > ");
                            int firstNode = Int32.Parse(Console.ReadLine());
                            Console.Write("Введите значение второго узла > ");
                            int secondNode = Int32.Parse(Console.ReadLine());

                            Console.WriteLine(graphs.Find(firstNode, secondNode) 
                                ? "Данные узлы объединены!" 
                                : "Узлы не объединены!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case '4':
                        break;
                    case '0':
                        break;
                    default:
                        Console.WriteLine("\nКоманда не определена!");
                        break;
                }
                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
