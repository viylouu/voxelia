class dfragshad : CanvasShader {
    public ITexture tex;

    public Vector3 cam;

    public Vector3 sun;

    // 0: textured
    // 1: normals
    // 2: depth
    // 3: uv

    public int rendermode = 0;

    [VertexShaderOutput]
    Vector2 uv;
    [VertexShaderOutput]
    Vector3 norm;
    [VertexShaderOutput]
    Vector3 vpos;

    public override ColorF GetPixelColor(Vector2 pos) {
        if(rendermode == 2)
            return new(1 - Distance(vpos, cam) / 32f, 0, 0);
        if(rendermode == 1)
            return new((norm.X+1)/2f,(norm.Y+1)/2f,(norm.Z+1)/2f);
        if(rendermode == 3)
            return new(uv.X,uv.Y,0);

        float dot = (Dot(sun,norm)+1)*.125f;

        return tex.SampleUV(uv)+new ColorF(dot,dot,dot,0);
    }
}