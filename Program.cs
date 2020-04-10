using System;
using DZ_IRecodableSpace;
using DZ_IPlayableSpace;
using DZ_PlayerSpace;

namespace DZ20200409
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                • Задание 3
                    A. Создайте проект по шаблону Console Application.
                        1. Требуется:
                            • Создайте 2 интерфейса IPlayable и IRecodable. В каждом из
                            интерфейсов создайте по 3 метода:
                                IPlayable:
                                    o void Play() / void Pause() / void Stop()
                                IRecodable:
                                    o void Record() / void Pause() / void Stop()
                            • Создайте производный класс Player от базовых интерфейсов IPlayable
                              и IRecodable.
                            • Написать программу, которая выводит на экран текст действия.
            */
                System.Console.WriteLine("Select interface | Выберите интерфейс");
                System.Console.WriteLine("1 IPlayable | Воспроизводимый интерфейс");
                System.Console.Write("2 IRecodable | Записываемый интерфейс\n");
                System.Console.Write("Your choice | Ваш выбор: ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("You are on the IPlayable | Вы на интерфейсе воспроизведения");
                    System.Console.WriteLine("Select an action | Выберите действие:\n1 Play\n2 Pause\n3 Stop");
                    System.Console.Write("Your choice | Ваш выбор: ");
                    int ch = int.Parse(Console.ReadLine());
                    if(ch == 1)
                    {
                        System.Console.WriteLine();
                        Player play = new Player();
                        play.Play();
                    }
                    if(ch == 2)
                    {
                        System.Console.WriteLine();
                        Player pause = new Player();
                        pause.Pause();
                    }
                    if(ch == 3)
                    {
                        System.Console.WriteLine();
                        Player stop = new Player();
                        stop.Stop();
                    }
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine();
                    System.Console.WriteLine("You are on the IRecodable | Вы на интерфейсе записывания");
                    System.Console.WriteLine("Select an action | Выберите действие:\n1 Record\n2 Pause\n3 Stop");
                    System.Console.Write("Your choice | Ваш выбор: ");
                    int ch = int.Parse(Console.ReadLine());
                    if(ch == 1)
                    {
                        System.Console.WriteLine();
                        Player record = new Player();
                        record.Record();
                    }
                    if(ch == 2)
                    {
                        System.Console.WriteLine();
                        Player pause = new Player();
                        pause.Pause();
                    }
                    if(ch == 3)
                    {
                        System.Console.WriteLine();
                        Player stop = new Player();
                        stop.Stop();
                    }
                    break;
                }
                default:
                {
                    System.Console.WriteLine("ERROR !!!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
