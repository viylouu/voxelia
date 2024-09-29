partial class main {
    static void init() {
        Simulation.SetFixedResolution(320, 180, Color.Black);

        dfonttex = Graphics.LoadTexture(@"assets\fonts\font.png");
        dfont = fontie.genfont(dfonttex, " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz");

        intro.loadintro();
        intro.playintro();
    }
}