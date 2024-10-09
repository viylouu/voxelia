class dvertshad : VertexShader {
    [VertexData]
    vert _vert;

    public Matrix4x4 model;
    public Matrix4x4 view;
    public Matrix4x4 proj;

    [VertexShaderOutput]
    Vector2 uv;

    [UseClipSpace]
    public override Vector4 GetVertexPosition() {
        Vector4 res = new(_vert.pos, 1);
        res = Vector4.Transform(res, model);
        res = Vector4.Transform(res, view);
        res = Vector4.Transform(res, proj);
        uv = new(_vert.tex.X,_vert.tex.Y);
        return res;
    }
}