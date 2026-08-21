using Godot;
using System;
using Godot.Collections;

public partial class RedBackground : Control
{
    //[Export] Dictionary<Episodes, float> ColorsBright = new();

    /*public override void _Ready()
    {
        if ((ShaderMaterial)Material != null)
        {
            ((ShaderMaterial)Material).SetShaderParameter("bright", Global.Instance.Episode switch
            {
                Episodes.Day => ColorsBright[Episodes.Day],
                Episodes.Afternoon => ColorsBright[Episodes.Afternoon],
                Episodes.Night => ColorsBright[Episodes.Night],
                _ => 0
            });
        }
    }*/
}
