using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemCategory
{
	Clothes = 0,
	Hat = 1,
	Weapon = 2,
	Acessories = 3,
	Magic = 4,
	Companion = 5
}

[CreateAssetMenu(fileName = "ShopItemData", menuName = "ScriptableObjects/ShopItemData", order = 1)]
public class ShopItemData : ScriptableObject
{
    public int ID;
	public ItemCategory itemCategory;
	public string name;
	public Sprite sprite;
	public int price;
}
