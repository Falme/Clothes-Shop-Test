using System;
using UnityEngine;

public class Shop : MonoBehaviour
{
	[SerializeField] private GameObject itemObject;
	[SerializeField] private Transform itemListContent;

	[SerializeField] private ShopItemListData shopItemList;

	[SerializeField] private bool showPurchased;

    void Start()
    {
		LoadItems();
    }

	private void OnEnable() {
		ShopItem.OnFinishTransaction += RefreshShop;
	}

	private void OnDisable() {
		ShopItem.OnFinishTransaction -= RefreshShop;
	}

	private void LoadItems()
	{
		foreach(ShopItemData itemData in shopItemList.shopItemDatas)
		{
			if(CheckItemInStore(itemData.ID, itemData.itemCategory) == showPurchased) continue;

			ShopItem item = Instantiate(itemObject, itemListContent).GetComponent<ShopItem>();
			item.SetItem(itemData);
		}
	}

	private void RefreshShop()
	{
		foreach(Transform child in itemListContent)
			Destroy(child.gameObject);

		LoadItems();
	}

	private bool CheckItemInStore(int ID, ItemCategory itemCategory)
	{
		return PlayerPrefs.GetInt($"{(int)itemCategory}_{ID}_owned", 0) == 0;
	}
}
