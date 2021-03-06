﻿using EasterRace.IO.Contracts;

namespace EasterRace.IO.ConsoleApplication
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string text)
        {
            System.Console.Write(text);
        }

        public void WriteLine(string text)
        {
            System.Console.WriteLine(text);
        }
    }
}
