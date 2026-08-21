using Godot;
using System;

public partial class TrophiesAction : ButtonAction
{
    [Signal] public delegate void ShowTrophiesEventHandler();

    public override void Execute()
    {
        EmitSignal(SignalName.ShowTrophies);
    }
}
