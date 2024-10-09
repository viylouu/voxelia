﻿partial class main {
    static void init() {
        Simulation.SetFixedResolution(480,270, Color.Black);

        dfonttex = Graphics.LoadTexture(@"assets\fonts\font.png");
        dfont = fontie.genfont(dfonttex, " !\"#$%&'()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[\\]^_`abcdefghijklmnopqrstuvwxyz");

        intro.loadintro();
        intro.playintro();

        Window.SetIcon(Graphics.LoadTexture(@"assets\thrustr\logos\engine small.png"));

        Window.Title = "voxelia";

        depth = Graphics.CreateDepthMask(640,360);

        r = new();

        genmap();
    }
}