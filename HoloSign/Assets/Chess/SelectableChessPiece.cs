using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectableChessPiece : MonoBehaviour
{
	public ChessManager chessManager;
	public LetterSpawner letterSpawner;
	private Material originalMaterial;
	private MeshRenderer objectRenderer;
	public string letter;
	public string number;
	public int time;

	private void Start()
	{
		// Get the renderer component and save the original material
		objectRenderer = GetComponent<MeshRenderer>();
		if (objectRenderer != null)
		{
			originalMaterial = objectRenderer.material;
		}

		// Start the delayed action coroutine
		StartCoroutine(DelayedChessAction());
	}

	void OnCollisionEnter(Collision collision)
	{
		objectRenderer.material.color = Color.red;
		objectRenderer.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
		Debug.Log($"{gameObject.name} collided with {collision.gameObject.name} and changed color to red.");
		//chessManager.MovePiece(this.gameObject, "A5");
		chessManager.whitePieceSelected = this.gameObject;
	}

	private IEnumerator DelayedChessAction()
	{
		// Wait for the specified time before executing the chess move
		yield return new WaitForSeconds(time);
		letterSpawner.SpawnElements("A");

		yield return new WaitForSeconds(2);
		objectRenderer.material.color = Color.red;

		yield return new WaitForSeconds(4);
		letterSpawner.SpawnElements(letter);
		yield return new WaitForSeconds(4);
		letterSpawner.SpawnElements(number);
		yield return new WaitForSeconds(2);
		// Perform the chess move
		string newPosition = letter + number;
		chessManager.MovePiece(this.gameObject, newPosition);

		Debug.Log($"{gameObject.name} moved to {newPosition} after {time} seconds.");
	}
}
