using Meta.WitAi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainApplication : MonoBehaviour
{
	public static MainApplication Instance { get; private set; }

	public AudioManager audioMananger;
	public ImageFader imageFader;

	public Transform hmdTransform;
	public float distanceFromHeadset = 0.75f;

	public Vector3 menuPosition;
	public Quaternion menuOrientation;

	// Title card
	public GameObject welcomeCard;
	public GameObject welcomeCardInstance;

	// Name entry card
	public GameObject nameEntryCard;
	public GameObject nameEntryCardInstance;

	public GameObject onboardingOneCard;
	public GameObject onboardingOneCardInstance;

	// Onboarding two card
	public GameObject onboardingTwoCard;
	public GameObject onboardingTwoCardInstance;

	public GameObject tutorialCard;
	public GameObject tutorialCardInstance;

	// Language selection card

	// Lesson selection card

	// Lesson outline card

	// Lesson explanation card

	// Lesson quiz card (with help)

	// Lesson quiz card (without help)

	// "Put it to practice" card

	// Chess game with quit / continue icon after 8 moves

	// 

	public GameObject currentActiveMenu;

	public Inference inference;

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
		yield return new WaitForSeconds(2);
		welcomeCardInstance = Instantiate(welcomeCard);
		welcomeCardInstance.transform.position = hmdTransform.position + hmdTransform.forward * distanceFromHeadset;
		welcomeCardInstance.transform.rotation = Quaternion.LookRotation(hmdTransform.forward);
		menuOrientation = welcomeCardInstance.transform.rotation;
		menuPosition = welcomeCardInstance.transform.position;
		currentActiveMenu = welcomeCardInstance;

		imageFader.FadeInMenu(welcomeCardInstance);
	}

	public void GoToNameEntry()
	{
		//imageFader.FadeOutMenu(welcomeCardInstance);
		if (currentActiveMenu != null)
		{
			Destroy(currentActiveMenu);
		}
		nameEntryCardInstance = Instantiate(nameEntryCard);
		nameEntryCardInstance.transform.position = menuPosition;
		nameEntryCardInstance.transform.rotation = menuOrientation;
	}

	public void GoToTutorial()
	{
		imageFader.FadeOutMenu(currentActiveMenu);
		Waiter();
		if (currentActiveMenu != null)
		{
			Destroy(currentActiveMenu);
		}

		//onboardingOneCardInstance = Instantiate(onboardingOneCard);
		tutorialCardInstance = Instantiate(tutorialCard);
		tutorialCardInstance.transform.position = menuPosition;
		tutorialCardInstance.transform.rotation = menuOrientation;
		imageFader.FadeInMenu(tutorialCardInstance);
	}

	public void ActivateInference(bool activate)
	{
		inference.gameObject.SetActive(activate);
	}

	public IEnumerator Waiter()
	{
		yield return new WaitForSeconds(1.5f);
	}
}
