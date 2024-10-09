partial class main {
    static blockdata airdat = new() {

    };

    static blockdata plankdat = new() {
        tex = Graphics.LoadTexture(@"assets\textures\planks.png")
    };

    static blockdata stonebrickdat = new() {
        tex = Graphics.LoadTexture(@"assets\textures\stone_bricks.png")
    };

    static blockdata dirtdat = new() {
        tex = Graphics.LoadTexture(@"assets\textures\dirt.png")
    };
     
    static blockdata grassdat = new() {
        tex = Graphics.LoadTexture(@"assets\textures\grass.png")
    };

    static blockdata[] blockdats = { 
        airdat,
        plankdat,
        stonebrickdat,
        dirtdat,
        grassdat
    };
}