using System;
using Godot;
using Godot.Collections;

public partial class ShopElement : PanelContainer
{
    [Export]
    int price;
    [Export]
    string name;
    [Export]
    string description;

    Dictionary<string, Label> labels;

    public override void _Ready()
    {
        base._Ready();

        SetLabels();
    }

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
        labels["Purchases"].Text = "0x";
    }
}
