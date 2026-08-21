using Godot;
using System;

public partial class ExitAction : ButtonAction
{
    public override void Execute()
    {
        // Adicionar o sistema de autosave depois

        GetTree().Quit();
    }
}
