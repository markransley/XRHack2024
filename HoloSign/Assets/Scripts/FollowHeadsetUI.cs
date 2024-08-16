using UnityEngine;

public class FollowHeadsetUI : MonoBehaviour
{
	public OVRCameraRig ovrCameraRig; 
	public float distanceFromHeadset = 0.75f;
	public float verticalOffset = 0.2f;
	public float horizontalOffset = 0.4f;

	private Transform centerEyeAnchor;
	private Quaternion originalRotation;

	void Start()
	{
		if (ovrCameraRig == null)
		{
			ovrCameraRig = FindObjectOfType<OVRCameraRig>();
		}

		if (ovrCameraRig != null)
		{
			centerEyeAnchor = ovrCameraRig.centerEyeAnchor;
			originalRotation = transform.rotation;
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
			Vector3 eyeRight = centerEyeAnchor.right;

			Vector3 panelPosition = eyePosition + (eyeForward * distanceFromHeadset)
									+ (eyeRight * horizontalOffset) 
									+ (Vector3.up * verticalOffset); 

			transform.position = panelPosition;
			transform.rotation = originalRotation;

		}
	}

	void Update()
	{
		//StartCoroutine(PositionPanelWhenReady());
	}
}

