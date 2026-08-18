using Godot;
using System;

public partial class Idle : State
{
    [Export] private State ShootState { get; set; }

    private AnimatedSprite2D animations;

    public override void _Ready() => animations = GetNode<AnimatedSprite2D>("../../Animations");

    public override void Enter() => animations.Play("Idle");

    public override void Update(double delta)
    {
        if (Input.IsActionJustPressed("Shoot"))
            EmitSignal(SignalName.SwitchState, ShootState);
    }
}
