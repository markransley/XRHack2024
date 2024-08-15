using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class HandSerializationNode 
{
	[SerializeField]
	public Vector3 leftHandStartPosition;
	[SerializeField]
	public Quaternion leftHandStartRotation;
	[SerializeField] 
	public Vector3 leftHandForearmStubPosition;
	[SerializeField]
	public Quaternion leftHandForearmStubRotation;
	[SerializeField]
	public Vector3 leftHandWristRootPosition;
	[SerializeField]
	public Quaternion leftHandWristRootRotation;
	[SerializeField]
	public Vector3 leftHandThumb0Position;
	[SerializeField]
	public Quaternion leftHandThumb0Rotation;
	[SerializeField]
	public Vector3 leftHandThumb1Position;
	[SerializeField]
	public Quaternion leftHandThumb1Rotation;
	[SerializeField]
	public Vector3 leftHandThumb2Position;
	[SerializeField]
	public Quaternion leftHandThumb2Rotation;
	[SerializeField]
	public Vector3 leftHandThumb3Position;
	[SerializeField]
	public Quaternion leftHandThumb3Rotation;
	[SerializeField]
	public Vector3 leftHandThumbTipPosition;
	[SerializeField]
	public Vector3 leftHandIndex1Position;
	[SerializeField]
	public Quaternion leftHandIndex1Rotation;
	[SerializeField]
	public Vector3 leftHandIndex2Position;
	[SerializeField]
	public Quaternion leftHandIndex2Rotation;
	[SerializeField]
	public Vector3 leftHandIndex3Position;
	[SerializeField]
	public Quaternion leftHandIndex3Rotation;
	[SerializeField]
	public Vector3 leftHandIndexTipPosition;
	[SerializeField]
	public Vector3 leftHandMiddle1Position;
	[SerializeField]
	public Quaternion leftHandMiddle1Rotation;
	[SerializeField]
	public Vector3 leftHandMiddle2Position;
	[SerializeField]
	public Quaternion leftHandMiddle2Rotation;
	[SerializeField]
	public Vector3 leftHandMiddle3Position;
	[SerializeField]
	public Quaternion leftHandMiddle3Rotation;
	[SerializeField]
	public Vector3 leftHandMiddleTipPosition;
	[SerializeField]
	public Vector3 leftHandRing1Position;
	[SerializeField]
	public Quaternion leftHandRing1Rotation;
	[SerializeField]
	public Vector3 leftHandRing2Position;
	[SerializeField]
	public Quaternion leftHandRing2Rotation;
	[SerializeField]
	public Vector3 leftHandRing3Position;
	[SerializeField]
	public Quaternion leftHandRing3Rotation;
	[SerializeField]
	public Vector3 leftHandRingTipPosition;
	[SerializeField]
	public Vector3 leftHandPinky0Position;
	[SerializeField]
	public Quaternion leftHandPinky0Rotation;
	[SerializeField]
	public Vector3 leftHandPinky1Position;
	[SerializeField]
	public Quaternion leftHandPinky1Rotation;
	[SerializeField]
	public Vector3 leftHandPinky2Position;
	[SerializeField]
	public Quaternion leftHandPinky2Rotation;
	[SerializeField]
	public Vector3 leftHandPinky3Position;
	[SerializeField]
	public Quaternion leftHandPinky3Rotation;
	[SerializeField]
	public Vector3 leftHandPinkyTipPosition;


	[SerializeField]
	public Vector3 rightHandStartPosition;
	[SerializeField]
	public Quaternion rightHandStartRotation;
	[SerializeField]
	public Vector3 rightHandForearmStubPosition;
	[SerializeField]
	public Quaternion rightHandForearmStubRotation;
	[SerializeField]
	public Vector3 rightHandWristRootPosition;
	[SerializeField]
	public Quaternion rightHandWristRootRotation;
	[SerializeField]
	public Vector3 rightHandThumb0Position;
	[SerializeField]
	public Quaternion rightHandThumb0Rotation;
	[SerializeField]
	public Vector3 rightHandThumb1Position;
	[SerializeField]
	public Quaternion rightHandThumb1Rotation;
	[SerializeField]
	public Vector3 rightHandThumb2Position;
	[SerializeField]
	public Quaternion rightHandThumb2Rotation;
	[SerializeField]
	public Vector3 rightHandThumb3Position;
	[SerializeField]
	public Quaternion rightHandThumb3Rotation;
	[SerializeField]
	public Vector3 rightHandThumbTipPosition;
	[SerializeField]
	public Vector3 rightHandIndex1Position;
	[SerializeField]
	public Quaternion rightHandIndex1Rotation;
	[SerializeField]
	public Vector3 rightHandIndex2Position;
	[SerializeField]
	public Quaternion rightHandIndex2Rotation;
	[SerializeField]
	public Vector3 rightHandIndex3Position;
	[SerializeField]
	public Quaternion rightHandIndex3Rotation;
	[SerializeField]
	public Vector3 rightHandIndexTipPosition;
	[SerializeField]
	public Vector3 rightHandMiddle1Position;
	[SerializeField]
	public Quaternion rightHandMiddle1Rotation;
	[SerializeField]
	public Vector3 rightHandMiddle2Position;
	[SerializeField]
	public Quaternion rightHandMiddle2Rotation;
	[SerializeField]
	public Vector3 rightHandMiddle3Position;
	[SerializeField]
	public Quaternion rightHandMiddle3Rotation;
	[SerializeField]
	public Vector3 rightHandMiddleTipPosition;
	[SerializeField]
	public Vector3 rightHandRing1Position;
	[SerializeField]
	public Quaternion rightHandRing1Rotation;
	[SerializeField]
	public Vector3 rightHandRing2Position;
	[SerializeField]
	public Quaternion rightHandRing2Rotation;
	[SerializeField]
	public Vector3 rightHandRing3Position;
	[SerializeField]
	public Quaternion rightHandRing3Rotation;
	[SerializeField]
	public Vector3 rightHandRingTipPosition;
	[SerializeField]
	public Vector3 rightHandPinky0Position;
	[SerializeField]
	public Quaternion rightHandPinky0Rotation;
	[SerializeField]
	public Vector3 rightHandPinky1Position;
	[SerializeField]
	public Quaternion rightHandPinky1Rotation;
	[SerializeField]
	public Vector3 rightHandPinky2Position;
	[SerializeField]
	public Quaternion rightHandPinky2Rotation;
	[SerializeField]
	public Vector3 rightHandPinky3Position;
	[SerializeField]
	public Quaternion rightHandPinky3Rotation;
	[SerializeField]
	public Vector3 rightHandPinkyTipPosition;
}
