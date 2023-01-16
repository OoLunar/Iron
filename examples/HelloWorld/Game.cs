using System;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Color = System.Drawing.Color;

namespace Iron.Examples.HelloWorld;

public sealed class Game : IronGame
{
    private GL _openGlContext = null!;

    public Game(WindowOptions? windowOptions = null) : base(windowOptions) { }

    public override void Start()
    {
        Console.WriteLine("Game has started!");
        _openGlContext = GameWindow.CreateOpenGL();
    }

    public override void RenderFrame(double currentFrame)
    {
        _openGlContext.ClearColor(Color.AliceBlue);
        _openGlContext.Clear(ClearBufferMask.ColorBufferBit);
    }

    public override void Stop()
    {
        GameWindow.Close();
    }
}