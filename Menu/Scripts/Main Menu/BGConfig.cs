using Godot;
using System;

[GlobalClass]
public partial class BGConfig : Resource
{
    [Export] public NodePath ControlBackgroundPath {get; private set; }
    [Export] public Color ModulateColor {get ; private set; }
}
