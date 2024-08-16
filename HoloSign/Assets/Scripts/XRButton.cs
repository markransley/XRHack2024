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
