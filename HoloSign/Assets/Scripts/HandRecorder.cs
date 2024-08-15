
using UnityEditor;
using UnityEngine;
using System.IO;

public class HandRecorder : MonoBehaviour
{
	public GameObject parent;
	public GameObject handL;
	public GameObject handR;
	public Vector3 worldPosition = new Vector3(0, 0, 0.1f);

	private float timeElapsed = 0f;
	private const float interval = 10f;
	private int prefabIndex = 0;

	void Update()
	{
		timeElapsed += Time.deltaTime;

		if (timeElapsed >= interval)
		{
			DuplicateAndSaveHands();
			timeElapsed = 0f; 
		}
	}

	void DuplicateAndSaveHands()
	{
		GameObject handL_Duplicate = DuplicateHand(handL, "HandL_Duplicate");
		GameObject handR_Duplicate = DuplicateHand(handR, "HandR_Duplicate");
		GameObject combinedHands = new GameObject("CombinedHands");
		handL_Duplicate.transform.SetParent(combinedHands.transform);
		handR_Duplicate.transform.SetParent(combinedHands.transform);
		SaveAsPrefab(combinedHands, "HandPose");
	}

	GameObject DuplicateHand(GameObject hand, string namePrefix)
	{
		GameObject duplicateParent = new GameObject(namePrefix);
		duplicateParent.transform.position = transform.position + worldPosition;
		duplicateParent.transform.rotation = transform.rotation;

		foreach (Transform child in hand.transform)
		{
			GameObject duplicate = Instantiate(child.gameObject, duplicateParent.transform);
			duplicate.name = child.name; 

			Transform lHandMeshNodeTransform = duplicate.transform.Find("l_handMeshNode");
			if (lHandMeshNodeTransform != null)
			{
				SkinnedMeshRenderer meshRenderer = lHandMeshNodeTransform.GetComponent<SkinnedMeshRenderer>();
				if (meshRenderer != null)
				{
					meshRenderer.enabled = true;
				}
			}
		}

		if (parent != null)
		{
			duplicateParent.transform.SetParent(parent.transform);
		}
		else
		{
			Debug.LogWarning("Parent GameObject 'parent' not found in the scene.");
		}

		return duplicateParent;
	}

	void SaveAsPrefab(GameObject combinedHands, string basePrefabName)
	{
#if UNITY_EDITOR
		char suffix = (char)('A' + prefabIndex);
		prefabIndex++; 

		string prefabName = basePrefabName + suffix;
		string path = "Assets/Hand Poses Custom/" + prefabName + ".prefab";
		Directory.CreateDirectory("Assets/Hand Poses Custom");
		PrefabUtility.SaveAsPrefabAsset(combinedHands, path);
		Debug.Log($"Prefab saved at: {path}");
		Destroy(combinedHands);
#endif
	}
}
