class dfragshad : CanvasShader {
    public ITexture tex;

    public Vector3 cam;

    [VertexShaderOutput]
    Vector2 uv;
    [VertexShaderOutput]
    Vector3 norm;
    [VertexShaderOutput]
    Vector3 vpos;

    public override ColorF GetPixelColor(Vector2 pos) {
        float dist = 1-Distance(vpos, cam)/16f;

        return new (dist,dist,dist);
    }
}