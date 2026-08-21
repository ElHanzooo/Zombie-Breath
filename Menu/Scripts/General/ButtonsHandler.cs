using Godot;
using System;

public partial class ButtonsHandler : Control
{
    [Export] private Label _label;
    [Export] private AudioStreamPlayer _clickSFX;
    [Export] private AudioStreamPlayer _hoverSFX;
    [Export] private AudioStreamPlayer _errorSFX;

    public override void _Ready()
    {
        foreach (var node in GetTree().GetNodesInGroup("MenuButtons"))
        {
            if (node is GenericUIAnimation button)
            {
                ButtonSetup(button);
            }
        }
    }

    private void ButtonSetup(GenericUIAnimation button)
    {
        button.MouseEntered += () => 
        {
            if(_label != null) UpdateLabel(button.GetMeta("Description").AsString());
            if (_hoverSFX != null) _hoverSFX.Play();
            button.OnMouseEntered();
        };
                
        button.MouseExited += () => 
        {
            if(_label != null) UpdateLabel(String.Empty);
            button.OnMouseExited();
        };

        button.Pressed += () => 
        {
            if (button.HasMeta("Disabled") && button.GetMeta("Disabled").AsBool())
            {
                if (_errorSFX != null) _errorSFX.Play();
                return;
            }
            if (_clickSFX != null) _clickSFX.Play();
            var action = button.GetNodeOrNull<ButtonAction>("Action");
            action.Execute();
        };
    }

    private void UpdateLabel(string text) 
    { 
        if(_label != null) _label.Text = text; 
    }
}
