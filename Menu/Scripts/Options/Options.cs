using Godot;
using System;

public partial class Options : Control
{
    public override void _Ready()
    {
        MenuMusicPlayer.Instance.StopMusic();
    }
}
