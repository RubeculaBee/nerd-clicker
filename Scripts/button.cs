using Godot;
using System;

public partial class button : Node
{
    public override void _Ready()
    {
        Connect(Button.SignalName.Pressed, Callable.From(ButtonPressed));

        
    }

    private void ButtonPressed()
    {
        GD.Print("uwu");
    }
}

