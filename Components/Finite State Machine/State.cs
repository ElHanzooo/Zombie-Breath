using Godot;
using System;

[GlobalClass]
public partial class State : Node
{
    [Signal] public delegate void SwitchStateEventHandler(State state);

    public void Enter() { }

    public void Exit() { }

    public void Update(double delta) { }

    public void PhysicsUpdate(double delta) { }
}
