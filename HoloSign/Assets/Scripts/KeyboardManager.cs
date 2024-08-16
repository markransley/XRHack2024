using UnityEngine;

public class KeyboardManager : MonoBehaviour
{
	private TouchScreenKeyboard overlayKeyboard;
	public static string inputText = "";

	void OnEnable()
	{
		OVRManager.InputFocusLost += OnInputFocusLost;
		OVRManager.InputFocusAcquired += OnInputFocusAcquired;
	}

	void OnDisable()
	{
		OVRManager.InputFocusLost -= OnInputFocusLost;
		OVRManager.InputFocusAcquired -= OnInputFocusAcquired;
	}

	private void OnInputFocusLost()
	{
		// Handle the loss of focus when the keyboard is shown
	}

	private void OnInputFocusAcquired()
	{
		// Handle when the focus is regained after the keyboard is closed
	}

	public void OnInputFieldSelected()
	{
		overlayKeyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
	}
	void Update()
	{
		if (overlayKeyboard != null)
		{
			inputText = overlayKeyboard.text;
		}
	}

}

