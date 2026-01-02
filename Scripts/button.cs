using Godot;
using System;

public partial class button : Button
{
    public override void _Ready()
    {
        Pressed += _OnButtonPressed;
    }

    private void _OnButtonPressed()
    {
        GD.Print("uwu");
    }
}

