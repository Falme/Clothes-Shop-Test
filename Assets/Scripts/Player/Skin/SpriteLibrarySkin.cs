using UnityEngine;
using UnityEngine.U2D.Animation;

public class SpriteLibrarySkin : MonoBehaviour
{
	[SerializeField] private ShopItemListData itemList;
	[SerializeField] private ItemCategory category;
	private SpriteLibrary spriteLibrary;

	private void Awake() {
		spriteLibrary = GetComponent<SpriteLibrary>();
	}

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

		spriteLibrary.spriteLibraryAsset = itemData.skinSprite;
	}

	private void LoadSkin()
	{
		int id = PlayerPrefs.GetInt($"{(int)category}_equip", 0);
		OnEquipItem(itemList.shopItemDatas[id]);
	}
}
