using Godot;
using System;

public partial class CreditsAction : ButtonAction
{
    [Signal] public delegate void OpenSavefilesEventHandler();

    public override void Execute()
    {
        EmitSignal(SignalName.OpenSavefiles);
    }
}
