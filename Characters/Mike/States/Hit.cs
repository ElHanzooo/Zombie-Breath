using Godot;
using System;

public partial class Hit : State
{
    [Export] private AnimationManager AnimationManager { get; set; } = null!;
    
    public override void Enter() => AnimationManager.AddAnimation("Hit");
}
