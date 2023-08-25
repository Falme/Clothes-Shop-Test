using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ShopItemListData", menuName = "ScriptableObjects/ShopItemListData", order = 1)]
public class ShopItemListData : ScriptableObject
{
    public ShopItemData[] shopItemDatas;
}
