using UnityEngine;

public class Debug : MonoBehaviour
{
    void Update()
	{
		DeleteAllData();
	}

	private static void DeleteAllData()
	{
		if (Input.GetKeyDown(KeyCode.Alpha0))
			PlayerPrefs.DeleteAll();
	}
}
