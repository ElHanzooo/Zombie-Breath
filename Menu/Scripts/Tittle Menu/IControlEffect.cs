using Godot;
using System;

public interface IControlEffect
{
    void Apply(Control target, float delta);
}

public class ShakeEffect : IControlEffect
{
    private readonly float _amplitude;
    private readonly float _speed;
    private float _time = 0f;

    public ShakeEffect(float amplitude = 3f, float speed = 15f)
    {
        _amplitude = amplitude;
        _speed = speed;
    }

    public void Apply(Control target, float delta)
    {
        if (target == null) return;

        _time += delta * _speed;
        target.RotationDegrees = Mathf.Sin(_time) * _amplitude;
    }
}