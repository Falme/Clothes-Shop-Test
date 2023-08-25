using TMPro;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
	public delegate void BuyItem(int price);
	public static event BuyItem OnBuyItem;

	[SerializeField] private TextMeshProUGUI priceText;

	private int price = 300;

    void Start()
    {
        price = Random.Range(10,500);
		UpdatePrice();
    }

	private void UpdatePrice()
	{
		priceText.text = price.ToString();
	}

	public void Buy()
	{
		OnBuyItem?.Invoke(price);
	}
}
