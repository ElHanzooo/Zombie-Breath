using Godot;
using System;

public partial class TittleMenu : Control
{
    [ExportGroup("Logo Shake Configuration")]
    [Export] private TextureRect _logo;
    [Export] private float rotationAmplitude = 3f;
    [Export] private float shakeSpeed = 15f;

    [ExportGroup("Nodes References")]
    [Export] private AnimationPlayer _animationPlayer;
    [Export] private VideoStreamPlayer _SplashScreen;
    [Export] private ColorRect _saturationEffect;

    private ShaderMaterial _saturationShader;

    private IControlEffect _logoShake;

    public override void _Ready()
    {
        _SplashScreen.Visible = true;
        _logoShake = new ShakeEffect(rotationAmplitude, shakeSpeed);

        _saturationShader = _saturationEffect.Material as ShaderMaterial;

        _SplashScreen.Finished += () =>
        {
            _SplashScreen.Visible = false;
            MenuMusicPlayer.Instance.PlayMusic();
            
            _animationPlayer.Play("Entry");
            if (_saturationShader != null)
            {
                _saturationShader.SetShaderParameter("activated", true);
            }
        };
        _animationPlayer.AnimationFinished += OnAnimationFinished;
    }

    public override void _Process(double delta)
    {
        _logoShake?.Apply(_logo, (float)delta);
    }

    private void OnAnimationFinished(StringName animName)
    {
        if (animName == "Exit")
        {
            SceneChanger.Instance.ChangeScene("res://Menu/Scenes/main_menu.tscn");
        }
    }
}
