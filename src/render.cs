partial class main {
    static void rend(ICanvas c) {
        c.Clear(Color.Black);

        illum.addlight(Mouse.Position, Window.Height/2, 1, ColorF.Red, 1, false);
        illum.addlight(new Vector2(Window.Width,Window.Height)-Mouse.Position, Window.Height / 2, 1, ColorF.Green, 1, false);

        illum.addobj(new Vector2(Window.Width/2, Window.Height/16), new Vector2(Window.Width/2+Window.Width/16,Window.Height/8+Window.Height/16), new Vector2(Window.Width/2-Window.Width/16,Window.Height/8+Window.Height/16));

        illum.draw(c);

        illum.clearscene();

        c.Fill(Color.White);

        c.DrawAlignedText($"{MathF.Round(1/Time.DeltaTime)} fps", 32, 3,3, Alignment.TopLeft);
    }
}