using Godot;
using System;

public partial class GameManager : Node
{
    // --- Nodes ---
    Clicker ClickerButton;
    Label ScoreDisplay;
    // --- END ---

    // --- Data ---
    int points = 0;
    // --- END ---

    // --- Virtuals ---
    public override void _Ready()
    {
        base._Ready();
        GetNodes();
    }

    public override void _Process(double delta)
    {
        base._Process(delta);

        CalculateScore();
    }

    // --- END ---

    // --- Helpers --- 
    private void GetNodes()
    {
        ClickerButton = GetNode<Clicker>("ClickerButton");
        ScoreDisplay = GetNode<Label>("Points");
    }

    private void CalculateScore()
    {
        points = ClickerButton.Clicks();

        ScoreDisplay.Text = $"Points: {points}";
    }
    // --- END ---
}
