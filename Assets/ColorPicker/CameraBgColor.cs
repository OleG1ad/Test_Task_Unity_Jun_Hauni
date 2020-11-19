using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CameraBgColor : MonoBehaviour {
	
	void OnSetColor(Color color)
	{
		GetComponent<Camera>().backgroundColor = color;
	}

	void OnGetColor(ColorPicker picker)
	{
		picker.NotifyColor(GetComponent<Camera>().backgroundColor);
	}
}
