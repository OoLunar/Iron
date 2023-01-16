using Silk.NET.Windowing;

namespace Iron
{
    public abstract class IronGame
    {
        public readonly IWindow GameWindow;
        
        protected IronGame(WindowOptions? windowOptions)
        {
            windowOptions ??= WindowOptions.Default;

            GameWindow = Window.Create(windowOptions.Value);
            GameWindow.Load += Start;
            GameWindow.Render += RenderFrame;
            GameWindow.Closing += Stop;
        }

        public abstract void Start();
        public abstract void RenderFrame(double currentFrame);
        public abstract void Stop();
    }
}


