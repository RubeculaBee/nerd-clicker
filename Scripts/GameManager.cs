using Godot;
using System;

public partial class GameManager : Node
{
    // --- Nodes ---
    Clicker clickerButton;
    Label scoreDisplay;
    Shop shop;
    // --- END ---

    // --- Data ---
    
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
        clickerButton = GetNode<Clicker>("ClickerButton");
        scoreDisplay = GetNode<Label>("Points");
        shop = GetNode<Shop>("Shop");
    }

    private void CalculateScore()
    {
        shop.points = clickerButton.Clicks();

        scoreDisplay.Text = $"Points: {shop.points}";
    }
    // --- END ---
}
