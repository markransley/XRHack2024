using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CopyText : MonoBehaviour
{
	public Text sourceText; 
	private TextMeshProUGUI targetText;
	private const string PlayerPrefsKey = "SavedName";


	private void Start()
	{
		targetText = GetComponent<TextMeshProUGUI>();

		if (sourceText == null)
		{
			Debug.LogError("Source TextMeshPro component is not assigned!");
		}

	}

	private void Update()
	{
		if (sourceText != null && targetText != null)
		{
			targetText.text = sourceText.text;
			PlayerPrefs.SetString(PlayerPrefsKey, targetText.text);
		}
	}
}

