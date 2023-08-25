using System;
using TMPro;
using UnityEngine;
using UnityEngine.U2D.Animation;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
	public delegate bool ItemTransaction(int price);
	public static event ItemTransaction OnBuyItem;
	public static event ItemTransaction OnSellItem;
	
	public delegate void FinishTransaction();
	public static event FinishTransaction OnFinishTransaction;

	[SerializeField] private TextMeshProUGUI priceText;
	[SerializeField] private Image itemImage;

	private int itemID;
	private ItemCategory itemCategory;
	private SpriteLibraryAsset skinSprite;

	private int price;

	private void UpdatePrice()
	{
		priceText.text = price.ToString();
	}

	public void Buy()
	{
		bool? successful = OnBuyItem?.Invoke(price);

		if(successful == true)
		{
			SaveItemPurchase();
			OnFinishTransaction?.Invoke();
		}
	}

	public void Sell()
	{
		bool? successful = OnSellItem?.Invoke(price);

		if(successful == true)
		{
			SaveItemSelling();
			OnFinishTransaction?.Invoke();
		}
	}

	public void SetItem(ShopItemData item)
	{
		itemID = item.ID;
		itemCategory = item.itemCategory;
		itemImage.sprite = item.sprite;
		price = item.price;
		skinSprite = item.skinSprite;
		UpdatePrice();
	}

	private void SaveItemPurchase()
	{
		PlayerPrefs.SetInt($"{(int)itemCategory}_{itemID}_owned", 1);
	}

	private void SaveItemSelling()
	{
		PlayerPrefs.SetInt($"{(int)itemCategory}_{itemID}_owned", 0);
	}
}
