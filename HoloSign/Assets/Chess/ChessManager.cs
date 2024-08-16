using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessManager : MonoBehaviour
{
	public static ChessManager Instance { get; private set; }

	public string newPosition;
	public GameObject boardObject;
	public GameObject whitePieceSelected;
	public List<GameObject> whitePieces;
	public List<GameObject> blackPieces;

	public List<GameObject> chosenBlackPieces;
	public List<string> newPositions;

	private const float boardSize = 12f;
	private const float tileSize = 1.514f;
	private const float halfBoardSize = boardSize / 2;

	private int moveIndex = 0;

	// Method to move a piece based on chess notation
	/*public void MovePiece( string from, string to)
	{
		Vector3 fromLocalPosition = ChessNotationToLocalPosition(from);
		Vector3 toLocalPosition = ChessNotationToLocalPosition(to);
		Debug.Log($"Moving piece from {from} to {to}");
		StartCoroutine(FindAndMovePiece(fromLocalPosition, toLocalPosition));
	}*/

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			MovePiece(whitePieces[9], "A4"); // Replace "pieceToMove" and "E4" with your actual piece and target position
		}
	}

	public void MovePiece(GameObject pieceToMove, string to)
	{
		StartCoroutine(MovePieceSpecific(pieceToMove, to));
		StartCoroutine(MoveBlack());
	}

	private IEnumerator MovePieceSpecific(GameObject pieceToMove, string to, float duration = 1.0f)
	{
		Vector3 fromLocalPosition = pieceToMove.transform.localPosition;
		Vector3 toLocalPosition = ChessNotationToLocalPosition(to);
		float elapsedTime = 0f;

		while (elapsedTime < duration)
		{
			pieceToMove.transform.localPosition = Vector3.Lerp(fromLocalPosition, toLocalPosition, elapsedTime / duration);
			elapsedTime += Time.deltaTime;
			yield return null;
		}

		// Ensure the piece is exactly at the target position at the end of the lerp
		pieceToMove.transform.localPosition = toLocalPosition;
		Debug.Log($"Moved black piece {pieceToMove.name} to {to}");
	}

	private Vector3 ChessNotationToLocalPosition(string chessNotation)
	{
		if (chessNotation.Length != 2)
		{
			Debug.LogError("Invalid chess notation format");
			return Vector3.zero;
		}

		char file = chessNotation[0];
		char rank = chessNotation[1];

		int fileIndex = file - 'A';
		int rankIndex = rank - '1';

		float xPosition = -halfBoardSize + fileIndex * tileSize + tileSize / 2;
		float zPosition = -halfBoardSize + rankIndex * tileSize + tileSize / 2;

		return new Vector3(xPosition, 0, zPosition);
	}


	private IEnumerator MoveBlack()
	{
		Debug.Log("Coroutine Started");
		yield return new WaitForSeconds(2f);

		// Move the next black piece
		if (moveIndex < chosenBlackPieces.Count && moveIndex < newPositions.Count)
		{
			StartCoroutine(MovePieceSpecific(chosenBlackPieces[moveIndex], newPositions[moveIndex]));
			moveIndex++;
		}
		else
		{
			Debug.LogWarning("No more black pieces to move or positions available.");
		}
	}

}
