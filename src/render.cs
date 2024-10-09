partial class main {
    static void rend(ICanvas c) {
        c.Clear(Color.Black);

        //if (!intro.introplayed)
        //{ intro.dointro(c, dfont); return; }

        depth.Clear(1);

        c.Mask(depth);
        c.WriteMask(depth);

        dfrag.tex = blockdats[blocks[0,0,0].type].tex;

        dvert.model = Matrix4x4.CreateRotationY(Time.TotalTime*math.torad(60));
        dvert.view = Matrix4x4.CreateLookAtLeftHanded(Vector3.One,Vector3.Zero,Vector3.UnitY);
        dvert.proj = Matrix4x4.CreatePerspectiveFieldOfViewLeftHanded(math.torad(fov),c.Width/(float)c.Height,.1f,100f);

        c.Fill(dfrag,dvert);
        c.DrawTriangles<vert>(cube);

        fontie.rendertext(c, dfont, $"{MathF.Round(1/Time.DeltaTime)} fps", 3,3, ColorF.White);
    }
}