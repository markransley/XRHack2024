using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public AudioSource clickClip;
	public AudioSource correctClip;
	public AudioSource incorrectClip;

	public AudioSource celebrationClip;

	public AudioSource ambientClip;

	void Start()
    {
        
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
