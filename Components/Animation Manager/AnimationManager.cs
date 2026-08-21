using Godot;
using System;
using System.Collections.Generic;

public partial class AnimationManager : Node
{
    [Export] public string StandardAnimation { get; set; }
    [Export] private AnimatedSprite2D AnimatedSprite2DNode { get; set; }

    private readonly Stack<(string animation, AudioStream? audio)> animations = new();

    public override void _Ready()
    {
        AnimatedSprite2DNode.AnimationFinished += PlayAnimation;

        PlayAnimation();
    }

    public void AddAnimation(string animation, AudioStream? audio)
    {
        animations.Push((animation, audio));

        if (AnimatedSprite2DNode.Animation == StandardAnimation)
            PlayAnimation();
    }

    private void PlayAnimation()
    {
        if (animations.Count > 0)
        {
            var animation = animations.Pop();

            AnimatedSprite2DNode.Play(animation.animation);

            if (animation.audio != null)
                Global.Instance.PlaySoundEffect(animation.audio);
        }
        else
            AnimatedSprite2DNode.Play(StandardAnimation);
    }
}
