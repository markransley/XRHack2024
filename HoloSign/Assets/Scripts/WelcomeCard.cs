using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeCard : MonoBehaviour
{
	public XRButton startButton;
	void Start()
	{
		startButton.onClick = () =>
		{
			MainApplication.Instance.GoToOnboardingOneCard();
			AudioManager.Instance.PlayAmbientAudio();
		};
	}
}
