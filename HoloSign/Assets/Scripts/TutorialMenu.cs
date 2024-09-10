using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TutorilMenu : MonoBehaviour
{
	public Sprite aSprite;
	public Sprite bSprite;
	public Sprite cSprite;
	public Sprite dSprite;
	public Sprite eSprite;
	public Sprite fSprite;
	public Sprite gSprite;
	public Sprite hSprite;

	public Sprite oneSprite;
	public Sprite twoSprite;
	public Sprite threeSprite;
	public Sprite fourSprite;
	public Sprite fiveSprite;
	public Sprite sixSprite;
	public Sprite sevenSprite;
	public Sprite eightSprite;

	public Image image;
	public TMPro.TextMeshProUGUI currentTaskText;

	public TMPro.TextMeshProUGUI userText;
	
	public Image feedbackImage;
	public Sprite correctSprite;
	public Sprite incorrectSprite;

	private string currentTaskString = "A";

	public XRButton startButton;

	private Color correctColor = new Color(5.0f / 255, 168.0f / 255, 7.0f / 255);
	private Color incorrectColor = new Color(168.0f / 255, 5.0f / 255, 5.0f / 255);

	private bool shouldWait = false;

	private float fadeDuration = 1.0f;

	public Slider slider;
	public GameObject progressBar;

	public GameObject tutComplete;

	public XRButton skipButton;

	private bool tutorialCompleted = false;

	public GameObject userFeedbackBg;

	public XRButton goToChessButton;

	//public GameObject celebrationGO;

	void Start()
	{
		//startButton.onClick = () =>
		//{
		//	//MainApplication.Instance.GoToNameEntry();
		//};

		image.sprite = aSprite;
		currentTaskText.text = "A";
		currentTaskString = "A";

		slider.value = 0;

		userText.text = "";

		tutComplete.gameObject.SetActive(false);
		//feedbackImage.gameObject.SetActive(false);

		skipButton.onClick = Skip;

		goToChessButton.onClick = GoToChess;

		MainApplication.Instance.ActivateInference(true);
	}

	private void GoToChess()
	{

	}

	public void Update()
	{
		if (shouldWait)
		{
			userText.text = "";
			return;
		}
		if (MainApplication.Instance.inference.gameObject.activeSelf && MainApplication.Instance.inference.gestureID != "-1")
		{
			GestureDetected();
		}
		else
		{
			userText.text = "";
		}
	}

	private void GestureDetected()
	{
		string gestureID = MainApplication.Instance.inference.gestureID;
		float confidence = MainApplication.Instance.inference.confidence;

		if (gestureID == "A" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.aConfidence)
		{
			GestureCorrect(gestureID);
			
		}
		else if (gestureID == "B" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.bConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "C" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.cConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "D" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.dConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "E" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.eConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "F" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.fConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "G" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.gConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "H" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.hConfidence)
		{
			GestureCorrect(gestureID);
		}

		else if (gestureID == "1" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.oneConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "2" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.twoConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "3" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.threeConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "4" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.fourConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "5" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.fiveConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "6" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.sixConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "7" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.sevenConfidence)
		{
			GestureCorrect(gestureID);
		}
		else if (gestureID == "8" && gestureID == currentTaskString && confidence >= MainApplication.Instance.inference.eightConfidence)
		{
			GestureCorrect(gestureID);
		}
	}

	public void Skip()
	{
		GestureCorrect(currentTaskString);
	}

	public void GestureCorrect(string gestureID)
	{
		slider.value += 1.0f / 16;
		slider.maxValue = 1.0f;
		userText.text = gestureID;
		MainApplication.Instance.audioMananger.PlaySound(MainApplication.Instance.audioMananger.correctClip);
		StartCoroutine(Waiter());
		feedbackImage.sprite = correctSprite;
		feedbackImage.color = correctColor;
		feedbackImage.gameObject.SetActive(true);
		GoToNext();
	}

	private void GoToNext()
	{
		if (currentTaskString == "A")
		{
			currentTaskString = "B";
			image.sprite = bSprite;
			currentTaskText.text = "B";
		}
		else if (currentTaskString == "B")
		{
			currentTaskString = "C";
			image.sprite = cSprite;
			currentTaskText.text = "C";
		}
		else if (currentTaskString == "C")
		{
			currentTaskString = "D";
			image.sprite = dSprite;
			currentTaskText.text = "D";
		}
		else if (currentTaskString == "D")
		{
			currentTaskString = "E";
			image.sprite = eSprite;
			currentTaskText.text = "E";
		}
		else if (currentTaskString == "E")
		{
			currentTaskString = "F";
			image.sprite = fSprite;
			currentTaskText.text = "F";
		}
		else if (currentTaskString == "F")
		{
			currentTaskString = "G";
			image.sprite = gSprite;
			currentTaskText.text = "G";
		}
		else if (currentTaskString == "G")
		{
			currentTaskString = "H";
			image.sprite = hSprite;
			currentTaskText.text = "H";
		}
		else if (currentTaskString == "H")
		{
			currentTaskString = "1";
			image.sprite = oneSprite;
			currentTaskText.text = "1";
		}
		else if (currentTaskString == "1")
		{
			currentTaskString = "2";
			image.sprite = twoSprite;
			currentTaskText.text = "2";
		}
		else if (currentTaskString == "2")
		{
			currentTaskString = "3";
			image.sprite = threeSprite;
			currentTaskText.text = "3";
		}
		else if (currentTaskString == "3")
		{
			currentTaskString = "4";
			image.sprite = fourSprite;
			currentTaskText.text = "4";
		}
		else if (currentTaskString == "4")
		{
			currentTaskString = "5";
			image.sprite = fiveSprite;
			currentTaskText.text = "5";
		}
		else if (currentTaskString == "5")
		{
			currentTaskString = "6";
			image.sprite = sixSprite;
			currentTaskText.text = "6";
		}
		else if (currentTaskString == "6")
		{
			currentTaskString = "7";
			image.sprite = sevenSprite;
			currentTaskText.text = "7";
		}
		else if (currentTaskString == "7")
		{
			currentTaskString = "8";
			image.sprite = eightSprite;
			currentTaskText.text = "8";
		}
		else if (currentTaskString == "8")
		{
			CompleteTutorial();
		}
	}

	private void CompleteTutorial()
	{
		MainApplication.Instance.imageFader.FadeOut(feedbackImage);
		MainApplication.Instance.imageFader.FadeOut(image);
		MainApplication.Instance.imageFader.FadeOut(currentTaskText);
		MainApplication.Instance.imageFader.FadeOut(userText);
		MainApplication.Instance.imageFader.FadeOutMenu(progressBar);
		MainApplication.Instance.imageFader.FadeOutMenu(userFeedbackBg);
		MainApplication.Instance.imageFader.FadeOutMenu(skipButton.gameObject);
		//MainApplication.Instance.imageFader.FadeOut();
		MainApplication.Instance.ActivateInference(false);
		MainApplication.Instance.audioMananger.PlaySound(MainApplication.Instance.audioMananger.celebrationClip);

		WaitTwo();
		tutComplete.SetActive(true);
		MainApplication.Instance.imageFader.FadeInMenu(tutComplete);
	}

	public IEnumerator Waiter()
	{
		shouldWait = true;
		MainApplication.Instance.imageFader.FadeOut(feedbackImage);
		yield return new WaitForSeconds(1.5f);
		shouldWait = false;
		feedbackImage.gameObject.SetActive(false);

		Color col = feedbackImage.color;
		col.a = 1;
		feedbackImage.color = col;
		userText.text = "";
	}

	public IEnumerator WaitTwo()
	{
		yield return new WaitForSeconds(1);
	}


	public void OnDestroy()
	{
		MainApplication.Instance.ActivateInference(false);
	}
}
