using Godot;
using System;

[GlobalClass]
public partial class StageConfig : Resource
{
    [Export] public Texture2D Thumbnail { get; private set; }
    [Export] public int Act { get; private set; } = 1;
    //[Export] public Episodes Episode { get; private set; }
}
