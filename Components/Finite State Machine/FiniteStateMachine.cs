using Godot;
using System;

[GlobalClass]
public partial class FiniteStateMachine : Node
{
    [Export] public State InitialState { get; set; }

    public State ActiveState { get; set; }

    public override void _Ready()
    {
        foreach (State state in GetChildren())
        {
            state.Connect(State.SignalName.SwitchState, Callable.From<State>(ChangeState));
        }
    }

    public void ChangeState(State newState)
    {
        if (newState == ActiveState)
            return;

        if (ActiveState != null)
            ActiveState.Exit();

        ActiveState = newState;

        if (ActiveState != null)
            ActiveState.Enter();
    }
}
