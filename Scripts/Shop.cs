using Godot;
using Godot.Collections;
using System;
using System.Linq;

public partial class Shop : VBoxContainer
{
    // --- Nodes ---
    Array<ShopItem> ShopItems;
    // --- END ---

    // --- Data ---
    public int points;
    // --- END ---

    // --- Virtuals ---
    public override void _Ready()
    {
        base._Ready();

        ShopItems = GetItems();
        GD.Print(ShopItems);
    }
    // --- END ---

    // --- Helpers ---
    private Array<ShopItem> GetItems()
    {
        Node ItemContainer = FindChild("Items");
        int numItems = ItemContainer.GetChildCount();
        Array<ShopItem> ItemArray = [];
        Array<Node> nodeArray = ItemContainer.GetChildren();
        
        for(int i = 0; i < numItems; i++)
        {
            if(nodeArray[i] is ShopItem e)
            {
                ItemArray.Add(e);
            }
        }

        return ItemArray;
    }
    // --- END ---
}
