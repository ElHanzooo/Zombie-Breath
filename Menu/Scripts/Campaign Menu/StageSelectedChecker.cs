using Godot;
using Godot.Collections;
using System;

public partial class StageSelectedChecker : Node
{
    [Export] private TextureRect _StageInfoPanel;
    [Export] private Array<StageConfig> _Stages;

    /*public (int, Episodes) CheckStage()
    {
        foreach (var stage in _Stages)
        {
            if (stage.Thumbnail == _StageInfoPanel.Texture)
            {
                return (stage.Act, stage.Episode);
            }
        }
        return (0, Episodes.Day);
    }*/
}
