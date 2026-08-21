using Godot;
using System;

public partial class Reloading : State
{
    [Export] private AnimationManager AnimationManager { get; set; } = null!;
    
    public override void Enter() => AnimationManager.AddAnimation("Reloading", GD.Load<AudioStream>("res://Characters/Mike/Assets/Sound Effects/Reloading.ogg"));
}
