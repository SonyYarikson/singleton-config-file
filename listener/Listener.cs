using System;

namespace listener
{
    internal class Listener : IObserver
    {
        public void update(string change)
        {
            if (change != "")
            {
                Console.WriteLine("Продюсер изменил файл! Новая строка: " + change);
            }
        }
    }
}
