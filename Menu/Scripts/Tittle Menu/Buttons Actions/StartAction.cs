using Godot;
using System;

public partial class StartAction : ButtonAction
{
    [Export] private GenericUIAnimation _button;
    [Export] private AnimationPlayer _animationPlayer;
    [Export] private ColorRect _saturationEffect;

    private ShaderMaterial _saturationShader;
    
    public override void _Ready()
    {
        _button.SetMeta("Disabled", true);
        _saturationShader = _saturationEffect.Material as ShaderMaterial;

        _animationPlayer.AnimationFinished += (StringName animName) =>
        {
            if (animName == "Entry")
            {
                _button.SetMeta("Disabled", false);
            }
        };
    }

    public override void Execute()
    {
        _button.SetMeta("Disabled", true);
        _animationPlayer.Play("Exit");
        
        if (_saturationShader != null)
        {
            _saturationShader.SetShaderParameter("activated", false);
        }
    }
}
