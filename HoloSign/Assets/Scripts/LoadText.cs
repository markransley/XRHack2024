using UnityEngine;
using TMPro;

public class LoadText : MonoBehaviour
{
	private TextMeshProUGUI targetText; 
	private const string PlayerPrefsKey = "SavedName";

	private void Start()
	{
		targetText = GetComponent<TextMeshProUGUI>();

		if (PlayerPrefs.HasKey(PlayerPrefsKey))
		{
			targetText.text = PlayerPrefs.GetString(PlayerPrefsKey);
		}
		else
		{
			Debug.LogWarning("No saved text found in PlayerPrefs!");
		}
	}
}