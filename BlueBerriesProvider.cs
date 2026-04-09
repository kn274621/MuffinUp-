using System.Collections.Generic;
using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenMuffinUp.Customs.Items;
using UnityEngine;

namespace KitchenMuffinUp.Customs.Appliances;

public class BlueBerriesProvider : CustomAppliance
{
    public override string UniqueNameID => "BlueBerriesProvider";

    public override GameObject Prefab => MaterialUtils.AssignMaterialsByNames(Main.Bundle.LoadAsset<GameObject>("Blue Berries Provider"));

    public override List<IApplianceProperty> Properties => new List<IApplianceProperty> { (IApplianceProperty)(object)KitchenPropertiesUtils.GetUnlimitedCItemProvider(GDOUtils.GetCustomGameDataObject<BlueBerries>().ID) };

    public override PriceTier PriceTier => (PriceTier)3;

    public override RarityTier RarityTier => (RarityTier)1;

    public override bool IsPurchasable => true;

    public override bool SellOnlyAsDuplicate => true;

    public override List<(Locale, ApplianceInfo)> InfoList => new List<(Locale, ApplianceInfo)> { ((Locale)1, new ApplianceInfo
    {
        Name = "Blue Berries",
        Description = "Provides Blue Berries"
    }) };

    public override void OnRegister(Appliance gameDataObject)
    {
        ((CustomGameDataObject<Appliance>)this).OnRegister(gameDataObject);
    }
}
