using Godot;
using System;

public partial class CampaignMenu : Control
{
    [Signal] public delegate void StartGameEventHandler(/*int Act, Episodes Episode*/);

    [Export] private AnimationTree _AnimationTree;
    [Export] private StageSelectedChecker _StageSelectedChecker;

    private AnimationNodeStateMachinePlayback _animationStateMachine;

    private bool _IsExiting = false;

    public override void _Ready()
    {
        MenuMusicPlayer.Instance.PlayMusic();

        _animationStateMachine = (AnimationNodeStateMachinePlayback)_AnimationTree.Get("parameters/playback");
        _animationStateMachine.Travel("In");

        _AnimationTree.AnimationFinished += OnAnimationFinished;
    }

    public override void _Input(InputEvent @event)
    {
        if (@event.IsActionPressed("ui_filedialog_up_one_level"))
        {
            _IsExiting = true;
            _animationStateMachine.Travel("Out");
        }
        else if (@event.IsActionPressed("ui_accept"))
        {
            _IsExiting = false;
            _animationStateMachine.Travel("Out");
        }
    }

    private void OnAnimationFinished(StringName animName)
    {
        if (animName == "Out")
        {
            switch (_IsExiting)
            {
                case true:
                    SceneChanger.Instance.ChangeScene("res://Menu/Scenes/main_menu.tscn");
                    break;
                default:
                    //var (act, episode) = _StageSelectedChecker.CheckStage();
                    //EmitSignal(SignalName.StartGame, act, (int)episode);
                    //GD.Print($"Starting game with Act {act} and Episode {episode}");
                    break;
            }
        }
    }

}
