using Godot;
using System;
using System.Collections.Generic;

public partial class AnimationManager : Node
{
    [Export] public string StandardAnimation { get; set; }

    private readonly Stack<(string animation, AudioStream audio)> animations;
}
