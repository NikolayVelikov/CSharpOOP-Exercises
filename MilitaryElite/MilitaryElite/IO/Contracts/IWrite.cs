﻿namespace MilitaryElite.IO.Contracts
{
    public interface IWrite
    {
        void Write(string text);
        void WriteLine(string text);
        public void WriteLineGeneral(string text);
    }
}
