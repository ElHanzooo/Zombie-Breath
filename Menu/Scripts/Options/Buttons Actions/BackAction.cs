using Godot;
using System;

public partial class BackAction : ButtonAction
{
    [Export] AnimationPlayer animationPlayer;

    public override void _Ready()
    {
        animationPlayer.AnimationFinished += OnAnimationFinished;
    }

    public override void Execute()
    {
        animationPlayer.Play("Out");
    }

    private void OnAnimationFinished(StringName animName)
    {
        if (animName == "Out")
        {
            SceneChanger.Instance.ChangeScene("res://Menu/Scenes/main_menu.tscn");
        }
    }
}
