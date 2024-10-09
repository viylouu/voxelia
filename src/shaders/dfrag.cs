class dfragshad : CanvasShader {
    public ITexture tex;

    [VertexShaderOutput]
    Vector2 uv;

    public override ColorF GetPixelColor(Vector2 pos) {
        return tex.SampleUV(uv);
    }
}