partial class main {
    static font dfont;
    static ITexture dfonttex;

    static dithergradient grad = new();

    static vert[] cubeverts = [
        //front
        new (new(-0.5f, -0.5f, -0.5f), new(0,1), new(0,0,-1)),
        new (new(0.5f, -0.5f, -0.5f), new(1,1), new(0,0,-1)),
        new (new(-0.5f, 0.5f, -0.5f), new(0,0), new(0,0,-1)),
        new (new(0.5f, 0.5f, -0.5f), new(1,0), new(0,0,-1)),
        //right
        new (new(0.5f, 0.5f, -0.5f), new(0,0), new(1,0,0)),
        new (new(0.5f, -0.5f, -0.5f), new(0,1), new(1,0,0)),
        new (new(0.5f, -0.5f, 0.5f), new(1,1), new(1,0,0)),
        new (new(0.5f, 0.5f, 0.5f), new(1,0), new(1,0,0)),
        //back
        new (new(-0.5f, -0.5f, 0.5f), new(1,1), new(0,0,1)),
        new (new(0.5f, -0.5f, 0.5f), new(0,1), new(0,0,1)),
        new (new(-0.5f, 0.5f, 0.5f), new(1,0), new(0,0,1)),
        new (new(0.5f, 0.5f, 0.5f), new(0,0), new(0,0,1)),
        //left
        new (new(-0.5f, 0.5f, -0.5f), new(1,0), new(-1,0,0)),
        new (new(-0.5f, -0.5f, -0.5f), new(1,1), new(-1,0,0)),
        new (new(-0.5f, -0.5f, 0.5f), new(0,1), new(-1,0,0)),
        new (new(-0.5f, 0.5f, 0.5f), new(0,0), new(-1,0,0)),
        //up
        new (new(-0.5f, 0.5f, -0.5f), new(0,0), new(0,1,0)),
        new (new(0.5f, 0.5f, -0.5f), new(1,0), new(0,1,0)),
        new (new(-0.5f, 0.5f, 0.5f), new(0,1), new(0,1,0)),
        new (new(0.5f, 0.5f, 0.5f), new(1,1), new(0,1,0)),
        //down
        new (new(-0.5f, -0.5f, -0.5f), new(0,0), new(0,-1,0)),
        new (new(0.5f, -0.5f, -0.5f), new(1,0), new(0,-1,0)),
        new (new(-0.5f, -0.5f, 0.5f), new(0,1), new(0,-1,0)),
        new (new(0.5f, -0.5f, 0.5f), new(1,1), new(0,-1,0))
    ];

    static uint[] cubeinds = [
        0,1,2, //front
        3,1,2,

        4,5,6, //right
        7,6,4,

        8,9,10, //back
        11,9,10,

        12,13,14, //left
        15,14,12,

        16,17,18, //up
        19,17,18,

        20,21,22, //down
        23,21,22
    ];

    static IGeometry cube;
 
    //render stuff
    static IDepthMask depth;

    static dfragshad dfrag = new();
    static dvertshad dvert = new();

    static float fov = 94;

    static Vector3 cam = new Vector3(0,0,1);
    static float pitch, yaw;

    //controls
    static bool focused = false;

    //map
    static FastNoiseLite noise;

    static Random r;

    static block[,,] blocks;
}