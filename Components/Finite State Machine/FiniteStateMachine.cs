using Godot;
using System;
using System.Linq;

[GlobalClass]
public partial class FiniteStateMachine : Node
{
    [Export] public State InitialState { get; set; }

    public State ActiveState { get; set; }

    public override void _Ready()
    {
        foreach (State state in GetChildren().Cast<State>())
            state.Connect(State.SignalName.SwitchState, Callable.From<State>(ChangeState));

        ChangeState(InitialState);
    }

    public override void _Process(double delta)
    {
        ActiveState?.Update(delta);
    }

    public override void _PhysicsProcess(double delta)
    {
        ActiveState?.PhysicsUpdate(delta);
    }

    public void ChangeState(State newState)
    {
        if (newState == ActiveState)
            return;

        ActiveState?.Exit();

        ActiveState = newState;

        ActiveState?.Enter();
    }
}
