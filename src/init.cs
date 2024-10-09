partial class main {
    static void init() {
        Simulation.SetFixedResolution(640,360, Color.Black);

        dfonttex = Graphics.LoadTexture(@"assets\fonts\font.png");
        dfont = fontie.genfont(dfonttex, " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz");

        intro.loadintro();
        intro.playintro();

        Window.SetIcon(Graphics.LoadTexture(@"assets\thrustr\logos\engine small.png"));

        Window.Title = "voxelia";

        depth = Graphics.CreateDepthMask(640,360);

        blocks = new block[1,1,1];

        blocks[0,0,0] = new block() { type = 0 };
    }
}