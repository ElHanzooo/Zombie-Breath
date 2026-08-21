using Godot;
using System;
using Godot.Collections;
using System.Diagnostics;

public partial class Character : TextureRect
{
    //[Export] private Dictionary<Episodes, CharaConfig> characterConfigs = new();

    /*public override void _Ready()
    {
        foreach (var config in characterConfigs)
        {
            if (config.Key == Global.Instance.Episode)
            {
                var newTexture = config.Value.Texture;
                Texture = newTexture;
                Size = newTexture.GetSize();
                Scale = config.Value.Scale;
                PivotOffset = config.Value.Pivot;
                break;
            }
        }
    }*/
}
