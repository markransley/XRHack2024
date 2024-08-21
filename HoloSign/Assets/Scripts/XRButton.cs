using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRButton : MonoBehaviour
{
	public Action onClick;
	public Action onRelease;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

	public void GoToOnboardingTwoCard()
	{
		MainApplication.Instance.GoToOnboardingTwoCard();
	}

	public void GoToOnLessonCard()
	{
		MainApplication.Instance.GoToOnLessonCard();
	}

	public void GoToTutorial()
	{
		MainApplication.Instance.GoToTutorial();
	}

	public void GoGameDescription()
	{
		MainApplication.Instance.GoGameDescription();
	}

	public void GoChessGame()
	{
		MainApplication.Instance.GoChessGame();
	}

	public void OnClick()
	{
		if (MainApplication.Instance != null)
		{
			MainApplication.Instance.audioMananger.PlaySound(MainApplication.Instance.audioMananger.clickClip);
		}
		onClick?.Invoke();
	}

	public void OnRelease()
	{
		onRelease?.Invoke();
	}
}
