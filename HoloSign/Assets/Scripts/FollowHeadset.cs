using UnityEngine;

public class PositionRelativeToHeadset : MonoBehaviour
{
	public OVRCameraRig ovrCameraRig; 
	public float distanceFromHeadset = 0.75f;

	private Transform centerEyeAnchor; 

	void Start()
	{
		if (ovrCameraRig == null)
		{
			ovrCameraRig = FindObjectOfType<OVRCameraRig>();
		}

		if (ovrCameraRig != null)
		{
			centerEyeAnchor = ovrCameraRig.centerEyeAnchor;
		}
		else
		{
			Debug.LogError("OVRCameraRig not found in the scene.");
		}
	}

	void Update()
	{
		if (centerEyeAnchor != null)
		{
			Vector3 eyePosition = centerEyeAnchor.position;
			Vector3 eyeForward = centerEyeAnchor.forward;

			Vector3 panelPosition = eyePosition + eyeForward * distanceFromHeadset;

			panelPosition.y = eyePosition.y;

			transform.position = panelPosition;
		}
	}
}
