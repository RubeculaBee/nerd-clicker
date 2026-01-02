using Godot;
using System;

public partial class ScoreManager : Label
{
    private int points = 0;

    public override void _Ready()
    {
        base._Ready();
        Text = $"Points: {points}"; 
    }

    public void OnButtonPressed()
    {
        points++;
        Text = $"Points: {points}";
    }
}
