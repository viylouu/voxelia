class dfragshad : CanvasShader {
    [VertexShaderOutput]
    Vector2 uv;

    public override ColorF GetPixelColor(Vector2 pos) {
        return new(uv.X,uv.Y,0);
    }
}