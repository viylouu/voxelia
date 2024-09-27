partial class main {
    static void rend(ICanvas c) {
        c.Clear(Color.Black);

        illum.addlight(new Vector2(Window.Width/2,Window.Height/2), Window.Height/4, 1, ColorF.Red, .125f);
        illum.addlight(new Vector2(Mouse.Position.X, Window.Height/2), Window.Height / 4, 1, ColorF.Green, .125f);
        illum.addlight(new Vector2(Window.Width-Mouse.Position.X, Window.Height/2), Window.Height / 4, 1, ColorF.Blue, .125f);

        illum.draw(c);

        illum.clearlights();

        c.Fill(Color.White);

        c.DrawAlignedText($"{MathF.Round(1/Time.DeltaTime)} fps", 32, 3,3, Alignment.TopLeft);
    }
}