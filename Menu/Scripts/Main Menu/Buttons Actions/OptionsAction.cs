using Godot;
using System;

public partial class OptionsAction : ButtonAction
{
    public override void Execute()
    {
        SceneChanger.Instance.ChangeScene("res://Menu/Scenes/options.tscn");
    }
}
