using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LetterSpawner : MonoBehaviour
{
	public AudioSource audioSource;
	public Material particleMaterial;
	public ParticleSystem particleEffect;
	public List<Texture> texturesNumbers;
	public List<Texture> texturesLetters;

#if UNITY_EDITOR
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SpawnElements("A"); 
		}
	}
#endif

	public void SpawnElements(string text)
	{
		if (!string.IsNullOrEmpty(text) && text.Length <= 2)
		{		
			char inputChar = text.ToUpper()[0];
			int index;

			if (char.IsLetter(inputChar) && inputChar >= 'A' && inputChar <= 'H')
			{
				index = inputChar - 'A';
				if (index >= 0 && index < texturesLetters.Count)
				{
					particleMaterial.mainTexture = texturesLetters[index];
				}
			}
			else if (char.IsDigit(inputChar) && inputChar >= '1' && inputChar <= '8')
			{
				index = inputChar - '1'; 
				if (index >= 0 && index < texturesNumbers.Count)
				{
					particleMaterial.mainTexture = texturesNumbers[index]; 
				}
			}
		}

		audioSource.Play();
		particleEffect.Play();
	}
}
