using System.Collections.Generic;

public class Inventory
{
    Dictionary<EquipSlots, Item> _equippedItems = new Dictionary<EquipSlots, Item>();
    List<Item> _unequippedItems = new List<Item>();

    public void EquipItem(Item item)
    {
        if (_equippedItems.ContainsKey(item.EquipSlot))
            _unequippedItems.Add(_equippedItems[item.EquipSlot]);

        _equippedItems[item.EquipSlot] = item;
    }

    public Item GetItem(EquipSlots equipSlot)
    {
        if (_equippedItems.ContainsKey(equipSlot))
            return _equippedItems[equipSlot];
        return null;
    }

    public int GetTotalArmor()
    {
        Dictionary<EquipSlots, Item>.ValueCollection values = _equippedItems.Values;
        int totalArmor = 0;
        foreach (Item itemArmor in values)
        {
            totalArmor += itemArmor.Armor;
        }
        return totalArmor;
    }
}
