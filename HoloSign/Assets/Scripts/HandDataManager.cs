using UnityEngine;
using static OVRPlugin;
using System;


public class HandDataManager : MonoBehaviour
{
	public OVRSkeleton leftHandSkeleton;
	public OVRSkeleton rightHandSkeleton;

	public string GestureID;

	void Update()
	{
		Matrix4x4 lhMatrix = leftHandSkeleton.transform.worldToLocalMatrix;
		Matrix4x4 rhMatrix = rightHandSkeleton.transform.worldToLocalMatrix;

		if (leftHandSkeleton != null && leftHandSkeleton.IsInitialized && leftHandSkeleton.IsDataValid)
		{
			foreach (var bone in leftHandSkeleton.Bones)
			{
				if (bone.ParentBoneIndex != -1)
				{
					OVRBone parentBone = leftHandSkeleton.Bones[bone.ParentBoneIndex];
					Debug.DrawLine(lhMatrix.MultiplyPoint(bone.Transform.position), lhMatrix.MultiplyPoint(parentBone.Transform.position));
				}
			}

			if (rightHandSkeleton != null && rightHandSkeleton.IsInitialized)
			{
				foreach (var bone in rightHandSkeleton.Bones)
				{
					if (bone.ParentBoneIndex != -1)
					{
						OVRBone parentBone = rightHandSkeleton.Bones[bone.ParentBoneIndex];
						Debug.DrawLine((lhMatrix).MultiplyPoint(bone.Transform.position), (lhMatrix).MultiplyPoint(parentBone.Transform.position));
					}
				}
			}
		}

		else if (leftHandSkeleton != null && leftHandSkeleton.IsDataValid == false && rightHandSkeleton != null && rightHandSkeleton.IsInitialized)
		{
			foreach (var bone in rightHandSkeleton.Bones)
			{
				if (bone.ParentBoneIndex != -1)
				{
					OVRBone parentBone = rightHandSkeleton.Bones[bone.ParentBoneIndex];
					Debug.DrawLine((rhMatrix).MultiplyPoint(bone.Transform.position), (rhMatrix).MultiplyPoint(parentBone.Transform.position));
				}
			}
		}

		if (leftHandSkeleton != null && leftHandSkeleton.IsInitialized && rightHandSkeleton != null && rightHandSkeleton.IsInitialized)
		{
 			SerializePose();
		}
	}

	private void SerializePose()
	{
		HandSerializationNode hs = PoseSerializer.SerializePose(leftHandSkeleton, rightHandSkeleton);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			string jsonString = JsonUtility.ToJson(hs);
			// Date time as string without slashes

			System.IO.File.WriteAllText("C:/Users/MarkRansley/Desktop/" + GestureID + DateTime.Now.ToString().Replace("/", "-").Replace(":", "-").Replace(" ", "_") + ".json", jsonString);
			Debug.LogError("Wrote to file");
		}

		//Debug.DrawLine(hs.leftHandForearmStubPosition, hs.leftHandStartPosition, Color.red);
		//Debug.DrawLine(hs.leftHandThumb0Position, hs.leftHandThumb1Position, Color.red);
		//Debug.DrawLine(hs.leftHandThumb1Position, hs.leftHandThumb2Position, Color.red);
		//Debug.DrawLine(hs.leftHandThumb2Position, hs.leftHandThumb3Position, Color.red);
		//Debug.DrawLine(hs.leftHandThumb3Position, hs.leftHandThumbTipPosition, Color.red);
		//Debug.DrawLine(hs.leftHandIndex1Position, hs.leftHandIndex2Position, Color.red);
		//Debug.DrawLine(hs.leftHandIndex2Position, hs.leftHandIndex3Position, Color.red);
		//Debug.DrawLine(hs.leftHandIndex3Position, hs.leftHandIndexTipPosition, Color.red);
		//Debug.DrawLine(hs.leftHandMiddle1Position, hs.leftHandMiddle2Position, Color.red);
		//Debug.DrawLine(hs.leftHandMiddle2Position, hs.leftHandMiddle3Position, Color.red);
		//Debug.DrawLine(hs.leftHandMiddle3Position, hs.leftHandMiddleTipPosition, Color.red);
		//Debug.DrawLine(hs.leftHandRing1Position, hs.leftHandRing2Position, Color.red);
		//Debug.DrawLine(hs.leftHandRing2Position, hs.leftHandRing3Position, Color.red);
		//Debug.DrawLine(hs.leftHandRing3Position, hs.leftHandRingTipPosition, Color.red);
		//Debug.DrawLine(hs.leftHandPinky0Position, hs.leftHandPinky1Position, Color.red);
		//Debug.DrawLine(hs.leftHandPinky1Position, hs.leftHandPinky2Position, Color.red);
		//Debug.DrawLine(hs.leftHandPinky2Position, hs.leftHandPinky3Position, Color.red);
		//Debug.DrawLine(hs.leftHandPinky3Position, hs.leftHandPinkyTipPosition, Color.red);
		Debug.DrawLine(hs.rightHandForearmStubPosition, hs.rightHandStartPosition, Color.red);
		Debug.DrawLine(hs.rightHandThumb0Position, hs.rightHandThumb1Position, Color.red);
		Debug.DrawLine(hs.rightHandThumb1Position, hs.rightHandThumb2Position, Color.red);
		Debug.DrawLine(hs.rightHandThumb2Position, hs.rightHandThumb3Position, Color.red);
		Debug.DrawLine(hs.rightHandThumb3Position, hs.rightHandThumbTipPosition, Color.red);
		Debug.DrawLine(hs.rightHandIndex1Position, hs.rightHandIndex2Position, Color.red);
		Debug.DrawLine(hs.rightHandIndex2Position, hs.rightHandIndex3Position, Color.red);
		Debug.DrawLine(hs.rightHandIndex3Position, hs.rightHandIndexTipPosition, Color.red);
		Debug.DrawLine(hs.rightHandMiddle1Position, hs.rightHandMiddle2Position, Color.red);
		Debug.DrawLine(hs.rightHandMiddle2Position, hs.rightHandMiddle3Position, Color.red);
		Debug.DrawLine(hs.rightHandMiddle3Position, hs.rightHandMiddleTipPosition, Color.red);
		Debug.DrawLine(hs.rightHandRing1Position, hs.rightHandRing2Position, Color.red);
		Debug.DrawLine(hs.rightHandRing2Position, hs.rightHandRing3Position, Color.red);
		Debug.DrawLine(hs.rightHandRing3Position, hs.rightHandRingTipPosition, Color.red);
		Debug.DrawLine(hs.rightHandPinky0Position, hs.rightHandPinky1Position, Color.red);
		Debug.DrawLine(hs.rightHandPinky1Position, hs.rightHandPinky2Position, Color.red);
		Debug.DrawLine(hs.rightHandPinky2Position, hs.rightHandPinky3Position, Color.red);
		Debug.DrawLine(hs.rightHandPinky3Position, hs.rightHandPinkyTipPosition, Color.red);

	}
}
