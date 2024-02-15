using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_difficult : MonoBehaviour
{
    public int numeroEscenaDificultad;
    public void SetDifficult()
    {
        GameObject[] puzzles = GameObject.FindGameObjectsWithTag("Button_puzzleSelect");

        foreach (GameObject Button_puzzleSelect in puzzles)
        {
            Button_puzzleSelect.GetComponent<Scene_script>().numeroEscena = numeroEscenaDificultad;
        }
    }
}
