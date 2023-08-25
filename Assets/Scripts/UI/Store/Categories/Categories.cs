using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Categories : MonoBehaviour
{
	public delegate void ChangeCategory(int categoryId);
	public static event ChangeCategory OnChangeCategory;

    public void SetCategory(int value)
	{
		OnChangeCategory?.Invoke(value);
	}
}
