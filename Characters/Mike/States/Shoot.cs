using Godot;
using System;

public partial class Shoot : State
{
    [Export] private Mike Mike { get; set; } = null!;

    [Export] private AnimationManager AnimationManager { get; set; } = null!;

    [ExportGroup("States")]
    [Export] private State IdleState { get; set; } = null!;

    public override void _Ready()
    {
        var animatedSprite2D = Mike.GetNode<AnimatedSprite2D>("Animations");

        animatedSprite2D.AnimationFinished += () => EmitSignal(SignalName.SwitchState, IdleState);
    }

    public override void Enter() => AnimationManager.AddAnimation("Shoot", GD.Load<AudioStream>("res://Characters/Mike/Assets/Sound Effects/Shoot.ogg"));
}
