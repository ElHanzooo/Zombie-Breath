using Godot;
using System;

public partial class Global : Node
{
    public static Global Instance { get; private set; }

    public override void _Ready() => Instance = this;
}
