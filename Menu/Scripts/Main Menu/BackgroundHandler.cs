using Godot;
using System;
using Godot.Collections;

public partial class BackgroundHandler : Control
{
    [Export] private Control NodeModulate;
    /*[Export] private Dictionary<Episodes, BGConfig> Backgrounds = new();

    public void UpdateBackground()
    {
        foreach (var config in Backgrounds)
        {
            var nodeControl = GetNode<Control>(config.Value.ControlBackgroundPath);

            if (config.Key == Global.Instance.Episode)
            {
                nodeControl.Show();
                NodeModulate.Modulate = config.Value.ModulateColor;
            }
            else
            {
                nodeControl.Hide();
            }
        }
    }*/
}
