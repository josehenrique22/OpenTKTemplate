using System;
using OpenTK.Windowing.Desktop;

namespace OpenTkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}