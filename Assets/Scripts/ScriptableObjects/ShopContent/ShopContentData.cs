using UnityEngine;

[CreateAssetMenu(fileName = "ShopContentData", menuName = "ScriptableObjects/ShopContentData", order = 1)]
public class ShopContentData : ScriptableObject
{
    public ShopItemListData[] shopContents;
}
