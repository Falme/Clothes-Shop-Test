using System;
using TMPro;
using UnityEngine;

public class PlayerCurrency : MonoBehaviour
{
	private const string CURRENCY_KEY = "PlayerCurrency";
	[SerializeField] private TextMeshProUGUI currencyText;
	[SerializeField] private bool isIncreasingEachSecond;

	private int currency = 0;
	private float intervalTime = 0f;

    void Start()
    {
        LoadCurrency();
		ShowCurrency();
    }

	private void OnEnable() {
		ShopItem.OnBuyItem += OnBuyItem;
		ShopItem.OnSellItem += OnSellItem;
	}


	private void OnDisable() {
		ShopItem.OnBuyItem -= OnBuyItem;
		ShopItem.OnSellItem -= OnSellItem;
	}

    void Update()
    {
        if(isIncreasingEachSecond) UpdateCurrencyEachSecond();
		if(Input.GetKeyDown(KeyCode.Alpha1)) AddCurrency(100);
		if(Input.GetKeyDown(KeyCode.Alpha2)) SubtractCurrency(100);
    }

	private void UpdateCurrencyEachSecond()
	{
		intervalTime+=Time.deltaTime;
		if(intervalTime > 1f)
		{
			intervalTime = 0f;
			AddCurrency(1);
		}
	}

	private void AddCurrency(int value)
	{
		currency+=value;
		OnChangeCurrency();
	}

	private void SubtractCurrency(int value)
	{
		currency-=value;
		
		if(currency < 0) 
			currency = 0;

		OnChangeCurrency();
	}

	private void OnChangeCurrency()
	{
		ShowCurrency();
		StoreCurrency();
	}

	private void ShowCurrency()
	{
		currencyText.text = currency.ToString();
	}

	private void StoreCurrency()
	{
		PlayerPrefs.SetInt(CURRENCY_KEY, currency);
	}

	private void LoadCurrency()
	{
		currency = PlayerPrefs.GetInt(CURRENCY_KEY, 0);
	}

	private bool OnBuyItem(int price)
	{
		if(price <= currency)
		{
			SubtractCurrency(price);
			return true;
		}
		
		return false;
	}

	private bool OnSellItem(int price)
	{
		AddCurrency(price);
		return true;
	}
}
