using UnityEngine;

public class Character : MonoBehaviour, ICharacter
{
    public Inventory Inventory { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }
}
