using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Puzzle_select : MonoBehaviour
{

    public int numeroImage;


public void SelectImage()
    {
        GameObject.Find("ListaImagenes").GetComponent<List_images>().indiceList = numeroImage;
    }
}