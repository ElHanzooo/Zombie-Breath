using Godot;
using System;

public partial class MinigamesAction : ButtonAction
{
    [Signal] public delegate void StartMinigamesEventHandler();

    public override void Execute()
    {
        EmitSignal(SignalName.StartMinigames);
    }
}
