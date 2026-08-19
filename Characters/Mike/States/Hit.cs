using Godot;
using System;

public partial class Hit : State
{
    [Export] private State IdleState { get; set; }

    private AnimatedSprite2D animations;

    public override void _Ready()
    {
        animations = GetNode<AnimatedSprite2D>("../../Animations");

        animations.AnimationFinished += () => EmitSignal(SignalName.SwitchState, IdleState);
    }

    public override void Enter() => animations.Play("Hit");
}
