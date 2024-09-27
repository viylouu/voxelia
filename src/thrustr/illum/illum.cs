partial class illum {
    static illumshad shad = new illumshad();

    static List<light> _l = new();

    public static void addlight(Vector2 _pos, float _rad, float _lum, ColorF _col, float _round) => _l.Add(new light() { pos = _pos, rad = _rad, lum = _lum, col = _col, rnd = _round });

    public static void draw(ICanvas c) {
        c.Fill(shad);
        shad.l = _l.ToArray();
        c.DrawRect(0,0,Window.Width,Window.Height);
    }

    public static void clearlights() => _l.Clear();
}