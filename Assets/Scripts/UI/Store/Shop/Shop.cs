using UnityEngine;

public class Shop : MonoBehaviour
{
	[SerializeField] private int itemQuantity;
	[SerializeField] private GameObject itemObject;
	[SerializeField] private Transform itemListContent;

    void Start()
    {
		LoadItems();
    }

	private void LoadItems()
	{
		for(int a=0; a<itemQuantity; a++)
		{
			Instantiate(itemObject, itemListContent);
		}
	}
}
