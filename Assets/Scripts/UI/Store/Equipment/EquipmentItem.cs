using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EquipmentItem : MonoBehaviour
{
	[SerializeField] private ShopContentData contentData;
	[SerializeField] private Image image;
	[SerializeField] private ItemCategory itemCategory;

	private void Start() {
		LoadEquipment();
	}

	private void OnEnable() {
		ShopItem.OnEquipItem += OnEquipItem;
	}

	private void OnDisable() {
		ShopItem.OnEquipItem -= OnEquipItem;
	}

	private void OnEquipItem(ShopItemData itemData)
	{
		if(itemData.itemCategory != itemCategory) 
			return;
		
		ShowItem(itemData);
		SaveEquipment(itemData);
	}

	private void ShowItem(ShopItemData itemData)
	{
        image.sprite = itemData.sprite;
	}

	private void SaveEquipment(ShopItemData itemData)
	{
		PlayerPrefs.SetInt($"{(int)itemData.itemCategory}_equip", itemData.ID);
	}

	private void LoadEquipment()
	{
		int id = PlayerPrefs.GetInt($"{(int)itemCategory}_equip", 0);
		ShowItem(contentData.shopContents[(int)itemCategory].shopItemDatas[id]);
	}
}
