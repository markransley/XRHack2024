using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameMenu : MonoBehaviour
{
	private TouchScreenKeyboard overlayKeyboard;
	public static string inputText = "";

	public TMP_InputField nameInputField;
	public XRButton continueButton;

	void Start()
    {
		continueButton.onClick = ContinueClicked;
		
	}

	public void OnInputFieldSelected()
	{
		overlayKeyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
	}

	public void ContinueClicked()
	{
		if (MainApplication.Instance != null)
		{
			MainApplication.Instance.GoToTutorial();
		}
	}

	void Update()
    {
		if (overlayKeyboard != null)
		{
			inputText = overlayKeyboard.text;
			nameInputField.text = inputText;
		}
	}
}
