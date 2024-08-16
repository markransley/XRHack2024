using UnityEngine;
using UnityEngine.UI;

public class ProgressBarController : MonoBehaviour
{
	[Header("Progress Bar Settings")]
	public Slider progressBarSlider;          
	public int totalPoints = 6;        
	public int pointsPerAction = 1;     

	private int currentPoints = 0;      

	void Start()
	{
		if (progressBarSlider != null)
		{
			progressBarSlider.maxValue = totalPoints;
			progressBarSlider.value = currentPoints;
		}
	}

	public void AddPoint()
	{
		currentPoints += pointsPerAction;
		UpdateProgressBar();
	}

	private void UpdateProgressBar()
	{
		if (progressBarSlider != null)
		{
			progressBarSlider.value = Mathf.Clamp(currentPoints, 0, totalPoints);
		}
	}

	public void ResetProgressBar()
	{
		currentPoints = 0;
		UpdateProgressBar();
	}

	void Update()
	{
		//if (Input.GetKeyDown(KeyCode.Space))
		//{
		//	AddPoint();
		//}
	}
}
