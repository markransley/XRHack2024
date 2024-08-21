using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public static AudioManager Instance { get; private set; }

	public AudioSource clickClip;
	public AudioSource correctClip;
	public AudioSource incorrectClip;

	public AudioSource celebrationClip;

	public AudioSource ambientClip;

	private void Awake()
	{
		if (Instance != null && Instance != this)
		{
			Destroy(this);
			return;
		}

		Instance = this;
	}

	public void PlayAmbientAudio()
    {
        ambientClip.Play();
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	public void PlaySound(AudioSource clip)
	{
		clip.Play();
	}
}
