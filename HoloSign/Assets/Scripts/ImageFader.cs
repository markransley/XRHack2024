using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageFader : MonoBehaviour
{
	float fadeDuration = 1.0f;

	public void FadeIn(Graphic image)
	{
		Color color = image.color;
		color.a = 0;
		image.color = color;
		StartCoroutine(FadeImage(image, 0, 1));  // Fade from transparent to opaque
	}

	public void FadeOut(Graphic image)
	{
		StartCoroutine(FadeImage(image, 1, 0));  // Fade from opaque to transparent
	}

	public void FadeInMenu(GameObject menu)
	{
		if (menu != null)
		{
			foreach (Graphic graphic in menu.GetComponentsInChildren<Graphic>())
			{
				FadeIn(graphic);
			}
		}
	}

	public void FadeOutMenu(GameObject menu)
	{
		if (menu != null)
		{
			foreach (Graphic graphic in menu.GetComponentsInChildren<Graphic>())
			{
				FadeOut(graphic);
			}
		}
	}

	private IEnumerator FadeImage(Graphic image, float startAlpha, float endAlpha)
	{
		Color color = image.color;
		for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / fadeDuration)
		{
			color.a = Mathf.Lerp(startAlpha, endAlpha, t);
			image.color = color;
			yield return null;
		}
		color.a = endAlpha;
		image.color = color;  // Ensure the image reaches the final alpha
		if (endAlpha == 0)
		{
			image.gameObject.transform.parent.gameObject.SetActive(false);
			//image.gameObject.SetActive(false);
		}
		else
		{
			image.gameObject.transform.parent.gameObject.SetActive(true);
			//image.gameObject.SetActive(true);
		}
	}
}
