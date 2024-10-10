partial class main {
    static void moveplayer() { 
        if(Keyboard.IsKeyDown(Key.W))
            cam -= new Vector3(math.cos(math.torad(pitch)+math.pi/2),0,math.sin(math.torad(pitch)+math.pi/2))*Time.DeltaTime*2;
        if(Keyboard.IsKeyDown(Key.S))
            cam += new Vector3(math.cos(math.torad(pitch)+math.pi/2),0,math.sin(math.torad(pitch)+math.pi/2))*Time.DeltaTime*2;
        
        if(Keyboard.IsKeyDown(Key.D))
            cam -= new Vector3(math.cos(math.torad(pitch)),0,math.sin(math.torad(pitch)))*Time.DeltaTime*2;
        if(Keyboard.IsKeyDown(Key.A))
            cam += new Vector3(math.cos(math.torad(pitch)),0,math.sin(math.torad(pitch)))*Time.DeltaTime*2;

        if(Keyboard.IsKeyDown(Key.Space))
            cam.Y -= Time.DeltaTime*2;
        if(Keyboard.IsKeyDown(Key.LeftShift))
            cam.Y += Time.DeltaTime*2;

        pitch -= (Mouse.Position.X-math.round(Window.Width/2f)*2/2f)/8;
        yaw -= (Mouse.Position.Y-math.round(Window.Height/2f)*2/2f)/8;

        yaw = math.clamp(yaw,-90,90);

        Mouse.Position = new Vector2(Window.Width/2,Window.Height/2);
    }
}