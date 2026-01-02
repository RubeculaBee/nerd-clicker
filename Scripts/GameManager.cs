using Godot;
using System;

public partial class GameManager : Node
{
    public override void _Ready()
    {
        base._Ready();

        Button button = GetNode<Button>("ClickerButton");
        ScoreManager points = GetNode<ScoreManager>("Points");

        button.Pressed += points.OnButtonPressed;
    }
}
