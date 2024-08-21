using Meta.WitAi;
using Oculus.Interaction.Samples;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
	public GameObject onboardingOneCard;
	public GameObject onboardingOneCardInstance;

	//Language entry card
	public GameObject onboardingTwoCard;
	public GameObject onboardingTwoCardInstance;

	// Lesson entry card
	public GameObject lessonCard;
	public GameObject lessonCardInstance;

	// Tutorial card
	public GameObject tutorialCard;
	public GameObject tutorialCardInstance;

	// Game description card
	public GameObject gameDescriptionCard;
	public GameObject gameDescriptionCardInstance;

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

	public void GoToOnboardingOneCard()
	{
		imageFader.FadeOutMenu(welcomeCardInstance);
		Waiter();
		if (currentActiveMenu != null)
		{
			Destroy(currentActiveMenu);
		}
		onboardingOneCardInstance = Instantiate(onboardingOneCard);
		onboardingOneCardInstance.transform.position = menuPosition;
		onboardingOneCardInstance.transform.rotation = menuOrientation;
		imageFader.FadeInMenu(onboardingOneCardInstance);
	}

	public void GoToOnboardingTwoCard()
	{
		imageFader.FadeOutMenu(onboardingOneCardInstance);
		Waiter();
		if (currentActiveMenu != null)
		{
			Destroy(currentActiveMenu);
		}
		onboardingTwoCardInstance = Instantiate(onboardingTwoCard);
		onboardingTwoCardInstance.transform.position = menuPosition;
		onboardingTwoCardInstance.transform.rotation = menuOrientation;
		imageFader.FadeInMenu(onboardingTwoCardInstance);
	}

	public void GoToOnLessonCard()
	{
		imageFader.FadeOutMenu(onboardingTwoCardInstance);
		Waiter();
		if (currentActiveMenu != null)
		{
			Destroy(currentActiveMenu);
		}
		lessonCardInstance = Instantiate(lessonCard);
		lessonCardInstance.transform.position = menuPosition;
		lessonCardInstance.transform.rotation = menuOrientation;
		imageFader.FadeInMenu(lessonCardInstance);
	}

	public void GoToTutorial()
	{
		imageFader.FadeOutMenu(lessonCardInstance);
		Waiter();
		if (currentActiveMenu != null)
		{
			Destroy(currentActiveMenu);
		}

		tutorialCardInstance = Instantiate(tutorialCard);
		tutorialCardInstance.transform.position = menuPosition;
		tutorialCardInstance.transform.rotation = menuOrientation;
		imageFader.FadeInMenu(tutorialCardInstance);
	}

	public void GoGameDescription()
	{
		imageFader.FadeOutMenu(tutorialCardInstance);
		Waiter();
		if (currentActiveMenu != null)
		{
			Destroy(currentActiveMenu);
		}

		gameDescriptionCardInstance = Instantiate(gameDescriptionCard);
		gameDescriptionCardInstance.transform.position = menuPosition;
		gameDescriptionCardInstance.transform.rotation = menuOrientation;
		imageFader.FadeInMenu(gameDescriptionCardInstance);
	}

	public void GoChessGame()
	{
		imageFader.FadeOutMenu(gameDescriptionCardInstance);
		Waiter();
		if (currentActiveMenu != null)
		{
			Destroy(currentActiveMenu);
		}


		//gameDescriptionCardInstance = Instantiate(gameDescriptionCard);
		//gameDescriptionCardInstance.transform.position = menuPosition;
		//gameDescriptionCardInstance.transform.rotation = menuOrientation;
		//imageFader.FadeInMenu(gameDescriptionCardInstance);
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
