using System;
using Godot;
using Godot.Collections;

public partial class ShopElement : PanelContainer
{
    // --- Data ---
    int purchaseCount = 0;
    // --- END ---

    // --- Exports ---
    [Export]
    int price;
    [Export]
    string name;
    [Export]
    string description;
    // --- END ---

    // --- Nodes ---
    Dictionary<string, Label> labels;
    // --- END ---

    public override void _Ready()
    {
        base._Ready();

        SetLabels();
    }

    // --- Helper methods --- 
    private void SetLabels()
    {
        labels = new Dictionary<string, Label>
        {
            {"Name" , FindChild("Name") as Label},
            {"Description", FindChild("Description") as Label},
            {"Price", FindChild("Price") as Label},
            {"Purchases", FindChild("Purchases") as Label}
        };

        labels["Name"].Text = name;
        labels["Description"].Text = description;
        labels["Price"].Text = $"{price}P";
        labels["Purchases"].Text = $"{purchaseCount}x";
    }
    // --- END ---

    // --- Signal Callbacks ---
    
    // --- END ---
}
