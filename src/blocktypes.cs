partial class main {
    static blockdata airdat = new() {
        opaque = false
    };

    static blockdata plankdat = new() {
        tex = Graphics.LoadTexture(@"assets\textures\planks.png"),
        opaque = true
    };

    static blockdata stonebrickdat = new() {
        tex = Graphics.LoadTexture(@"assets\textures\stone_bricks.png"),
        opaque = true
    };

    static blockdata dirtdat = new() {
        tex = Graphics.LoadTexture(@"assets\textures\dirt.png"),
        opaque = true
    };
     
    static blockdata grassdat = new() {
        tex = Graphics.LoadTexture(@"assets\textures\grass.png"),
        opaque = true
    };

    static blockdata[] blockdats = { 
        airdat,
        plankdat,
        stonebrickdat,
        dirtdat,
        grassdat
    };
}