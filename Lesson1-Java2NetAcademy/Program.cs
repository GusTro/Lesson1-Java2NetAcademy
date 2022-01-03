using System;
using System.Text;

namespace Lesson1_Java2NetAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 20000;
            StringBuilder builder = new StringBuilder();
            builder.Append("Somos más de ");
            builder.Append(cantidad);
            builder.Append(" globers en el mundo");
            Console.WriteLine(builder);
        }
    }
}
