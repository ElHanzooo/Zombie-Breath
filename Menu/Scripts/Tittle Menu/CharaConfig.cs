using Godot;
using System;

[GlobalClass]
public partial class CharaConfig : Resource
{
    [Export] public Texture2D Texture { get; set; }
    [Export] public Vector2 Scale { get; set; } = new Vector2(1.7f, 1.7f);
    [Export] public Vector2 Pivot { get; set; } = default;
}
