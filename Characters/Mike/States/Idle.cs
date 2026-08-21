using Godot;
using System;

public partial class Idle : State
{
    [Export] private AnimationManager AnimationManager { get; set; } = null!;

    [ExportGroup("States")]
    [Export] private State ShootState { get; set; } = null!;
    [Export] private State ReloadingState { get; set; } = null!;

    public override void Enter() => AnimationManager.AddAnimation("Idle");

    public override void Update(double delta)
    {
        if (Input.IsActionJustPressed("Shoot"))
            EmitSignal(SignalName.SwitchState, ShootState);

        if (Input.IsActionJustPressed("Reloading"))
            EmitSignal(SignalName.SwitchState, ReloadingState);
    }
}
