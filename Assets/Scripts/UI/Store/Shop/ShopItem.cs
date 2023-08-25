using System;
using TMPro;
using UnityEngine;
using UnityEngine.U2D.Animation;
using UnityEngine.UI;

public class ShopItem : MonoBehaviour
{
	public delegate bool BuyItem(int price);
	public static event BuyItem OnBuyItem;
	
	public delegate void FinishPurchase();
	public static event FinishPurchase OnFinishPurchase;

	[SerializeField] private TextMeshProUGUI priceText;
	[SerializeField] private Image itemImage;

	private int itemID;
	private ItemCategory itemCategory;
	private SpriteLibraryAsset skinSprite;

	private int price;

    void Start()
    {
		
    }

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
			OnFinishPurchase?.Invoke();
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
}
