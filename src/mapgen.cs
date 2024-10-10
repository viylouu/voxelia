partial class main {
    static void genmap() {
        noise = new();
        noise.SetSeed(r.Next(int.MinValue,int.MaxValue));
        noise.SetFrequency(.05f);

        blocks = new block[16,16,16];

        for(int x = 0; x < blocks.GetLength(0); x++)
            for(int y = 0; y < blocks.GetLength(1); y++)
                for(int z = 0; z < blocks.GetLength(2); z++)
                    blocks[x,y,z].type = (byte)(noise.GetNoise(x,y,z)>=0?2:0);
    }
}