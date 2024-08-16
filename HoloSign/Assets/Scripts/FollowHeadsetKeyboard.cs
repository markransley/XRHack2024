using UnityEngine;

public class FollowHeadsetKeyboard : MonoBehaviour
{
	public OVRCameraRig ovrCameraRig;
	public float distanceFromHeadset = 0.75f;
	public float heightOffset = -5f; 

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
			StartCoroutine(PositionPanelWhenReady());
		}
		else
		{
			Debug.LogError("OVRCameraRig not found in the scene.");
		}
	}

	private System.Collections.IEnumerator PositionPanelWhenReady()
	{
		yield return new WaitForEndOfFrame();

		if (centerEyeAnchor != null)
		{
			Vector3 eyePosition = centerEyeAnchor.position;
			Vector3 eyeForward = centerEyeAnchor.forward;

			// Calculate the new panel position with height offset
			Vector3 panelPosition = eyePosition + eyeForward * distanceFromHeadset;
			panelPosition.y += heightOffset; // Apply the height offset

			transform.position = panelPosition;
		}
	}

	void Update()
	{
	}
}

