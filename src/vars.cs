partial class main {
    static font dfont;
    static ITexture dfonttex;

    static dithergradient grad = new();

    static vert[] cube = [
        new (new(-0.5f, -0.5f, -0.5f), new(0.0f, 0.0f)),
        new (new(0.5f, -0.5f, -0.5f), new(1.0f, 0.0f)),
        new (new(0.5f, 0.5f, -0.5f), new(1.0f, 1.0f)),
        new (new(0.5f, 0.5f, -0.5f), new(1.0f, 1.0f)),
        new (new(-0.5f, 0.5f, -0.5f), new(0.0f, 1.0f)),
        new (new(-0.5f, -0.5f, -0.5f), new(0.0f, 0.0f)),
        new (new(-0.5f, -0.5f, 0.5f), new(0.0f, 0.0f)),
        new (new(0.5f, -0.5f, 0.5f), new(1.0f, 0.0f)),
        new (new(0.5f, 0.5f, 0.5f), new(1.0f, 1.0f)),
        new (new(0.5f, 0.5f, 0.5f), new(1.0f, 1.0f)),
        new (new(-0.5f, 0.5f, 0.5f), new(0.0f, 1.0f)),
        new (new(-0.5f, -0.5f, 0.5f), new(0.0f, 0.0f)),
        new (new(-0.5f, 0.5f, 0.5f), new(1.0f, 0.0f)),
        new (new(-0.5f, 0.5f, -0.5f), new(1.0f, 1.0f)),
        new (new(-0.5f, -0.5f, -0.5f), new(0.0f, 1.0f)),
        new (new(-0.5f, -0.5f, -0.5f), new(0.0f, 1.0f)),
        new (new(-0.5f, -0.5f, 0.5f), new(0.0f, 0.0f)),
        new (new(-0.5f, 0.5f, 0.5f), new(1.0f, 0.0f)),
        new (new(0.5f, 0.5f, 0.5f), new(1.0f, 0.0f)),
        new (new(0.5f, 0.5f, -0.5f), new(1.0f, 1.0f)),
        new (new(0.5f, -0.5f, -0.5f), new(0.0f, 1.0f)),
        new (new(0.5f, -0.5f, -0.5f), new(0.0f, 1.0f)),
        new (new(0.5f, -0.5f, 0.5f), new(0.0f, 0.0f)),
        new (new(0.5f, 0.5f, 0.5f), new(1.0f, 0.0f)),
        new (new(-0.5f, -0.5f, -0.5f), new(0.0f, 1.0f)),
        new (new(0.5f, -0.5f, -0.5f), new(1.0f, 1.0f)),
        new (new(0.5f, -0.5f, 0.5f), new(1.0f, 0.0f)),
        new (new(0.5f, -0.5f, 0.5f), new(1.0f, 0.0f)),
        new (new(-0.5f, -0.5f, 0.5f), new(0.0f, 0.0f)),
        new (new(-0.5f, -0.5f, -0.5f), new(0.0f, 1.0f)),
        new (new(-0.5f, 0.5f, -0.5f), new(0.0f, 1.0f)),
        new (new(0.5f, 0.5f, -0.5f), new(1.0f, 1.0f)),
        new (new(0.5f, 0.5f, 0.5f), new(1.0f, 0.0f)),
        new (new(0.5f, 0.5f, 0.5f), new(1.0f, 0.0f)),
        new (new(-0.5f, 0.5f, 0.5f), new(0.0f, 0.0f)),
        new (new(-0.5f, 0.5f, -0.5f), new(0.0f, 1.0f))
    ];

    //render stuff
    static IDepthMask depth;

    static dfragshad dfrag = new();
    static dvertshad dvert = new();

    //render settings
    static float fov = 94;
    
    static block[,,] blocks;
}