using System;
using UnityEngine;

public class Shop : MonoBehaviour
{
	[SerializeField] private GameObject itemObject;
	[SerializeField] private Transform itemListContent;

	[SerializeField] private ShopContentData shopItemList;

	[SerializeField] private bool showPurchased;

	private int currentCategory;

    void Start()
    {
		LoadItems();
    }

	private void OnEnable() {
		ShopItem.OnFinishTransaction += RefreshShop;
		Categories.OnChangeCategory += OnChangeCategory;
	}

	private void OnDisable() {
		ShopItem.OnFinishTransaction -= RefreshShop;
		Categories.OnChangeCategory -= OnChangeCategory;
	}

	private void OnChangeCategory(int categoryId)
	{
		currentCategory = categoryId;
		RefreshShop();
	}

	private void LoadItems()
	{
		ShopItemData[] shopItems = shopItemList.shopContents[currentCategory].shopItemDatas;
		foreach (ShopItemData itemData in shopItems)
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
