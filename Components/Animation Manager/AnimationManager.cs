using Godot;
using System;
using System.Collections.Generic;

public partial class AnimationManager : Node
{
    [Export] public string StandardAnimation { get; set; }
    [Export] private AnimatedSprite2D AnimatedSprite2DNode { get; set; }

    private readonly Stack<(string animation, AudioStream audio)> animations;

    public void AddAnimation(string animation, AudioStream audio) => animations.Push((animation, audio));

    private void PlayAnimation()
    {
        var animation = animations.Pop();

        if (animations.Count > 0)
            AnimatedSprite2DNode.Play(animation.animation);
        else
            AnimatedSprite2DNode.Play(StandardAnimation);
    }
}
