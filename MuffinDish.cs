using System.Collections.Generic;
using System.Web.UI.WebControls;
using KitchenData;
using KitchenLib;
using KitchenLib.Customs;
using KitchenLib.References;
using KitchenLib.Utils;
using UnityEngine;

namespace KitchenMuffinUp.Customs.Dishes;

public class MuffinDish : CustomDish
{
    public override string UniqueNameID => "Muffin";

    public override bool IsUnlockable => true;

    public override UnlockGroup UnlockGroup => (UnlockGroup)1;
    public override CardType CardType => (CardType)0;

    public override DishCustomerChange CustomerMultiplier => (DishCustomerChange)3;

    public override bool IsMainThatDoesNotNeedPlates => false;

    public override HashSet<Item> BlockProviders => new HashSet<Item>();

    public override DishType Type => (DishType)0;  // Starter dish

    public override int Difficulty => 1;

    public override List<string> StartingNameSet => new List<string>
    {
        "Muffin Deluxe",
        "Baked Fresh",
        "The Muffin",
        "Daily Muffin",
        "Sweet Morning"
    };

    public override HashSet<Item> MinimumIngredients => new HashSet<Item>
    {
        (Item)GDOUtils.GetExistingGDO(ItemReferences.MixingBowlEmpty),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Plate),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Flour),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Sugar),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Egg),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.Milk),
        (Item)GDOUtils.GetExistingGDO(ItemReferences.CupcakeTray),
    };

    public override HashSet<Process> RequiredProcesses => new HashSet<Process>
    {
        (Process)GDOUtils.GetExistingGDO(ProcessReferences.RequireOven)
    };

    public override GameObject DisplayPrefab => GetDisplayPrefab();

    public override GameObject IconPrefab => GetIconPrefab();

    public override bool IsAvailableAsLobbyOption => true;

    public override Dictionary<Locale, string> Recipe => new Dictionary<Locale, string>
    {
        {
            (Locale)1,
                "Combine flour, sugar, eggs, and milk. Pour into pan and bake until golden!"
        }    
    };

    public override List<(Locale, UnlockInfo)> InfoList => new List<(Locale, UnlockInfo)>
    {
        (
            (Locale)1,
                new UnlockInfo
            {
                Name = "Muffin",
                Description = "Adds Muffin as a Starter",
                FlavourText = "A delicious and fluffy baked treat!"
            }
        )
    };

    private GameObject GetDisplayPrefab()
    {
        try
        {
            if (Main.Bundle != null)
            {
                return Main.Bundle.LoadAsset<GameObject>("");
            }
        }
        catch
        {
            Main.LogWarning("Failed to load DisplayPrefab from bundle");
        }

        return null;
    }

    private GameObject GetIconPrefab()
    {
        try
        {
            if (Main.Bundle != null)
            {
                return MaterialUtils.AssignMaterialsByNames(Main.Bundle.LoadAsset<GameObject>("MU-BaseMuffin"));
            }
        }
        catch
        {
            Main.LogWarning("Failed to load IconPrefab from bundle");
        }

        return null;
    }
}
