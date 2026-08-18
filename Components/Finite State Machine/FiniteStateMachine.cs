using Godot;
using System;

[GlobalClass]
public partial class FiniteStateMachine : Node
{
    [Export] public State InitialState { get; set; }

    public State ActiveState { get; set; }
}
