using Godot;
using System;

public partial class MainMenu : Control
{
    [Export] private BackgroundHandler BackgroundHandler;

    public override void _Ready()
    {
        MenuMusicPlayer.Instance.PlayMusic();
        //BackgroundHandler.UpdateBackground();
    }
}
