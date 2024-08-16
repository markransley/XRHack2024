using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PoseSerializer
{
    public static HandSerializationNode SerializePose(OVRSkeleton leftHandSkeleton, OVRSkeleton rightHandSkeleton)
	{
		HandSerializationNode hs = new HandSerializationNode();
		Matrix4x4 lhMatrix = leftHandSkeleton.transform.worldToLocalMatrix;
		Matrix4x4 rhMatrix = rightHandSkeleton.transform.worldToLocalMatrix;

		foreach (var bone in leftHandSkeleton.Bones)
		{
			if (bone.Id == OVRSkeleton.BoneId.Hand_Start)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandStartPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandStartRotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandStartPosition = Vector3.zero;
					hs.leftHandStartRotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_ForearmStub)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandForearmStubPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandForearmStubRotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandForearmStubPosition = Vector3.zero;
					hs.leftHandForearmStubRotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Index1)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandIndex1Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandIndex1Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandIndex1Position = Vector3.zero;
					hs.leftHandIndex1Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Index2)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandIndex2Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandIndex2Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandIndex2Position = Vector3.zero;
					hs.leftHandIndex2Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Index3)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandIndex3Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandIndex3Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandIndex3Position = Vector3.zero;
					hs.leftHandIndex3Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_IndexTip)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandIndexTipPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
				}
				else
				{
					hs.leftHandIndexTipPosition = Vector3.zero;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Middle1)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandMiddle1Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandMiddle1Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandMiddle1Position = Vector3.zero;
					hs.leftHandMiddle1Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Middle2)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandMiddle2Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandMiddle2Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandMiddle2Position = Vector3.zero;
					hs.leftHandMiddle2Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Middle3)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandMiddle3Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandMiddle3Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandMiddle3Position = Vector3.zero;
					hs.leftHandMiddle3Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_MiddleTip)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandMiddleTipPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
				}
				else
				{
					hs.leftHandMiddleTipPosition = Vector3.zero;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Ring1)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandRing1Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandRing1Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandRing1Position = Vector3.zero;
					hs.leftHandRing1Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Ring2)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandRing2Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandRing2Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandRing2Position = Vector3.zero;
					hs.leftHandRing2Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Ring3)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandRing3Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandRing3Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandRing3Position = Vector3.zero;
					hs.leftHandRing3Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_RingTip)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandRingTipPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
				}
				else
				{
					hs.leftHandRingTipPosition = Vector3.zero;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Pinky0)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandPinky0Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandPinky0Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandPinky0Position = Vector3.zero;
					hs.leftHandPinky0Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Pinky1)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandPinky1Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandPinky1Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandPinky1Position = Vector3.zero;
					hs.leftHandPinky1Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Pinky2)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandPinky2Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandPinky2Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandPinky2Position = Vector3.zero;
					hs.leftHandPinky2Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Pinky3)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandPinky3Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandPinky3Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandPinky3Position = Vector3.zero;
					hs.leftHandPinky3Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_PinkyTip)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandPinkyTipPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
				}
				else
				{
					hs.leftHandPinkyTipPosition = Vector3.zero;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Thumb0)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandThumb0Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandThumb0Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandThumb0Position = Vector3.zero;
					hs.leftHandThumb0Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Thumb1)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandThumb1Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandThumb1Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandThumb1Position = Vector3.zero;
					hs.leftHandThumb1Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Thumb2)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandThumb2Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandThumb2Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandThumb2Position = Vector3.zero;
					hs.leftHandThumb2Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Thumb3)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandThumb3Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.leftHandThumb3Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.leftHandThumb3Position = Vector3.zero;
					hs.leftHandThumb3Rotation = Quaternion.identity;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_ThumbTip)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.leftHandThumbTipPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
				}
				else
				{
					hs.leftHandThumbTipPosition = Vector3.zero;
				}
			}
		}


		foreach (var bone in rightHandSkeleton.Bones)
		{
			if (bone.Id == OVRSkeleton.BoneId.Hand_Start)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandStartPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandStartRotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandStartPosition = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandStartRotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_ForearmStub)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandForearmStubPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandForearmStubRotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandForearmStubPosition = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandForearmStubRotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Index1)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandIndex1Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandIndex1Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandIndex1Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandIndex1Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Index2)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandIndex2Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandIndex2Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandIndex2Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandIndex2Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Index3)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandIndex3Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandIndex3Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandIndex3Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandIndex3Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_IndexTip)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandIndexTipPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
				}
				else
				{
					hs.rightHandIndexTipPosition = Vector3.zero;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Middle1)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandMiddle1Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandMiddle1Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandMiddle1Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandMiddle1Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Middle2)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandMiddle2Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandMiddle2Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandMiddle2Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandMiddle2Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Middle3)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandMiddle3Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandMiddle3Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandMiddle3Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandMiddle3Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_MiddleTip)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandMiddleTipPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
				}
				else
				{
					hs.rightHandMiddleTipPosition = Vector3.zero;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Ring1)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandRing1Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandRing1Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandRing1Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandRing1Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Ring2)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandRing2Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandRing2Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandRing2Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandRing2Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Ring3)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandRing3Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandRing3Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandRing3Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandRing3Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_RingTip)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandRingTipPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
				}
				else
				{
					hs.rightHandRingTipPosition = Vector3.zero;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Pinky0)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandPinky0Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandPinky0Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandPinky0Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandPinky0Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Pinky1)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandPinky1Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandPinky1Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandPinky1Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandPinky1Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Pinky2)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandPinky2Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandPinky2Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandPinky2Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandPinky2Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Pinky3)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandPinky3Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandPinky3Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandPinky3Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandPinky3Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_PinkyTip)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandPinkyTipPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
				}
				else
				{
					hs.rightHandPinkyTipPosition = Vector3.zero;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Thumb0)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandThumb0Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandThumb0Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandThumb0Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandThumb0Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Thumb1)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandThumb1Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandThumb1Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandThumb1Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandThumb1Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Thumb2)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandThumb2Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandThumb2Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandThumb2Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandThumb2Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_Thumb3)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandThumb3Position = lhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandThumb3Rotation = (lhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
				else
				{
					hs.rightHandThumb3Position = rhMatrix.MultiplyPoint(bone.Transform.position);
					hs.rightHandThumb3Rotation = (rhMatrix * bone.Transform.localToWorldMatrix).rotation;
				}
			}
			if (bone.Id == OVRSkeleton.BoneId.Hand_ThumbTip)
			{
				if (leftHandSkeleton.IsDataValid)
				{
					hs.rightHandThumbTipPosition = lhMatrix.MultiplyPoint(bone.Transform.position);
				}
				else
				{
					hs.rightHandThumbTipPosition = Vector3.zero;
				}
			}
		}
		return hs;
	}
}
