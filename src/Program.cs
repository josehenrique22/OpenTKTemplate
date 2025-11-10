using System;
using OpenTK.Windowing.Desktop;
using OpenTkGraphic;

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
