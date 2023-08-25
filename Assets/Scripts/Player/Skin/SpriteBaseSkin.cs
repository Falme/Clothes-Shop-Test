using UnityEngine;

public class SpriteBaseSkin : MonoBehaviour
{
	[SerializeField] private ShopItemListData itemList;
	[SerializeField] private ItemCategory category;
	[SerializeField] private SpriteRenderer spriteRenderer;

	private void Start() {
		LoadSkin();
	}

	private void OnEnable() {
		ShopItem.OnEquipItem += OnEquipItem;
	}

	private void OnDisable() {
		ShopItem.OnEquipItem += OnEquipItem;
	}

	private void OnEquipItem(ShopItemData itemData)
	{
		if(itemData.itemCategory != category) 
			return;

		spriteRenderer.sprite = itemData.sprite;
	}

	private void LoadSkin()
	{
		int id = PlayerPrefs.GetInt($"{(int)category}_equip", 0);
		OnEquipItem(itemList.shopItemDatas[id]);
	}
}
