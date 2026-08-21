using Godot;
using System;
using System.Threading.Tasks;

public interface ISceneTransition
{
    Task PlayIn();
    Task PlayOut();
}
