using UnityEngine;

public class Debug : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0))
			PlayerPrefs.DeleteAll();
    }
}
