using Godot;
using System;

[GlobalClass]
public partial class State : Node
{
    [Signal] public delegate void SwitchStateEventHandler(State state);
}
