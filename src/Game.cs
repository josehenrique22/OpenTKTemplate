using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;

namespace OpenTkTemplate
{
    public class Game : GameWindow
    {

        public Game(int width = 800, int height = 600, string title = "BasicOpenTK")
            : base(
                GameWindowSettings.Default,
                new NativeWindowSettings()
                {
                    ClientSize = (width, height),
                    Title = title,
                })
        {
            this.CenterWindow();
        }

        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);

            if (KeyboardState.IsKeyDown(Keys.Escape))
            {
                Close();
            }
        }

    }
}