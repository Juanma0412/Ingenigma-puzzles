using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_over : MonoBehaviour
{
    public GameObject Pop_up;
    public GameObject confeti;
    public int puzzleCount = 0;
    public int totalPuzzlePieces = 0;

    public void PiecePlaced()
    {
        puzzleCount++;

        if (puzzleCount == totalPuzzlePieces)
        {
            // Aquí puedes realizar las acciones que desees cuando se complete el rompecabezas.
            Debug.Log("Rompecabezas armado");
            confeti.SetActive(true);
            Pop_up.SetActive(true);
        }
    }
}
