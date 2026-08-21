using Godot;
using System;

public partial class SceneChanger : CanvasLayer
{
    public static SceneChanger Instance { get; private set; }

    [Export] private Node _transitionNode;
    private ISceneTransition _transition;

    public override void _Ready()
    {
        Instance = this;

        _transition = _transitionNode as ISceneTransition;
    }

    public async void ChangeScene(string path)
    {
        if (_transition == null) return;

        GetViewport().SetInputAsHandled();

        await _transition.PlayIn();

        GetTree().ChangeSceneToFile(path);

        await _transition.PlayOut();
    }
}
