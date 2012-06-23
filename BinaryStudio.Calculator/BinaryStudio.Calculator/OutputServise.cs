using System;

namespace BinaryStudio.Calculator
{
    public interface IOutputServise
    {
        void Output(object data);
    }
    public class OutputServise : IOutputServise
    {
        public void Output(object data)
        {
            Console.WriteLine(data);
        }
    }
}
