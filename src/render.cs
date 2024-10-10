using System.Xml.Serialization;

partial class main {
    static void rend(ICanvas c) {
        c.Clear(Color.Black);

        //if (!intro.introplayed)
        //{ intro.dointro(c, dfont); return; }

        //  controls

        if(Keyboard.IsKeyPressed(Key.Escape))
            Environment.Exit(0);

        moveplayer();

        //  render

        render3D(c, 0);

        fontie.rendertext(c, dfont, $"{MathF.Round(1/Time.DeltaTime)} fps", 3,3, ColorF.White);
    }

    static void render3D(ICanvas c, int rendermode) {
        depth.Clear(1);

        c.Mask(depth);
        c.WriteMask(depth);

        dfrag.rendermode = rendermode;

        dfrag.cam = -cam;

        dfrag.sun = new Vector3(1,-1,1).Normalized();

        for(int x = 0; x < blocks.GetLength(0); x++)
            for(int y = 0; y < blocks.GetLength(1); y++)
            for(int z = 0; z < blocks.GetLength(2); z++)
            if(blocks[x,y,z].type!=0)
            if(renderblock(x,y,z)) {
                dfrag.tex = blockdats[blocks[x,y,z].type].tex;
        
                dvert.cubepos = new Vector3(x,y,z);
                dvert.model = Matrix4x4.CreateTranslation(x,y,z);
                dvert.view = Matrix4x4.CreateTranslation(cam) * Matrix4x4.CreateRotationY(math.torad(pitch)) * Matrix4x4.CreateRotationX(math.torad(yaw));
                dvert.proj = Matrix4x4.CreatePerspectiveFieldOfViewLeftHanded(math.torad(fov),c.Width/(float)c.Height,.1f,100f);

                c.Fill(dfrag,dvert);
                c.DrawGeometry(cube);
            }
    }

    static bool renderblock(int x, int y, int z) { 
        if(x==0||y==0||z==0||x==blocks.GetLength(0)-1||y==blocks.GetLength(1)-1||z==blocks.GetLength(2)-1)
            return true;

        if(!blockdats[blocks[x-1,y,z].type].opaque)
            return true;

        if(!blockdats[blocks[x+1,y,z].type].opaque)
            return true;

        if(!blockdats[blocks[x,y-1,z].type].opaque)
            return true;

        if(!blockdats[blocks[x,y+1,z].type].opaque)
            return true;

        if(!blockdats[blocks[x,y,z-1].type].opaque)
            return true;

        if(!blockdats[blocks[x,y,z+1].type].opaque)
            return true;

        return false;
    }
}