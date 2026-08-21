using Godot;
using System;

public partial class CampaignAction : ButtonAction
{
    public override void Execute()
    {
        SceneChanger.Instance.ChangeScene("res://Menu/Scenes/campaign_menu.tscn");
    }
}
