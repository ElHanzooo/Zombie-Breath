using Godot;
using System;

public partial class Idle : State
{
    private AnimatedSprite2D animations;

    public override void Enter()
    {
        animations = GetNode<AnimatedSprite2D>("../../Animations");

        animations.Play("Idle");
    }
}
