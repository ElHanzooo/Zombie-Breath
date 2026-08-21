using Godot;
using Godot.Collections;
using System;

public partial class Stage : TextureRect
{
    [Export] private Array<Texture2D> _StageTextures;

    [Export] private Array<BaseButton> _buttons;
    
    private int _currentStage;

    private TextureRect _labelTexture;
    private Tween _tween;

    public override void _Ready()
    {
        _labelTexture = GetNode<TextureRect>("ActEpisode");

        //_currentStage = (Global.Instance.Act - 1) * 3 + (int)Global.Instance.Episode;
        //SetStageTexture(_currentStage);

        foreach (var button in _buttons)
        {
            button.Pressed += AnimationTween;
        }
    }

    /*public void SetStageTexture(int sum)
    {
        if (_StageTextures.Count == 0) return;

        _currentStage += sum;

        if (_currentStage > _StageTextures.Count - 1 || _currentStage > (Global.Instance.Act - 1) * 3 + (int)Global.Instance.Episode)
        {
            _currentStage = 0;
        }
        else if (_currentStage < 0)
        {
            _currentStage = (Global.Instance.Act - 1) * 3 + (int)Global.Instance.Episode;
        }

        _labelTexture.Texture = _StageTextures[_currentStage];
    }*/

    private void AnimationTween()
    {
        _tween?.Kill();
        _tween = GetTree().CreateTween().SetParallel(false);

        _tween.TweenProperty(this, "scale", new Vector2(3.9f, 3.9f), 0.05f)
              .SetTrans(Tween.TransitionType.Cubic)
              .SetEase(Tween.EaseType.Out);
        
        _tween.TweenProperty(this, "scale", new Vector2(3.8f, 3.8f), 0.05f)
              .SetTrans(Tween.TransitionType.Cubic)
              .SetEase(Tween.EaseType.Out);
    }
}
