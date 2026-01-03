using Godot;
using System;

public partial class Clicker : Button
{
    // --- Data ---
    private int clicks = 0;
    // --- END ---

    // --- Virtuals ---
    public override void _Ready()
    {
        Pressed += OnButtonPressed;
    }
    // --- END ---

    // --- Methods --- 
    public int Clicks() { return clicks; }
    // --- END ---

    // --- Signal Callbacks ---
    private void OnButtonPressed()
    {
        clicks++;
    }
    // --- END ---
}

