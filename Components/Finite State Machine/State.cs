using Godot;
using System;

[GlobalClass]
public partial class State : Node
{
    [Signal] public delegate void SwitchStateEventHandler(State state);

    public virtual void Enter() { }

    public virtual void Exit() { }

    public virtual void Update(double delta) { }

    public virtual void PhysicsUpdate(double delta) { }
}
