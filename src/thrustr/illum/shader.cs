public class illumshad : CanvasShader {
    public light[] l;

    public override ColorF GetPixelColor(Vector2 pos) {
        ColorF col = ColorF.Black;
        Vector3 _col = MakeVector3(0,0,0);

        for(int i = 0; i < l.Length; i++) {
            float dist = Distance(pos, l[i].pos);

            if(dist <= l[i].rad) {
                float r = Max((l[i].lum*l[i].col.R+(l[i].lum-1))*(1-dist/l[i].rad),0);
                float g = Max((l[i].lum*l[i].col.G+(l[i].lum-1))*(1-dist/l[i].rad),0);
                float b = Max((l[i].lum*l[i].col.B+(l[i].lum-1))*(1-dist/l[i].rad),0);

                r = Round(r/l[i].rnd)*l[i].rnd;
                g = Round(g/(l[i].rnd*.5f))*(l[i].rnd*.5f);
                b = Round(b/l[i].rnd)*l[i].rnd;

                _col += MakeVector3(r,g,b);
            }
        }

        col = new ColorF(_col.X,_col.Y,_col.Z);

        return col;
    }
}