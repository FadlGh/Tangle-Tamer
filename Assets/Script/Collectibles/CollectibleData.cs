using UnityEngine;

[CreateAssetMenu(fileName = "New Collectible", menuName = "Collectible")]
public class CollectibleData : ScriptableObject
{
    public string soundName;
    public int collectibleValue;
}