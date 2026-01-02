using Godot;
using System;

public partial class button : Button
{
    public override void _Ready()
    {
        Pressed += OnButtonPressed;
    }

    private void OnButtonPressed()
    {
        GD.Print("uwu");
    }
}

