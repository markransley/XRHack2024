using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectableChessPiece : MonoBehaviour
{
	public ChessManager chessManager;
	private Material originalMaterial;
	private MeshRenderer objectRenderer;

	private void Start()
	{
		// Get the renderer component and save the original material
		objectRenderer = GetComponent<MeshRenderer>();
		if (objectRenderer != null)
		{
			originalMaterial = objectRenderer.material;
		}
	}

	void OnCollisionEnter(Collision collision)
	{
		objectRenderer.material.color = Color.red;
		objectRenderer.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
		Debug.Log($"{gameObject.name} collided with {collision.gameObject.name} and changed color to red.");
		//chessManager.MovePiece(this.gameObject, "A5");
		chessManager.whitePieceSelected = this.gameObject;
	}
}
