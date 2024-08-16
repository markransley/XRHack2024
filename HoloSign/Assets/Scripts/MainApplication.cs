using Meta.WitAi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainApplication : MonoBehaviour
{
	public static MainApplication Instance { get; private set; }

	public AudioManager audioMananger;

	// Title card
	public GameObject welcomeCard;
	public GameObject welcomeCardInstance;

	// Name entry card
	public GameObject nameEntryCard;
	public GameObject nameEntryCardInstance;
	// Language selection card

	// Lesson selection card

	// Lesson outline card

	// Lesson explanation card

	// Lesson quiz card (with help)

	// Lesson quiz card (without help)

	// "Put it to practice" card

	// Chess game with quit / continue icon after 8 moves

	// 

	private void Awake()
	{
		if (Instance != null && Instance != this)
		{
			Destroy(this);
			return;
		}

		Instance = this;
	}


	void Start()
    {
        StartCoroutine(ShowWelcomeCardCoroutine());
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	private IEnumerator ShowWelcomeCardCoroutine()
	{
		yield return new WaitForSeconds(5);
		welcomeCardInstance = Instantiate(welcomeCard);
	}

	public void GoToNameEntry()
	{
		if (welcomeCardInstance != null)
		{
			Destroy(welcomeCardInstance);
		}
		nameEntryCardInstance = Instantiate(nameEntryCard);
	}


}
