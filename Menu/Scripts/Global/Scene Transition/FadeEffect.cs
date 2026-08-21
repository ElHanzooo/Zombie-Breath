using Godot;
using System;
using System.Threading.Tasks;

public partial class FadeEffect : ColorRect, ISceneTransition
{
    [Export] private float Duration = 0.5f;

    public async Task PlayIn()
    {
        var _tween = CreateTween();
        _tween.TweenProperty(this, "modulate:a", 1f, Duration);
        await ToSignal(_tween, "finished");
    }

    public async Task PlayOut()
    {
        var _tween = CreateTween();
        _tween.TweenProperty(this, "modulate:a", 0f, Duration);
        await ToSignal(_tween, "finished");
    }
}
