using UnityEngine;

public class Setup : MonoBehaviour
{
	[SerializeField] private ShopContentData shopContentData;

	private void Awake() {
		CheckPlayerInitialItems();
	}

	private void CheckPlayerInitialItems()
	{
		for(int category=0; category < shopContentData.shopContents.Length; category++)
		{

			if(!PlayerPrefs.HasKey($"{category}_{0}_owned"))
			{
				PlayerPrefs.SetInt($"{category}_{0}_owned", 1);
				PlayerPrefs.SetInt($"{category}_equip", 0);
			}
		}
	}
}
