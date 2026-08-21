using Godot;
using System;

public partial class Shoot : State
{
    [Export] private AnimationManager AnimationManager { get; set; } = null!;
    
    public override void Enter() => AnimationManager.AddAnimation("Shoot", GD.Load<AudioStream>("res://Characters/Mike/Assets/Sound Effects/Shoot.ogg"));
}
