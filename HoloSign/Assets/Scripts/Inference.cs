using System.Linq;
using Unity.Sentis;

using UnityEngine;

public class Inference : MonoBehaviour
{
	public OVRSkeleton leftHandSkeleton;
	public OVRSkeleton rightHandSkeleton;

	public string GestureID;

	public ModelAsset modelAsset;
	private Model model;
	//private string modelPath = "model.onnx";
	private IWorker engine;


	string[] gestures = {"1", "2", "3", "4", "5", "6", "7", "8", "A", "B", "C", "D", "E", "F", "G", "H" };

	void Start()
    {
		model = ModelLoader.Load(modelAsset);
		engine = WorkerFactory.CreateWorker(BackendType.GPUCompute, model);
	}

    void Update()
    {
		if (leftHandSkeleton != null && leftHandSkeleton.IsInitialized && rightHandSkeleton != null && rightHandSkeleton.IsInitialized)
		{
			HandSerializationNode hs = PoseSerializer.SerializePose(leftHandSkeleton, rightHandSkeleton);
			float[] ps = new float[]
			{
				hs.leftHandStartPosition.x, hs.leftHandStartPosition.y, hs.leftHandStartPosition.z,
				hs.leftHandForearmStubPosition.x, hs.leftHandForearmStubPosition.y, hs.leftHandForearmStubPosition.z,
				hs.leftHandWristRootPosition.x, hs.leftHandWristRootPosition.y, hs.leftHandWristRootPosition.z,
				hs.leftHandThumb0Position.x, hs.leftHandThumb0Position.y, hs.leftHandThumb0Position.z,
				hs.leftHandThumb1Position.x, hs.leftHandThumb1Position.y, hs.leftHandThumb1Position.z,
				hs.leftHandThumb2Position.x, hs.leftHandThumb2Position.y, hs.leftHandThumb2Position.z,
				hs.leftHandThumb3Position.x, hs.leftHandThumb3Position.y, hs.leftHandThumb3Position.z,
				hs.leftHandThumbTipPosition.x, hs.leftHandThumbTipPosition.y, hs.leftHandThumbTipPosition.z,
				hs.leftHandIndex1Position.x, hs.leftHandIndex1Position.y, hs.leftHandIndex1Position.z,
				hs.leftHandIndex2Position.x, hs.leftHandIndex2Position.y, hs.leftHandIndex2Position.z,
				hs.leftHandIndex3Position.x, hs.leftHandIndex3Position.y, hs.leftHandIndex3Position.z,
				hs.leftHandIndexTipPosition.x, hs.leftHandIndexTipPosition.y, hs.leftHandIndexTipPosition.z,
				hs.leftHandMiddle1Position.x, hs.leftHandMiddle1Position.y, hs.leftHandMiddle1Position.z,
				hs.leftHandMiddle2Position.x, hs.leftHandMiddle2Position.y, hs.leftHandMiddle2Position.z,
				hs.leftHandMiddle3Position.x, hs.leftHandMiddle3Position.y, hs.leftHandMiddle3Position.z,
				hs.leftHandMiddleTipPosition.x, hs.leftHandMiddleTipPosition.y, hs.leftHandMiddleTipPosition.z,
				hs.leftHandRing1Position.x, hs.leftHandRing1Position.y, hs.leftHandRing1Position.z,
				hs.leftHandRing2Position.x, hs.leftHandRing2Position.y, hs.leftHandRing2Position.z,
				hs.leftHandRing3Position.x, hs.leftHandRing3Position.y, hs.leftHandRing3Position.z,
				hs.leftHandRingTipPosition.x, hs.leftHandRingTipPosition.y, hs.leftHandRingTipPosition.z,
				hs.leftHandPinky0Position.x, hs.leftHandPinky0Position.y, hs.leftHandPinky0Position.z,
				hs.leftHandPinky1Position.x, hs.leftHandPinky1Position.y, hs.leftHandPinky1Position.z,
				hs.leftHandPinky2Position.x, hs.leftHandPinky2Position.y, hs.leftHandPinky2Position.z,
				hs.leftHandPinky3Position.x, hs.leftHandPinky3Position.y, hs.leftHandPinky3Position.z,
				hs.leftHandPinkyTipPosition.x, hs.leftHandPinkyTipPosition.y, hs.leftHandPinkyTipPosition.z,

				hs.rightHandStartPosition.x, hs.rightHandStartPosition.y, hs.rightHandStartPosition.z,
				hs.rightHandForearmStubPosition.x, hs.rightHandForearmStubPosition.y, hs.rightHandForearmStubPosition.z,
				hs.rightHandWristRootPosition.x, hs.rightHandWristRootPosition.y, hs.rightHandWristRootPosition.z,
				hs.rightHandThumb0Position.x, hs.rightHandThumb0Position.y, hs.rightHandThumb0Position.z,
				hs.rightHandThumb1Position.x, hs.rightHandThumb1Position.y, hs.rightHandThumb1Position.z,
				hs.rightHandThumb2Position.x, hs.rightHandThumb2Position.y, hs.rightHandThumb2Position.z,
				hs.rightHandThumb3Position.x, hs.rightHandThumb3Position.y, hs.rightHandThumb3Position.z,
				hs.rightHandThumbTipPosition.x, hs.rightHandThumbTipPosition.y, hs.rightHandThumbTipPosition.z,
				hs.rightHandIndex1Position.x, hs.rightHandIndex1Position.y, hs.rightHandIndex1Position.z,
				hs.rightHandIndex2Position.x, hs.rightHandIndex2Position.y, hs.rightHandIndex2Position.z,
				hs.rightHandIndex3Position.x, hs.rightHandIndex3Position.y, hs.rightHandIndex3Position.z,
				hs.rightHandIndexTipPosition.x, hs.rightHandIndexTipPosition.y, hs.rightHandIndexTipPosition.z,
				hs.rightHandMiddle1Position.x, hs.rightHandMiddle1Position.y, hs.rightHandMiddle1Position.z,
				hs.rightHandMiddle2Position.x, hs.rightHandMiddle2Position.y, hs.rightHandMiddle2Position.z,
				hs.rightHandMiddle3Position.x, hs.rightHandMiddle3Position.y, hs.rightHandMiddle3Position.z,
				hs.rightHandMiddleTipPosition.x, hs.rightHandMiddleTipPosition.y, hs.rightHandMiddleTipPosition.z,
				hs.rightHandRing1Position.x, hs.rightHandRing1Position.y, hs.rightHandRing1Position.z,
				hs.rightHandRing2Position.x, hs.rightHandRing2Position.y, hs.rightHandRing2Position.z,
				hs.rightHandRing3Position.x, hs.rightHandRing3Position.y, hs.rightHandRing3Position.z,
				hs.rightHandRingTipPosition.x, hs.rightHandRingTipPosition.y, hs.rightHandRingTipPosition.z,
				hs.rightHandPinky0Position.x, hs.rightHandPinky0Position.y, hs.rightHandPinky0Position.z,
				hs.rightHandPinky1Position.x, hs.rightHandPinky1Position.y, hs.rightHandPinky1Position.z,
				hs.rightHandPinky2Position.x, hs.rightHandPinky2Position.y, hs.rightHandPinky2Position.z,
				hs.rightHandPinky3Position.x, hs.rightHandPinky3Position.y, hs.rightHandPinky3Position.z,
				hs.rightHandPinkyTipPosition.x, hs.rightHandPinkyTipPosition.y, hs.rightHandPinkyTipPosition.z
			};

			//Debug.Log(ps.Length);
			

			TensorShape ts = new TensorShape(1, ps.Length);
			
			TensorFloat inputTensor = new TensorFloat(ts, ps);

			engine.Execute(inputTensor);
			TensorFloat outputTensor = engine.PeekOutput() as TensorFloat;

			outputTensor.MakeReadable();
			//outputTensor.PrintDataPart(8);
			float[] logits = new float[outputTensor.shape[1]];

			for (int i = 0; i < logits.Length; i++)
			{
				logits[i] = outputTensor[i];
			}

			float[] probabilities = Softmax(logits);

			string probLog = "";
			for (int i = 0; i < probabilities.Length; i++)
			{
				probLog += probabilities[i] + "\n";
			}

			//Debug.Log(probLog);

			int maxIndex = 0;
			float maxVal = float.MinValue;
			for (int i = 0; i < probabilities.Length; i++)
			{
				if (outputTensor[i] > maxVal)
				{
					maxVal = outputTensor[i];
					maxIndex = i;
				}
			}

			Debug.Log(gestures[maxIndex] + " " + probabilities[maxIndex]);

			GestureID = gestures[maxIndex];

			outputTensor.Dispose();
			inputTensor.Dispose();
		}
	}

	public static float[] Softmax(float[] logits)
	{
		// Compute the exponentials of the input values
		var expValues = logits.Select(Mathf.Exp).ToArray();

		// Compute the sum of all exponentials
		var sumExp = expValues.Sum();

		// Compute the softmax values by dividing each exponential by the sum of exponentials
		var softmaxValues = expValues.Select(x => x / sumExp).ToArray();

		return softmaxValues;
	}
}
