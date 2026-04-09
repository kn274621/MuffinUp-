using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenMuffinUp.Customs.Appliances;
using UnityEngine;

namespace KitchenMuffinUp.Customs.Items;

public class BlueBerries : CustomItem
{
    public override string UniqueNameID => "BlueBerries";

    public override GameObject Prefab => MaterialUtils.AssignMaterialsByNames(Main.Bundle.LoadAsset<GameObject>("Blue Berries"));

    public override Appliance DedicatedProvider => (Appliance)GDOUtils.GetCustomGameDataObject<BlueBerriesProvider>().GameDataObject;
}