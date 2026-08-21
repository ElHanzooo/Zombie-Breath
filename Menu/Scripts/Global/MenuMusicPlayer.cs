using Godot;
using System;
using Godot.Collections;

public partial class MenuMusicPlayer : AudioStreamPlayer
{
    public static MenuMusicPlayer Instance { get; private set; }

    //[Export] public Dictionary<Episodes, AudioStream> MusicTracks = new();

    public override void _Ready()
    {
        Instance = this;

        /*foreach (var music in MusicTracks)
        {
            if (music.Key == Global.Instance.Episode)
            {
                Stream = music.Value;
                break;
            }
        }*/
    }

    public void PlayMusic()
    {
        if (!Playing)
        {
            Play();
        }
    }

    public void StopMusic()
    {
        if (Playing)
        {
            Stop();
        }
    }
}
